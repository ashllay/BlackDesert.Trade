using BlackDesert.Trade.Business.Manager.Price;
using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.Xml;

namespace BlackDesert.Trade.Business.Manager.Server;

public sealed class TickCountManager : SingletonBase<TickCountManager>
{
  private readonly List<int> _mainGroupList;
  private readonly Dictionary<int, int> _tickCountList;

  private TickCountManager() {
    _tickCountList = new Dictionary<int, int>();
    _mainGroupList = new List<int>();

    ServerControlLogger.LogStart(nameof(TickCountManager));
    var stopwatch = Stopwatch.StartNew();
    var tickCountList = new TickCountList();
    var xmlData = XmlModule.This.ReadXml<XmlMarketCategoryTickCountList>();
    foreach (var tickCount in xmlData.TickCounts) {
      var key = tickCount.MainGroupNo;
      var num = tickCount.NeedTickForUpdate;
      _tickCountList.Add(key, num);
      _mainGroupList.Add(key);
    }
var ctxTrade = new TradeDbContext();
    var resListTickCount =ctxTrade.ListTickCount();
    if (!resListTickCount.Status) {
      throw new TradeMarketServerInitException(nameof(TickCountManager), resListTickCount.Rv, "ListTickCount Fail");
    }

    tickCountList.list = resListTickCount.Data;

    if (_tickCountList.Count != tickCountList.list.Count) {
      var xmlCount = _tickCountList.Count;
      var dbCount = tickCountList.list.Count;
      throw new TradeMarketServerInitException(nameof(TickCountManager), -1, $"Fail UpdateTick xmlCount : {xmlCount}  DB Count : {dbCount} ");
    }

    var allowMainGroup = ServerInfoManager.This.GetAllowMainGroup();
    if (allowMainGroup == null) {
      throw new TradeMarketServerInitException(nameof(TickCountManager), -3, "Fail getAllowMainGroup is  Empty");
    }

    foreach (var listTickCountResult in tickCountList.list) {
      var info = listTickCountResult;
      if (!allowMainGroup.Exists(x => x == info._mainGroupNo))
        _mainGroupList.Remove(info._mainGroupNo);
    }

    if (_mainGroupList.Count == 0) {
      throw new TradeMarketServerInitException(nameof(TickCountManager), -5, "Fail _mainGroupList is  Empty");
    }

    foreach (var mainGroup in _mainGroupList)
      Log.Information("TickCountManager.Open() MainCategory : {MainCategory} ", mainGroup.ToString());

    var rv = UpdateTickCountToRepositoryXxx();
    if (rv != 0) {
      throw new TradeMarketServerInitException(nameof(TickCountManager), rv, "updateTickCountToRepositoryXXX open");
      stopwatch.Stop();
      ServerControlLogger.LogComplete(nameof(TickCountManager), stopwatch.ElapsedMilliseconds);
    }
  }


