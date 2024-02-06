using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Price;

public class GroupWeaponPriceChangerManager
{
  private static readonly object Locker = new();
  private static volatile GroupWeaponPriceChangerManager _singleton;
  private Dictionary<long, GroupWeaponPriceList> _priceData;

  private GroupWeaponPriceChangerManager() {
    Clear();
  }

  public static GroupWeaponPriceChangerManager This() {
    if (_singleton == null)
      lock (Locker) {
        if (_singleton == null)
          _singleton = new GroupWeaponPriceChangerManager();
      }

    return _singleton;
  }

  public void Clear() {
    _priceData = new Dictionary<long, GroupWeaponPriceList>();
  }

  public void Add(ResultWorldMarketAccumulateTrade record,
                  TradeMarketItemInfo itemInfo) {
    if (!_priceData.ContainsKey(itemInfo._marketPriceGroup))
      _priceData.Add(itemInfo._marketPriceGroup, new GroupWeaponPriceList());
    _priceData[itemInfo._marketPriceGroup]._list.Add(new GroupWeaponPriceChanger(record, itemInfo));
  }

  public void Update() {
    var orderedEnumerable = _priceData.Keys.ToList().OrderByDescending(key => key);
    long beforeEnchantPrice = 0;
    var ctxTrade = new TradeDbContext();
    foreach (var key in orderedEnumerable) {
      var groupWeaponPriceList = _priceData[key];
      groupWeaponPriceList.AverageCurrentPrice();
      VariedPriceInfoManager.This.GetWorldMarketPassCount(groupWeaponPriceList._currentPrice, ref groupWeaponPriceList._passBiddingCount, ref groupWeaponPriceList._worldMarketPricePoint);
      var enchantLevel = (int)key % 100;
      var currentPrice = groupWeaponPriceList._currentPrice;
      var flag1 = beforeEnchantPrice != 0L && beforeEnchantPrice < currentPrice;
      var count1 = groupWeaponPriceList._list.Count;
      for (var index = 0; index < count1; ++index) {
        var weaponPriceChanger = _priceData[key]._list[index];
        if (weaponPriceChanger._record._sumTradeCount >= weaponPriceChanger._itemInfo._tradeCountToUpdate ||
            weaponPriceChanger._record._accumulateTickCount >= groupWeaponPriceList._worldMarketPricePoint ||
            weaponPriceChanger._record._accumulateBiddingCount >= groupWeaponPriceList._passBiddingCount || flag1) {
          groupWeaponPriceList._isChange = true;
          break;
        }
      }

      if (groupWeaponPriceList._isChange) {
        var biddingGroupPriceList = new BiddingGroupPriceList();
        try {
          biddingGroupPriceList.list = ctxTrade.ListGroupBiddingPrice_Unsafe(key,
                                                                             groupWeaponPriceList._currentPrice,
                                                                             OptionManager.This.MinPriceRatio,
                                                                             OptionManager.This.MaxPriceRatio)
                                               .ToList();
        }
        catch (Exception ex) {
          TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
          LogUtil.WriteLog("uspListGroupBiddingPrice error : " + ex, "ERROR");
          continue;
        }

        var flag2 = false;
        long num1 = 0;
        long num2 = 0;
        if (biddingGroupPriceList.list != null && 0 < biddingGroupPriceList.list.Count)
          foreach (var biddingPriceResult in biddingGroupPriceList.list)
            if (0L <= num1 + biddingPriceResult._pricePerOne * biddingPriceResult._leftCount) {
              if (0L < biddingPriceResult._leftCount) {
                num1 += biddingPriceResult._pricePerOne * biddingPriceResult._leftCount;
                num2 += biddingPriceResult._leftCount;
              }
            }
            else {
              flag2 = true;
              break;
            }

        var count2 = groupWeaponPriceList._list.Count;
        if (!flag2 && 0 < count2)
          for (var index = 0; index < count2; ++index) {
            var weaponPriceChanger = _priceData[key]._list[index];
            if (0L <= num1 + weaponPriceChanger._record._sumTradePrice) {
              num1 += weaponPriceChanger._record._sumTradePrice;
              num2 += weaponPriceChanger._record._sumTradeCount;
            }
            else {
              break;
            }
          }

        var newPrice = (long)(num1 / (double)num2);
        var num3 = newPrice;
        if (num2 == 0L)
          newPrice = currentPrice;
        var num4 = (long)(groupWeaponPriceList._currentPrice * (1.0 - OptionManager.This.BiddingRatio));
        var num5 = (long)(groupWeaponPriceList._currentPrice * (1.0 + OptionManager.This.BiddingRatio));
        if (num4 < groupWeaponPriceList._list[0]._itemInfo._realMinPrice)
          num4 = groupWeaponPriceList._list[0]._itemInfo._realMinPrice;
        if (groupWeaponPriceList._list[0]._itemInfo._realMaxPrice < num5)
          num5 = groupWeaponPriceList._list[0]._itemInfo._realMaxPrice;
        if (num4 > newPrice || newPrice > num5) {
          if (newPrice < num4)
            newPrice = num4;
          if (num5 < newPrice)
            newPrice = num5;
        }

        var price = VariedPriceInfoManager.This.CalculatePrice(newPrice);
        if (price == 0L) {
          TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
        }
        else {
          TickCountCommon.checkAndUpdateBeforePrice(beforeEnchantPrice, ref price);
          if (num2 == 0L)
            num3 = price;
          var fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
          long fluctuationPrice = 0;
          TickCountCommon.fluctuationCalc(price, groupWeaponPriceList._currentPrice, ref fluctuationType, ref fluctuationPrice);
          try {
            TradeDbManager.This.uspUpdateWorldMarketGroupPrice(key,
                                                               price,
                                                               num3,
                                                               (byte)fluctuationType,
                                                               fluctuationPrice,
                                                               out var symNo,
                                                               out var rv);
            var int32 = Convert.ToInt32(rv);
            if (int32 != 0) {
              LogUtil.WriteLog(string.Format("uspUpdateWorldMarketGroupPrice fail : {0} rv : {1}", key, int32), "WARN");
              TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
            }
            else {
              TickCountCommon.enchantLevelCalc(price, enchantLevel, ref beforeEnchantPrice);
            }
          }
          catch (Exception ex) {
            LogUtil.WriteLog("uspUpdateWorldMarketGroupPrice error : " + ex, "ERROR");
            TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
          }
        }
      }

      else {
        _priceData[key]
          ._list.ForEach((Action<GroupWeaponPriceChanger>)(weaponChanger => {
                                                              try {
                                                                var record = weaponChanger._record;
                                                                var resUpdateWorldMarketPassCount = ctxTrade.UpdateWorldMarketPassCount(record._mainKey,
                                                                     record._subKey,
                                                                    OptionManager.This.MinPriceRatio,
                                                                    OptionManager.This.MaxPriceRatio
                                                                   );
                                                                if (!resUpdateWorldMarketPassCount.Status) {
                                                                  Log.Warning("UpdateWorldMarketPassCount fail {@result}", resUpdateWorldMarketPassCount);
                                                                  return;
                                                                }
                                                              }
                                                              catch (Exception ex) {
                                                                Log.Error(ex, "UpdateWorldMarketPassCount Exception");
                                                              }
                                                            }));
        TickCountCommon.enchantLevelCalc(currentPrice, enchantLevel, ref beforeEnchantPrice);
      }
    }
  }
}