  private int UpdateTickCountToRepositoryXxx() {
    ServerControlLogger.LogStart(nameof(TickCountManager) + " " + nameof(UpdateTickCountToRepositoryXxx));
    var stopwatch = new Stopwatch();
    stopwatch.Start();
    var dictionary = new Dictionary<int, int>(_tickCountList);
    var ctxTrade = new TradeDbContext();
    var tickCountList = new TickCountList();
    try {
      var resListTickCount = ctxTrade.ListTickCount();
      if (!resListTickCount.Status) {
        throw new Exception("ListTickCount Fail");
      }

      tickCountList.list = resListTickCount.Data;
    }
    catch (Exception ex) {
      Log.Error(ex, "TickCountManager.UpdateTickCountToRepositoryXXX() uspListTickCount Exception");
      return -1;
    }

    if (_tickCountList.Count != tickCountList.list.Count) {
      var count = _tickCountList.Count;
      var str1 = count.ToString();
      count = tickCountList.list.Count;
      var str2 = count.ToString();
      Log.Warning("TickCountManager.UpdateTickCountToRepositoryXXX() Fail UpdateTick xmlCount : {XmlCount}  DB Count : {DbCount} ", str1, str2);
      return -3;
    }

    foreach (var listTickCountResult in tickCountList.list) {
      var cMainGroupNo = listTickCountResult._mainGroupNo;
      if (_tickCountList.ContainsKey(cMainGroupNo) && listTickCountResult._updateTickCount == _tickCountList[cMainGroupNo])
        dictionary.Remove(cMainGroupNo);
    }

    foreach (var keyValuePair in dictionary) {
      var key = keyValuePair.Key;
      var num = keyValuePair.Value;
      try {
        var res = ctxTrade.SetUpdateTickCount(key, num);
        if (!res.Status)
          Log.Warning("TickCountManager.UpdateTickCountToRepositoryXXX() Fail uspSetUpdateTickCount MainCategory : {MainCategory}  rv : {Rv} ",
                      key.ToString(),
                      res.Rv.ToString());
      }
      catch (Exception ex) {
        Log.Error(ex, "TickCountManager.UpdateTickCountToRepositoryXXX() uspSetUpdateTickCount Exception");
        return -2;
      }
    }

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(TickCountManager) + " " + nameof(UpdateTickCountToRepositoryXxx), stopwatch.ElapsedMilliseconds);
    return 0;
  }

  // public void UpdateTickCountXxx() {
  //   var intList = new List<int>();
  //   foreach (var mainGroup in _mainGroupList)
  //     try {
  //       var res = EfCoreTradeDbManager.This.IncreaseTickCount_Unsafe(mainGroup);
  //       if (!res.Status)
  //         Log.Warning("TickCountManager.UpdateTickCountXXX() Fail uspIncreaseTickCount {MainCategory} {@Result} ", mainGroup, res);
  //       else if (Convert.ToBoolean(res.Data))
  //         intList.Add(mainGroup);
  //     }
  //     catch (Exception ex) {
  //       Log.Error(ex, "TickCountManager.UpdateTickCountXXX() uspIncreaseTickCount Exception");
  //     }
  //
  //   foreach (var mainGroupNo in intList)
  //     UpdatePriceWorldMarketXxx(mainGroupNo);
  // }  
  public void UpdateTickCountXxx() {
    var intList = new List<int>();
    var ctxTrade = new TradeDbContext();

    try {
      var res = ctxTrade.IncreaseTickCount_List_Unsafe(_mainGroupList);
      if (!res.Status) {
        Log.Warning("TickCountManager.UpdateTickCountXXX() Fail uspIncreaseTickCount {@Result} ", res);
        return;
      }
      intList = res.Data;
    }
    catch (Exception ex) {
      Log.Error(ex, "TickCountManager.UpdateTickCountXXX() uspIncreaseTickCount Exception");
    }
    foreach (var mainGroupNo in intList)
      UpdatePriceWorldMarketXxx(mainGroupNo);
  }

  public void UpdatePriceWorldMarketXxx(int mainGroupNo) {
    var listAccumulateTrade = new TradeMarketListAccumulateTrade();
    long beforeEnchantPrice = 0;
    var ctxTrade = new TradeDbContext();

    try {
      listAccumulateTrade.list = ctxTrade.ListWorldMarketAccumulateTrade_Unsafe(mainGroupNo);
    }
    catch (Exception ex) {
      Log.Error(ex, "TickCountManager.UpdatePriceWorldMarketXXX() uspListWorldMarketAccumulateTrade Exception");
      return;
    }

    GroupPriceChangerManager.This().clear();
    GroupWeaponPriceChangerManager.This().Clear();
    foreach (var record in listAccumulateTrade.list) {
      var info = ItemInfoManager.This.GetInfo(record._mainKey, record._subKey);
      if (!info.IsValid()) {
        beforeEnchantPrice = 0L;
      }
      else {
        long passBiddingCount = 0;
        long worldMarketPricePoint = 0;
        VariedPriceInfoManager.This.GetWorldMarketPassCount(record._pricePerOne, ref passBiddingCount, ref worldMarketPricePoint);
        if (passBiddingCount == 0L || worldMarketPricePoint == 0L) {
          beforeEnchantPrice = 0L;
          Log.Warning("TickCountManager.UpdatePriceWorldMarketXXX() Fail getWorldMarketPassCount({passBiddingCount}, {worldMarketPricePoint}),  Error pricePerOne {pricePerOne} ",
                      passBiddingCount,
                      worldMarketPricePoint,
                      record._pricePerOne);
        }
        else if (0L < record._priceGroupKey) {
          GroupWeaponPriceChangerManager.This().Add(record, info);
          beforeEnchantPrice = 0L;
        }
        else {
          var cPricePerOne = record._pricePerOne;
          var flag = beforeEnchantPrice != 0L && beforeEnchantPrice < cPricePerOne;
          if (record._sumTradeCount < info._tradeCountToUpdate && record._accumulateTickCount < worldMarketPricePoint && record._accumulateBiddingCount < passBiddingCount && !flag) {
            if (info.HasPriceGroup()) {
              GroupPriceChangerManager.This().add(record, record._pricePerOne, record._pricePerOne);
              TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
            }
            else {
              try {
                var resUpdateWorldMarketPassCount = ctxTrade.UpdateWorldMarketPassCount(record._mainKey,
                                                                                                         record._subKey,
                                                                                        OptionManager.This.MinPriceRatio,
                                                                                        OptionManager.This.MaxPriceRatio);
                if (!resUpdateWorldMarketPassCount.Status) {
                  Log.Warning("TickCountManager.UpdatePriceWorldMarketXXX() Fail uspUpdateWorldMarketPassCount  mainKey : {MainKey}  subKey : {SubKey}  rv : {Rv} ",
                              record._mainKey,
                              record._subKey,
                              resUpdateWorldMarketPassCount.Rv);
                }
              }
              catch (Exception ex) {
                Log.Error(ex, "TickCountManager.UpdatePriceWorldMarketXXX() uspUpdateWorldMarketPassCount Exception");
              }

              TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
            }
          }
          else {
            var num1 = (long)(cPricePerOne * (1.0 - OptionManager.This.BiddingRatio));
            var num2 = (long)(cPricePerOne * (1.0 + OptionManager.This.BiddingRatio));
            if (num1 < info._realMinPrice)
              num1 = info._realMinPrice;
            if (info._realMaxPrice < num2)
              num2 = info._realMaxPrice;
            long newPrice;
            if (info._tradeCountToUpdate <= record._sumTradeCount) {
              newPrice = (long)(record._sumTradePrice / (double)record._sumTradeCount);
            }
            else if (worldMarketPricePoint <= record._accumulateTickCount || passBiddingCount <= record._accumulateBiddingCount || flag) {
              if (record._sumTradeCount == 0L) {
                var enchantMaxGroup = ItemInfoManager.This.GetEnchantMaxGroup(record._mainKey, info._enchantGroup);
                var biddingPriceList = new BiddingPriceList();
                try {
                  var result = ctxTrade.ListBiddingPrice(record._mainKey,
                                                                          record._subKey,
                                                                          enchantMaxGroup,
                                                                          record._pricePerOne,
                                                                          OptionManager.This.MinPriceRatio,
                                                                          OptionManager.This.MaxPriceRatio);
                  if (!result.Status) {
                    throw new Exception("ListBiddingPrice Fail");
                  }

                  biddingPriceList.list = result.Data;
                }
                catch (Exception ex) {
                  TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
                  Log.Error(ex, "TickCountManager.UpdatePriceWorldMarketXXX() uspListBiddingPrice Exception");
                  continue;
                }

                if (biddingPriceList.list != null && 0 < biddingPriceList.list.Count) {
                  long num3 = 0;
                  long num4 = 0;
                  foreach (var biddingPriceResult in biddingPriceList.list)
                    if (0L < num3 + biddingPriceResult._pricePerOne * biddingPriceResult._leftCount) {
                      num3 += biddingPriceResult._pricePerOne * biddingPriceResult._leftCount;
                      num4 += biddingPriceResult._leftCount;
                    }
                    else {
                      break;
                    }

                  newPrice = (long)(num3 / (double)num4);
                }
                else {
                  newPrice = record._pricePerOne;
                }
              }
              else {
                newPrice = (long)(record._sumTradePrice / (double)record._sumTradeCount);
              }
            }
            else {
              TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
              Log.Warning("newPrice fail {keyType},  {mainKey},  {subKey}", record._keyType, record._mainKey, record._subKey);
              continue;
            }

            var nextGraphPrice = newPrice;
            if (num1 > newPrice || newPrice > num2) {
              if (newPrice < num1)
                newPrice = num1;
              if (num2 < newPrice)
                newPrice = num2;
            }

            var price = VariedPriceInfoManager.This.CalculatePrice(newPrice);
            if (price == 0L) {
              TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
              Log.Warning("calculatePrice fail  {keyType},   {mainKey},  {subKey},  {newPrice}", record._keyType, record._mainKey, record._subKey, price);
            }
            else {
              TickCountCommon.checkAndUpdateBeforePrice(beforeEnchantPrice, ref price);
              if (info.HasPriceGroup()) {
                GroupPriceChangerManager.This().add(record, price, nextGraphPrice);
                TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
              }
              else {
                var fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
                long fluctuationPrice = 0;
                TickCountCommon.fluctuationCalc(price, cPricePerOne, ref fluctuationType, ref fluctuationPrice);
                try {
                  TradeDbManager.This.uspUpdateWorldMarketPrice(record._keyType,
                                                                record._mainKey,
                                                                record._subKey,
                                                                price,
                                                                nextGraphPrice,
                                                                (byte)fluctuationType,
                                                                fluctuationPrice,
                                                                0L,
                                                                out var symNo,
                                                                out var rv);
                  if (rv != 0) {
                    Log.Warning("uspUpdateWorldMarketPrice fail  {keyType},  {mainKey},  {subKey},  {newPrice}, {rv}",
                                record._keyType,
                                record._mainKey,
                                record._subKey,
                                price,
                                rv);
                    TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
                  }
                  else {
                    TickCountCommon.enchantLevelCalc(price, record._subKey, ref beforeEnchantPrice);
                  }
                }
                catch (Exception ex) {
                  Log.Error(ex, "TickCountManager.UpdatePriceWorldMarketXXX() uspUpdateWorldMarketPrice Exception");
                  TickCountCommon.enchantLevelCalc(cPricePerOne, record._subKey, ref beforeEnchantPrice);
                }
              }
            }
          }
        }
      }
    }

    GroupPriceChangerManager.This().update();
    foreach (var changer in GroupPriceChangerManager.This().changerList)
      if (changer.PriceRatio != changer.NextPriceRatio) {
        var cMaxTradeCount = changer.Record._maxTradeCount;
        var fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Normal;
        long fluctuationPrice = 0;
        TickCountCommon.fluctuationCalc(changer.NextPrice, changer.Price, ref fluctuationType, ref fluctuationPrice);
        try {
          var record = changer.Record;
          TradeDbManager.This.uspUpdateWorldMarketPrice(record._keyType,
                                                        record._mainKey,
                                                        record._subKey,
                                                        changer.NextPrice,
                                                        changer.NextGraphPrice,
                                                        (byte)fluctuationType,
                                                        fluctuationPrice,
                                                        cMaxTradeCount,
                                                        out var symNo,
                                                        out var rv);
          if (rv != 0)
            Log.Warning("uspUpdateWorldMarketPrice fail  {keyType}, {mainKey},  {subKey},  {newPrice},  {rv}",
                        record._keyType,
                        record._mainKey,
                        record._subKey,
                        changer.NextPrice,
                        rv);
        }
        catch (Exception ex) {
          Log.Error(ex, "TickCountManager.UpdatePriceWorldMarketXXX() uspUpdateWorldMarketPrice Exception");
        }
      }
      else {
        try {
          var record = changer.Record;
          var resUpdateWorldMarketPassCount = ctxTrade.UpdateWorldMarketPassCount(record._mainKey, record._subKey, OptionManager.This.MinPriceRatio, OptionManager.This.MaxPriceRatio);
          if (!resUpdateWorldMarketPassCount.Status)
            Log.Warning("uspUpdateWorldMarketPassCount fail   {mainKey},  {subKey},  {@result}",
                        record._mainKey,
                        record._subKey,
                        resUpdateWorldMarketPassCount);
        }
        catch (Exception ex) {
          Log.Error(ex, "TickCountManager.UpdatePriceWorldMarketXXX() uspUpdateWorldMarketPassCount Exception");
        }
      }

    GroupWeaponPriceChangerManager.This().Update();
    Log.Information("updatePriceWorldMarketXXX complete mainGroupNo:{0},  ", mainGroupNo);
  }

  public bool IsExistsMainGroupNo(int mainGroupNo) {
    return _tickCountList.ContainsKey(mainGroupNo);
  }

  public List<int> GetMainGroupListXxx() {
    return _mainGroupList;
  }

  public void UpdatePriceTargetXxx(bool isIncrease,
                                   int keyType,
                                   int mainKey,
                                   int subKey) {
    long? pricePerOne = 0;
    var rv = 0;
    var symNo = string.Empty;
    var ctxTrade = new TradeDbContext();
    try {
      pricePerOne = ctxTrade.GetItemPrice_Unsafe(mainKey, subKey);
    }
    catch (Exception ex) {
      Log.Error(ex, "TickCountManager.UpdatePriceTargetXXX() Exception");
      return;
    }

    if (rv != 0) {
      Log.Warning("TickCountManager.UpdatePriceTargetXXX() Fail {Rv}", rv);
    }
    else {
      var int64 = Convert.ToInt64(pricePerOne);
      long price;
      FluctuationType fluctuationType;
      long num;
      if (isIncrease) {
        var newPrice = (long)(int64 * (1.0 + OptionManager.This.BiddingRatio));
        price = VariedPriceInfoManager.This.CalculatePrice(newPrice);
        fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Up;
        num = price - int64;
      }
      else {
        var newPrice = (long)(int64 * (1.0 - OptionManager.This.BiddingRatio));
        price = VariedPriceInfoManager.This.CalculatePrice(newPrice);
        fluctuationType = FluctuationType.eWorldMarket_FluctuationType_Down;
        num = int64 - price;
      }

      try {
        TradeDbManager.This.uspUpdateWorldMarketPrice(keyType,
                                                      mainKey,
                                                      subKey,
                                                      price,
                                                      price,
                                                      (byte)fluctuationType,
                                                      num,
                                                      0L,
                                                      out symNo,
                                                      out rv);
      }
      catch (Exception ex) {
        Log.Error(ex, "TickCountManager.UpdatePriceTargetXXX() Exception");
        return;
      }

      if (rv == 0)
        return;
      Log.Warning("TickCountManager.UpdatePriceTargetXXX() Fail {KeyType} {MainKey} {SubKey} {NewPrice} {Rv}",
                  keyType,
                  mainKey,
                  subKey,
                  price,
                  rv);
    }
  }
}