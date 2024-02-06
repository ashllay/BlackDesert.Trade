using BlackDesert.Trade.Db.Entities.GameEntities;
using BlackDesert.Trade.Db.Entities.TradeEntities;
using BlackDesert.Trade.Domain.Common;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Exceptions;
using BlackDesert.Trade.Domain.Models;
using BlackDesert.Trade.Domain.Models.Db;
using BlackDesert.Trade.Domain.Models.EfCore;

using Serilog;
using ResultWorldMarketDetail = BlackDesert.Trade.Domain.Models.Db.ResultWorldMarketDetail;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class TradeDbContext
{
  public bool IsMarketOpen() {
    try {
      var marketOpen = TblWorldMarketOptions.FirstOrDefault();
      return marketOpen != null && marketOpen.IsMarketOpen == true;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] IsMarketOpen() Exception");
      return false;
    }
  }

  public DbResult<bool> CreateOrUpdateMyWallet_Unsafe(string userId,
                                                      long userNo,
                                                      string userNickname,
                                                      DateTime valuePackageExpiration,
                                                      DateTime addWeightBuffExpiration,
                                                      int addPearlItemLimitedCount,
                                                      int maidCount,
                                                      bool isGameMaster,
                                                      double addTaxDiscountRateByFamilyPoint,
                                                      int addTaxDiscountRateByFamilySkill,
                                                      int increaseWeight,
                                                      int increaseWeightByBuff,
                                                      int tradeRingBuff) {
    var created = false;
    if (!isGameMaster) {
      var isMarketOpen = IsMarketOpen();
      if (!isMarketOpen) return DbResult<bool>.Error(-1, MarketError.TRADE_MARKET_MAINTENANCE_TITLE.GetResourceValue());
    }

    using var tradeTran = Database.BeginTransaction();
    var currentWalletData = TblWorldMarketWalletInfos.FirstOrDefault(x => x.UserNo == userNo
                                                                    );
    if (currentWalletData is null) {
      var newWalletData = new TblWorldMarketWalletInfo {
        UserId = userId,
        UserNo = userNo,
        UserNickname = userNickname,
        PackageExpiration = valuePackageExpiration,
        AddPearlItemLimitedCount = addPearlItemLimitedCount,
        MaidCount = maidCount,
        IsGameMaster = isGameMaster,
        AddTaxDiscountRate = addTaxDiscountRateByFamilyPoint,
        FamilySkillAddTaxDiscountRate = addTaxDiscountRateByFamilySkill,
        AddWeight = increaseWeight,
        AddWeightBuffExpiration = addWeightBuffExpiration,
        AddWeightByBuff = increaseWeightByBuff,
        RegisterDate = DateTime.Now
      };
      TblWorldMarketWalletInfos.Add(newWalletData);
      created = true;
    }
    else {
      currentWalletData.UserId = userId;
      currentWalletData.UserNo = userNo;
      currentWalletData.UserNickname = userNickname;
      currentWalletData.PackageExpiration = valuePackageExpiration;
      currentWalletData.AddPearlItemLimitedCount = addPearlItemLimitedCount;
      currentWalletData.MaidCount = maidCount;
      currentWalletData.IsGameMaster = isGameMaster;
      currentWalletData.AddTaxDiscountRate = addTaxDiscountRateByFamilyPoint;
      currentWalletData.FamilySkillAddTaxDiscountRate = addTaxDiscountRateByFamilySkill;
      currentWalletData.AddWeight = increaseWeight;
      currentWalletData.AddWeightBuffExpiration = addWeightBuffExpiration;
      currentWalletData.AddWeightByBuff = increaseWeightByBuff;
      TblWorldMarketWalletInfos.Update(currentWalletData);
    }

    var saveResult = SaveChanges();
    if (saveResult <= 0) return DbResult<bool>.Error(-2, GameErrorType.eErrNoWorldMarketUpdateWalletFaill.ToString());

    var currentRingBuff = TblWorldMarketRingBuffs.FirstOrDefault(x => x.UserNo == userNo);
    if (currentRingBuff is null) {
      var newRingBuff = new TblWorldMarketRingBuff {
        UserNo = userNo,
        MaxCount = tradeRingBuff
      };
      TblWorldMarketRingBuffs.Add(newRingBuff);
    }
    else {
      currentRingBuff.MaxCount = tradeRingBuff;
      TblWorldMarketRingBuffs.Update(currentRingBuff);
    }

    var saveResult2 = SaveChanges();
    if (saveResult2 <= 0) return DbResult<bool>.Error(-3, GameErrorType.eErrNoWorldMarketCreateWalletFail.ToString());
    return created;
  }

  public List<ResultWorldMarketMyWallet> ListWorldMarketMyWallet_Unsafe(long userNo) {
    var query = (from walletItem in TblWorldMarketWallets
                 where walletItem.UserNo == userNo
                       && walletItem.Count > 0
                 select new ResultWorldMarketMyWallet {
                   _keyType = walletItem.KeyType,
                   _mainKey = walletItem.MainKey,
                   _subKey = walletItem.SubKey,
                   _count = walletItem.Count,
                   _isSealed = walletItem.IsSealed,
                   _userNo = walletItem.UserNo
                 }).AsNoTracking();
    return query.ToList();
  }

  public void UpdateMyWalletWeight_Force_Unsafe(long userNo,
                                                long totalWeight) {
    var currentWalletData = TblWorldMarketWalletInfos.FirstOrDefault(x => x.UserNo == userNo);
    TradeMarketDbNotFoundException.ThrowIfNull(currentWalletData,
                                               nameof(TblWorldMarketWalletInfo),
                                               userNo,
                                               totalWeight);
    currentWalletData.Weight = totalWeight;
    TblWorldMarketWalletInfos.Update(currentWalletData);
    var saveResult = SaveChanges();
    TradeMarketDbSaveException.ThrowIfNotSuccess(saveResult,
                                                 nameof(UpdateMyWalletWeight_Force_Unsafe),
                                                 userNo,
                                                 totalWeight);
  }

  public Result_GetPearlItemTradeCount GetPearlItemTradeCount_Force_Unsafe(long userNo) {
    var currentWalletData = this.TblWorldMarketWalletInfos
                                .Where(x => x.UserNo == userNo)
                                .Select(x => new {
                                  x.AddPearlItemLimitedCount,
                                  x.PearlItemLimitedCount,
                                  x.AddWeight
                                })
                                .FirstOrDefault();
    TradeMarketDbNotFoundException.ThrowIfNull(currentWalletData,
                                               nameof(TblWorldMarketWalletInfo),
                                               userNo);
    var ringBuff = TblWorldMarketRingBuffs
                   .Where(x => x.UserNo == userNo)
                   .Select(x => new {
                     x.MaxCount,
                     x.UsingCount
                   })
                   .FirstOrDefault();
    var res = new Result_GetPearlItemTradeCount();
    res.AddPearlItemLimitedCount = currentWalletData.AddPearlItemLimitedCount;
    res.CurrentPearlItemLimitedCount = currentWalletData.PearlItemLimitedCount;
    res.AddWeight = currentWalletData.AddWeight;
    if (ringBuff is not null) {
      res.RingBuffCount = ringBuff.MaxCount;
      if (ringBuff.MaxCount == -1)
        res.RingBuffCount = ringBuff.MaxCount;
      else
        res.RingBuffCount = ringBuff.MaxCount - ringBuff.UsingCount;
    }
    else {
      res.RingBuffCount = 0;
    }

    return res;
  }

  public long GetLastOtpTime_Safe(long userNo) {
    try {
      var otpData = TblWorldMarketWalletInfos
                    .Where(x => x.UserNo == userNo)
                    .Select(x => x.LastConfirmOtpTime)
                    .FirstOrDefault() ?? ConstantContainer.DefaultDateTime;
      return otpData.ConvertUnixTime();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] GetLastOtpTime({UserNo})", userNo);
      return ConstantContainer.DefaultDateTime.ConvertUnixTime();
    }
  }

  ///////////////////////////////////////////////////
  ///////////////////////////////////////////////////
  ///////////////////////////////////////////////////
  ///////////////////////////////////////////////////
  ///////////////////////////////////////////////////
  /// 
  public DbResult<long> GetCountMyWallet(long userNo,
                                         int mainKey,
                                         int subKey,
                                         bool isSealed) {
    try {
      var count = TblWorldMarketWallets
                  .Where(x => x.UserNo == userNo
                              && x.MainKey == mainKey
                              && x.SubKey == subKey
                              && x.IsSealed == isSealed)
                  .Select(x => x.Count)
                  .FirstOrDefault();
      return count;
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreTradeDbManager] GetCountMyWallet({UserNo}/{MainKey}/{SubKey}/{IsSealed})",
                userNo,
                mainKey,
                subKey,
                isSealed);
      return DbResult<long>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultSearchListWorldMarket>> SearchListWorldMarket(List<long> itemKeys, double biddingRatio) {
    try {
      var result = TblWorldMarkets
                   .Where(wm => itemKeys.Contains(wm.MainKey) && wm.IsDisplay)
                   .GroupJoin(
                              TblWorldMarketBiddingSells,
                              wm => new { wm.MainKey, wm.SubKey },
                              ws => new { ws.MainKey, ws.SubKey },
                              (wm,
                               wsGroup) => new {
                                WorldMarket = wm,
                                BiddingSellGroup = wsGroup
                              }
                             )
                   // .SelectMany(
                   //             x => x.BiddingSellGroup.DefaultIfEmpty(),
                   //             (x,
                   //              biddingSell) => new {
                   //               // WorldMarket = x,
                   //               // BiddingSell = biddingSell,
                   //               x.WorldMarket.MainKey,
                   //               x.WorldMarket.SubKey,
                   //               Count = (x.WorldMarket.Count) + (biddingSell.LeftCount),
                   //               BiddingPricePerOne = biddingSell.PricePerOne,
                   //                WorldPricePerOne = x.WorldMarket.PricePerOne,
                   //               TotalTradeCount = x.WorldMarket.TotalTradeCount
                   //             })
                   .SelectMany(
                               x => x.BiddingSellGroup.DefaultIfEmpty(),
                               (x,
                                biddingSell) => new {
                                 x.WorldMarket.MainKey,
                                 x.WorldMarket.SubKey,
                                 Count = x.WorldMarket.Count + (biddingSell != null
                                                                  ? biddingSell.LeftCount
                                                                  : 0),
                                 BiddingPricePerOne = biddingSell != null
                                                        ? biddingSell.PricePerOne
                                                        : default, // or any default value
                                 WorldPricePerOne = x.WorldMarket.PricePerOne,
                                 x.WorldMarket.TotalTradeCount
                               })
                   .Where(a =>
                            a.WorldPricePerOne * (1.0 - biddingRatio) <= a.BiddingPricePerOne &&
                            a.BiddingPricePerOne <= a.WorldPricePerOne * (1.0 + biddingRatio)
                         )
                   .GroupBy(a => a.MainKey)
                   .Select(g => new ResultSearchListWorldMarket {
                     _mainKey = g.Key,
                     _sumCount = g.Sum(a => a.Count),
                     _pricePerOne = g.Min(a => a.WorldPricePerOne),
                     _totalTradeCount = g.Sum(a => a.TotalTradeCount)
                   })
                   .ToList();

      return DbResult<List<ResultSearchListWorldMarket>>.Success(result);
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] SearchListWorldMarket({ItemKeys}) Exception", itemKeys.ToJsonString());
      return DbResult<List<ResultSearchListWorldMarket>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultWorldMarketDetailByCategory>> ListWorldMarketDetailByCategory(int mainCategory,
                                                                                           int subCategory) {
    try {
      var result = TblWorldMarkets
                   .Where(a => a.MainCategory == mainCategory && (a.SubCategory == subCategory || subCategory == 0) && a.IsDisplay)
                   .GroupJoin(
                              TblWorldMarketBiddingSells,
                              a => new { a.MainKey, a.SubKey },
                              b => new { b.MainKey, b.SubKey },
                              (a,
                               bGroup) => new {
                                a.KeyType,
                                a.MainKey,
                                a.SubKey,
                                _pricePerOne = a.PricePerOne,
                                _count = a.Count + bGroup.Sum(b => (int?)b.LeftCount) ?? 0,
                                _totalTradeCount = a.TotalTradeCount,
                                a.MinPrice,
                                a.MaxPrice,
                                _isDisplay = a.IsDisplay
                              }
                             )
                   .GroupBy(a => new { a.KeyType, a.MainKey, a.SubKey, a.MinPrice, a.MaxPrice })
                   .Select(g => new ResultWorldMarketDetailByCategory {
                     _keyType = g.Key.KeyType,
                     _mainKey = g.Key.MainKey,
                     _subKey = g.Key.SubKey,
                     _pricePerOne = g.Min(a => a._pricePerOne),
                     _count = g.Min(a => a._count),
                     _totalTradeCount = g.Min(a => a._totalTradeCount),
                     _minPrice = g.Key.MinPrice,
                     _maxPrice = g.Key.MaxPrice,
                     _isDisplay = g.Min(a => a._isDisplay) == true
                                    ? 1
                                    : 0
                   })
                   .ToList();
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarketDetailByCategory({MainCategory}/{SubCategory}) Exception", mainCategory, subCategory);
      return DbResult<List<ResultWorldMarketDetailByCategory>>.Error(123, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult<List<ResultUserBiddingSell>> ListUserBiddingSell(long userNo) {
    try {
      var query = from sell in TblWorldMarketBiddingSells
                  where sell.UserNo == userNo
                  select new ResultUserBiddingSell {
                    _sellNo = sell.SellNo,
                    _keyType = sell.KeyType,
                    _mainKey = sell.MainKey,
                    _subKey = sell.SubKey,
                    _chooseSubKey = sell.ChooseSubKey,
                    _leftCount = sell.LeftCount,
                    _pricePerOne = sell.PricePerOne,
                    _soldCount = sell.SoldCount,
                    _accumulateMoneyCount = sell.AccumulateMoneyCount,
                    _isSealed = sell.IsSealed,
                    _isRingBuff = sell.IsRingBuff
                  };

      var result = query.ToList();
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListUserBiddingSell Exception {UserNo}", userNo);
      return DbResult<List<ResultUserBiddingSell>>.Error(213, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult<List<ResultWorldMarketWait>> ListWorldMarketWait() {
    try {
      var _15MinDateNow = CultureModule.GetCustomTimeNow().AddMinutes(-ConstantContainer.RegisterQueueWaitMinutes);

      var query = (from x in TblWorldMarketWaitBiddingSells
                   where x.RegisterDate > _15MinDateNow && x.UsedType == 0
                   orderby x.WaitNo
                   select new ResultWorldMarketWait {
                     _keyType = x.KeyType,
                     _mainKey = x.MainKey,
                     _chooseSubKey = x.SubKey,
                     _pricePerOne = x.PricePerOne,
                     _waitEndTime = x.RegisterDate.AddMinutes(ConstantContainer.RegisterQueueWaitMinutes)
                   });
      return query.ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarketWait Exception");
      return DbResult<List<ResultWorldMarketWait>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultWorldMarketHot>> ListWorldMarketHot(double biddingRatio) {
    try {
      var query = (
                    from a in TblWorldMarkets
                    where a.FluctuationType > 0
                    join bidSell in TblWorldMarketBiddingSells on new { a.MainKey, a.SubKey } equals new { bidSell.MainKey, bidSell.SubKey }
                    where a.PricePerOne * (1.0 - biddingRatio) <= bidSell.PricePerOne &&
                          bidSell.PricePerOne <= a.PricePerOne * (1.0 + biddingRatio)
                    group new {
                        a.MainKey,
                        a.SubKey,
                        a.Count,
                        a.TotalTradeCount,
                        a.PricePerOne,
                        a.IsDisplay,
                        a.FluctuationType,
                        a.FluctuationPrice,
                        a.MinPrice,
                        a.MaxPrice,
                        a.LastTradeTime,
                        a.LastTradePrice
                      }
                      by new { a.MainKey, a.SubKey, a.KeyType, a.MinPrice, a.MaxPrice, a.FluctuationType, a.FluctuationPrice, a.LastTradeTime, a.LastTradePrice }
                    into g
                    select new ResultWorldMarketHot {
                      _keyType = 0,
                      _mainKey = g.Key.MainKey,
                      _subKey = g.Key.SubKey,
                      _pricePerOne = g.Min(a => a.PricePerOne),
                      _count = g.Sum(a => a.Count),
                      _totalTradeCount = g.Min(a => a.TotalTradeCount),
                      _fluctuationType = g.Min(a => a.FluctuationType),
                      _fluctuationPrice = g.Min(a => a.FluctuationPrice),
                      _minPrice = g.Min(a => a.MinPrice),
                      _maxPrice = g.Min(a => a.MaxPrice),
                      _lastTradeTime = g.Min(a => a.LastTradeTime),
                      _lastTradePrice = g.Min(a => a.LastTradePrice)
                    });
      return query.ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarketHot Exception");
      return DbResult<List<ResultWorldMarketHot>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult<Domain.Models.EfCore.ResultWorldMarketDetail> WorldMarketDetailOne(int mainKey,
                                                                                     int subKey) {
    try {
      var result = (from item in TblWorldMarkets
                    where item.MainKey == mainKey && item.SubKey == subKey
                    select new Domain.Models.EfCore.ResultWorldMarketDetail {
                      MinPrice = item.MinPrice,
                      MaxPrice = item.MaxPrice,
                      TotalTradeCount = item.TotalTradeCount,
                      LastTradePrice = item.LastTradePrice,
                      LastTradeTime = CommonModule.ConvertDateTimeToUnixTimeStamp(item.LastTradeTime),
                      PricePerOne = item.PricePerOne,
                      Count = item.Count,
                    })
        .FirstOrDefault();
      if (result is null) {
        return DbResult<Domain.Models.EfCore.ResultWorldMarketDetail>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemNotExist.GetResourceValue());
      }

      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] WorldMarketDetailOne({MainKey}/{SubKey}) Exception", mainKey, subKey);
      return DbResult<Domain.Models.EfCore.ResultWorldMarketDetail>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultWorldMarket>> ListWorldMarket(
    int mainCategory,
    int subCategory,
    double minPriceRatio,
    double maxPriceRatio) {
    try {
      //For category list only 0 sub group / ench key matters rest no need to pull

      var worldMarketItems = TblWorldMarkets
                             .Where(x => x.MainCategory == mainCategory && x.SubCategory == subCategory && x.SubKey == 0)
                             .GroupBy(x => x.MainKey)
                             .Select(x => new {
                               MainKey = x.Key,
                               PricePerOne = x.Min(y => y.PricePerOne),
                               TotalTradeCount = x.Min(y => y.TotalTradeCount),
                             })
                             .ToList();
      var itemIdList = worldMarketItems.Select(x => x.MainKey).ToList();
      var sells = TblWorldMarketBiddingSells
                  .Where(x => itemIdList.Contains(x.MainKey) && x.SubKey == 0 && x.LeftCount > 0)
                  .Select(x => new {
                    MainKey = x.MainKey,
                    ListPrice = x.PricePerOne,
                    LeftCount = x.LeftCount,
                  })
                  .ToList();
      // var result = new List<ResultWorldMarket>();


      var list = worldMarketItems.Select(item => {
        var minPrice = item.PricePerOne * minPriceRatio;
        var maxPrice = item.PricePerOne * maxPriceRatio;
        var validSellList = sells
                            .Where(x => x.MainKey == item.MainKey && minPrice <= x.ListPrice && x.ListPrice <= maxPrice)
                            .ToList();
        var sumListCount = validSellList.Sum(x => x.LeftCount);
        // var minSellPrice = validSellList.Count > 0
        //                      ? validSellList.Min(x => x.ListPrice)
        //                      : item.PricePerOne;
        return new ResultWorldMarket {
          _mainKey = item.MainKey,
          _sumCount = sumListCount,
          _totalSumCount = item.TotalTradeCount,
          _minPrice = item.PricePerOne,
          _isDisplay = 1
        };
      });
      return list.ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarket({MainCategory}|{SubCategory}) Exception", mainCategory, subCategory);
      return DbResult<List<ResultWorldMarket>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultWorldMarketDetail>> ListWorldMarketDetail(long mainKey,
                                                                       bool isUsedTotalTradeCount,
                                                                       double minPriceRatio,
                                                                       double maxPriceRatio) {
    try {
      var marketItems = TblWorldMarkets
                        .Where(x => x.MainKey == mainKey)
                        .ToList();

      var sellList = TblWorldMarketBiddingSells
                     .Where(x => x.MainKey == mainKey && x.LeftCount > 0)
                     .ToList();
      var result = marketItems.Select(item => {
        var minPrice = item.PricePerOne * minPriceRatio;
        var maxPrice = item.PricePerOne * maxPriceRatio;
        var validSellList = sellList
                            .Where(x => x.MainKey == item.MainKey && x.SubKey == item.SubKey && minPrice <= x.PricePerOne && x.PricePerOne <= maxPrice)
                            .ToList();
        var sumListCount = validSellList.Sum(x => x.LeftCount);
        var basePrice = item.PricePerOne;

        //WHETHER TO USE ALL SUB LEVEL TOTAL COUNT SUM OR JUST CURRENT SUB LEVEL
        var totalTradeCount = isUsedTotalTradeCount
                                ? marketItems.Sum(x => x.TotalTradeCount)
                                : item.TotalTradeCount;

        return new ResultWorldMarketDetail {
          _keyType = 0,
          _mainKey = item.MainKey,
          _subKey = item.SubKey,
          _count = sumListCount,
          _totalTradeCount = totalTradeCount,
          _pricePerOne = item.PricePerOne,
          _minPrice = item.MinPrice,
          _maxPrice = item.MaxPrice,
          _isDisplay = 1
        };
      });
      return result.ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarketDetail({MainKey}/{IsUsedTotalTradeCount}) Exception", mainKey, isUsedTotalTradeCount);
      return DbResult<List<ResultWorldMarketDetail>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public bool ClearNoticeItemListTrade() {
    try {
      const string sql = "TRUNCATE TABLE [PaGamePrivate].[TblWorldMarketNoticeItem]";

      Database.ExecuteSqlRaw(sql);
      return true;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ClearNoticeItemListTrade failed");
      return false;
    }
  }

  public DbResult UpdateItemInfoBulk(List<UpdateItemInfoData> updateItemInfoDataList) {
    try {
      var worldMarketItemList = TblWorldMarkets
        .ToList();
      var addList = new List<TblWorldMarket>();
      var updateList = new List<TblWorldMarket>();
      var deleteList = new List<TblWorldMarket>();
      foreach (var item in updateItemInfoDataList) {
        var marketItem = worldMarketItemList
          .FirstOrDefault(x => x.KeyType == item.KeyType && x.MainKey == item.MainKey && x.SubKey == item.SubKey);

        var resultPrice = marketItem?.PricePerOne ?? 0L;

        var isLowerThanMin = item.RealMinPrice > resultPrice;
        var isHigherThanMax = item.RealMaxPrice < resultPrice;
        if (isLowerThanMin) {
          resultPrice = item.RealMinPrice;
        }
        else if (isHigherThanMax) {
          resultPrice = item.RealMaxPrice;
        }

        var resultBasePrice = item.BasePrice;

        if (marketItem is null) {
          var hasGroup = item.MarketPriceGroupKey > 0;
          if (hasGroup) {
            var groupPricePerOne = worldMarketItemList
                                   .Where(item => item.PriceGroupKey == item.PriceGroupKey)
                                   .GroupBy(item => item.PricePerOne)
                                   .Select(group => group.Key)
                                   .FirstOrDefault(0);
            if (groupPricePerOne != 0)
              resultBasePrice = groupPricePerOne;
          }

          marketItem = new TblWorldMarket() {
            KeyType = item.KeyType,
            MainKey = item.MainKey,
            SubKey = item.SubKey,
            MainCategory = item.MainGroupNo,
            SubCategory = item.SubGroupNo,
            PricePerOne = resultBasePrice,
            MinPrice = item.MinPrice,
            MaxPrice = item.MaxPrice,
            RealMinPrice = item.RealMinPrice,
            RealMaxPrice = item.RealMaxPrice,
            IsDisplay = true,
            LastTradeTime = DateTime.Now,
            LastTradePrice = 0,
            TotalTradeCount = 0,
            PriceGroupKey = item.MarketPriceGroupKey,
            MaxTradeCount = 0,
            Count = 0,
          };
          TblWorldMarkets.Add(marketItem);
          addList.Add(marketItem);
        }
        else {
          marketItem.MainCategory = item.MainGroupNo;
          marketItem.SubCategory = item.SubGroupNo;
          marketItem.MaxTradeCount = 0;
          marketItem.Count = 0;
          marketItem.PricePerOne = resultPrice;
          marketItem.MinPrice = item.MinPrice;
          marketItem.MaxPrice = item.MaxPrice;
          marketItem.RealMinPrice = item.RealMinPrice;
          marketItem.RealMaxPrice = item.RealMaxPrice;
          marketItem.IsDisplay = true;
          marketItem.PriceGroupKey = item.MarketPriceGroupKey;
          updateList.Add(marketItem);
        }
      }

      foreach (var worldMarket in worldMarketItemList) {
        var updateItem = updateItemInfoDataList
          .FirstOrDefault(x => x.KeyType == worldMarket.KeyType && x.MainKey == worldMarket.MainKey && x.SubKey == worldMarket.SubKey);
        if (updateItem is null) {
          deleteList.Add(worldMarket);
        }
      }


      using var ctxGame = new GameDbContext();
      using var tranTrade = Database.BeginTransaction();
      using var tranGame = ctxGame.Database.BeginTransaction();
      if (deleteList.Count > 0) {
        //TODO Refund deleted items to mail
        // deleteList.ForEach(x => RemoveItemFromMarketAndSendMail(ctxTrade, ctxGame, x.MainKey));
        // TblWorldMarkets.RemoveRange(deleteList);
      }

      TblWorldMarkets.UpdateRange(updateList);
      TblWorldMarkets.AddRange(addList);
      var expectedSaveCount = updateList.Count + addList.Count; //deleteList.Count + 
      var affected = SaveChanges();
      if (affected != expectedSaveCount) return DbResult.DbException(-1);
      tranTrade.Commit();
      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] UpdateItemInfoBulk Exception");
      return DbResult.DbException(-2);
    }
  }

  // public DbResult PushItemToMyWallet(long userNo,
  //                                    int itemMainKey,
  //                                    int itemSubKey,
  //                                    bool isSealed,
  //                                    long count) {
  //   try {
  //     
  //     var currentWalletItem = TblWorldMarketWallets.FirstOrDefault(x => x.UserNo == userNo
  //                                                                                && x.MainKey == itemMainKey
  //                                                                                && x.SubKey == itemSubKey
  //                                                                                && x.IsSealed == isSealed);
  //     if (currentWalletItem is null) {
  //       var newWalletItem = new TblWorldMarketWallet {
  //         KeyType = (int)KeyType.eItem,
  //         MainKey = itemMainKey,
  //         SubKey = itemSubKey,
  //         Count = count,
  //         IsSealed = isSealed,
  //         UserNo = userNo,
  //       };
  //       TblWorldMarketWallets.Add(newWalletItem);
  //     }
  //     else {
  //       currentWalletItem.Count += count;
  //       TblWorldMarketWallets.Update(currentWalletItem);
  //     }
  //
  //     var saveResult = SaveChanges();
  //     if (saveResult <= 0) return DbResult.Error(-2, GameErrorType.eErrNoWorldMarketUpdateWalletFaill.ToString());
  //     return DbResult.Success();
  //   }
  //   catch (Exception ex) {
  //     Log.Error(ex,
  //               "[EfCoreTradeDbManager] PushItemToMyWallet({UserNo}/{ItemMainKey}/{ItemSubKey}/{IsSealed}/{Count}) Exception",
  //               userNo,
  //               itemMainKey,
  //               itemSubKey,
  //               isSealed,
  //               count);
  //     return DbResult.Error(-3, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
  //   }
  // }


  public DbResult<List<ResultWorldMarketWaitNoticeList>> WorldMarketMyWaitNoticeList(
    long userNo) {
    try {
      using var tranTrade = Database.BeginTransaction();
      var query = from notice in TblWorldMarketWaitBiddingSellNotices
                  join wait in TblWorldMarketWaitBiddingSells
                    on notice.WaitNo equals wait.WaitNo
                  where notice.UserNo == userNo
                        && notice.Status == 0
                  select new {
                    NoticeDbRecord = notice,
                    DbResult = new ResultWorldMarketWaitNoticeList {
                      _waitNo = wait.WaitNo,
                      _keyType = wait.KeyType,
                      _mainKey = wait.MainKey,
                      _chooseSubKey = wait.ChooseSubKey,
                      _leftCount = wait.LeftCount,
                      _pricePerOne = wait.PricePerOne,
                      _resultMoneyCount = notice.ResultMoneyCount,
                      _usedType = notice.UsedType
                    },
                  };
      var queryResult = query.ToList();

      var notices = queryResult.Select(x => x.NoticeDbRecord).ToList();
      notices.ForEach(x => x.Status = 1);
      TblWorldMarketWaitBiddingSellNotices.UpdateRange(notices);
      var affected = SaveChanges();
      if (affected != notices.Count)
        return DbResult<List<ResultWorldMarketWaitNoticeList>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      tranTrade.Commit();
      return queryResult.Select(x => x.DbResult).ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] WorldMarketMyWaitNoticeList({UserNo}) Exception", userNo);
      return DbResult<List<ResultWorldMarketWaitNoticeList>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<ResultItemPriceData> GetItemPriceData(int mainKey,
                                                        int subKey,
                                                        int basePrice) {
    //ItemInfoManager.This.GetInfo(x.MainKey, x.SubKey)._basePrice
    try {
      var priceData = TblWorldMarkets
                      .Where(x => x.MainKey == mainKey && x.SubKey == subKey)
                      .Select(x => new ResultItemPriceData(x.PricePerOne, basePrice, x.RealMinPrice, x.RealMaxPrice))
                      .FirstOrDefault();
      if (priceData is null) {
        return DbResult<ResultItemPriceData>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      }

      return priceData;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] GetMaterialPrice({MainKey}) Exception", mainKey);
      return DbResult<ResultItemPriceData>.Error(-2, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult<long> GetItemPrice(int mainKey,
                                     int subKey) {
    try {
      if (mainKey == 0)
        return 0;

      var price = TblWorldMarkets
                  .Where(x => x.MainKey == mainKey && x.SubKey == subKey)
                  .Select(x => x.PricePerOne)
                  .DefaultIfEmpty()
                  .FirstOrDefault();
      if (price == 0) {
        return DbResult<long>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      }

      return price;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] GetMaterialPrice({MainKey}) Exception", mainKey);
      return DbResult<long>.Error(-2, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult<List<ResultListBiddingInfo>> ListBiddingInfo(
    int? keyType,
    int? mainKey,
    int? subKey,
    int enchantMaterialKey,
    double biddingRate) {
    try {
      // var materialPriceResult = GetEnchantMaterialPrice(enchantMaterialKey);
      // if (!materialPriceResult.Status) {
      //   return DbResult<List<ResultListBiddingInfo>>.Error(materialPriceResult.Rv * 100, materialPriceResult.SymNo);
      // }

      var materialPrice =
        enchantMaterialKey == 0
          ? 0
          : TblWorldMarkets.Where(x => x.MainKey == enchantMaterialKey && x.SubKey == 0)
                           .DefaultIfEmpty()
                           .Select(x => x.PricePerOne)
                           .FirstOrDefault();

      var pricePerOneStock = TblWorldMarkets
                             .Where(x => x.MainKey == mainKey && x.SubKey == subKey)
                             .DefaultIfEmpty()
                             .Select(x => x.PricePerOne)
                             .FirstOrDefault();

      if (pricePerOneStock == 0) {
        return DbResult<List<ResultListBiddingInfo>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      }

      var highBiddingPrice = pricePerOneStock * (1.0 + biddingRate);
      var lowBiddingPrice = pricePerOneStock * (1.0 - biddingRate);
      var buyQuery = from buy in TblWorldMarketBiddingBuys
                     where buy.KeyType == keyType
                           && buy.MainKey == mainKey
                           && buy.SubKey == subKey
                           && buy.LeftCount > 0
                           && buy.PricePerOne <= highBiddingPrice
                           && lowBiddingPrice <= buy.PricePerOne
                     select new ResultListBiddingInfo {
                       _buyCount = buy.LeftCount,
                       _sellCount = 0,
                       _pricePerOne = buy.PricePerOne
                     };

      var sellQuery = from sell in TblWorldMarketBiddingSells
                      where sell.KeyType == keyType
                            && sell.MainKey == mainKey
                            && sell.SubKey == subKey
                            && sell.LeftCount > 0
                            && lowBiddingPrice <= sell.PricePerOne
                            && sell.PricePerOne <= highBiddingPrice
                      select new ResultListBiddingInfo {
                        _buyCount = 0,
                        _sellCount = sell.LeftCount,
                        _pricePerOne = sell.PricePerOne
                      };

      var marketQuery = from market in TblWorldMarkets
                        where market.KeyType == keyType
                              && market.MainKey == mainKey
                              && market.SubKey == subKey
                        select new ResultListBiddingInfo {
                          _buyCount = 0,
                          _sellCount = market.Count,
                          _pricePerOne = market.PricePerOne
                        };

      var unionQuery = buyQuery.Union(sellQuery).Union(marketQuery);

      var result = unionQuery.ToList();
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreTradeDbManager] ListBiddingInfo({KeyType}/{MainKey}/{SubKey}/{EnchantMaterialKey}/{BiddingRate}) Exception",
                keyType,
                mainKey,
                subKey,
                enchantMaterialKey,
                biddingRate);
      return DbResult<List<ResultListBiddingInfo>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultGetMarketPriceInfo>> GetItemPriceHistoryInfoForGraph(
    int keyType,
    int mainKey,
    int subKey) {
    try {
      var date = CultureModule.GetCustomTimeNow().AddDays(-89);
      var unix89DayBefore = CommonModule.ConvertUnixTime(date);
      var query = (from info in TblWorldMarketPriceInfos
                   where info.MainKey == mainKey
                         && info.SubKey == subKey
                         && info.RegistTimeStamp > unix89DayBefore
                   orderby info.RegistTimeStamp descending
                   group info by info.RegistTimeStamp / (24 * 3600)
                   into g
                   select new ResultGetMarketPriceInfo {
                     _price = Convert.ToInt64(g.Average(x => x.Price)),
                     _dateTime = CommonModule.ConvertUnixTimeStampToDateTime(Convert.ToInt64(g.Average(y => y.RegistTimeStamp)))
                   }).ToList();
      var resultList = query.ToList();
      return resultList;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] GetItemPriceHistoryInfoForGraph({KeyType}/{MainKey}/{SubKey}) Exception", keyType, mainKey, subKey);
      return DbResult<List<ResultGetMarketPriceInfo>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

//   private void RemoveItemFromMarketAndSendMailBulk_NotSave(
//     GameDbContext ctxGame,
//     List<long> itemKeyList,
//     string mailTitle = "MARKET_ITEM_RESTORE_HEADER",
//     string mailContent = "MARKET_ITEM_RESTORE_CONTENT") {
//     var containingWalletItems = TblWorldMarketWallets
//                                 .Where(x => itemKeyList.Contains(x.MainKey) && x.Count > 0)
//                                 .ToList();
//
//     var containingSellingItems = TblWorldMarketBiddingSells
//                                  .Where(x => itemKeyList.Contains(x.MainKey) && x.LeftCount > 0)
//                                  .ToList();
//
//     var containingBuyingItems = TblWorldMarketBiddingBuys
//                                 .Where(x => itemKeyList.Contains(x.MainKey))
//                                 .ToList();
//
//     var containingRegisterQueueItems = TblWorldMarketWaitBiddingSells
//                                        .Where(x => itemKeyList.Contains(x.MainKey) && x.UsedType == 0 && x.LeftCount > 0)
//                                        .ToList();
//
//
//     var list = new List<ResultRemoveItemFromMarketAndSendMail>();
// //TODO CHECK SUB KEY FOR EQUIP ITEMS WEAPONS AND ARMORS
//     foreach (var removeItemKey in itemKeyList) {
//       var wallet = containingWalletItems.Where(x => x.MainKey == removeItemKey).ToList();
//       var selling = containingSellingItems.Where(x => x.MainKey == removeItemKey).ToList();
//       var buying = containingBuyingItems.Where(x => x.MainKey == removeItemKey).ToList();
//       var activeRegisterQueue = containingRegisterQueueItems.Where(x => x.MainKey == removeItemKey).ToList();
//       foreach (var walletItem in wallet) {
//         var userNo = walletItem.UserNo;
//         var walletItemKey = walletItem.MainKey;
//         var walletItemEnchant = walletItem.SubKey;
//         var count = walletItem.Count;
//         list.Add(new ResultRemoveItemFromMarketAndSendMail(userNo, walletItemKey, walletItemEnchant, count));
//       }
//
//       TblWorldMarketWallets.RemoveRange(wallet);
//
//       foreach (var sellingItem in selling) {
//         var userNo = sellingItem.UserNo;
//         var anyMoneyLeft = sellingItem.AccumulateMoneyCount > 0;
//         if (anyMoneyLeft) {
//           var accumulateMoney = sellingItem.AccumulateMoneyCount;
//           //TODO CHECK IF MONEY KEPT AS FULL OR PER ONE
//           //CURRENTLY CONSIDERING AS FULL
//           const float silverRatio = 0.6f;
//           var money = Convert.ToInt64(accumulateMoney * silverRatio);
//           list.Add(new ResultRemoveItemFromMarketAndSendMail(userNo, 1, 0, money));
//         }
//
//         var leftAny = sellingItem.LeftCount > 0;
//         if (leftAny) {
//           var sellItemKey = sellingItem.MainKey;
//           var sellItemEnchant = sellingItem.SubKey;
//           var count = sellingItem.LeftCount;
//           list.Add(new ResultRemoveItemFromMarketAndSendMail(userNo, sellItemKey, sellItemEnchant, count));
//         }
//       }
//
//       TblWorldMarketBiddingSells.RemoveRange(selling);
//
//       foreach (var buyingItem in buying) {
//         var userNo = buyingItem.UserNo;
//         var boughtAny = buyingItem.BoughtCount > 0;
//         if (boughtAny) {
//           var boughtCount = buyingItem.BoughtCount;
//           var preOrderItemKey = buyingItem.MainKey;
//           var preOrderEnchant = buyingItem.ChooseSubKey;
//           list.Add(new ResultRemoveItemFromMarketAndSendMail(userNo, preOrderItemKey, preOrderEnchant, boughtCount));
//         }
//
//         var anyMoneyLeft = buyingItem.RegisterMoneyCount > 0;
//         if (anyMoneyLeft) {
//           var moneyCount = buyingItem.RegisterMoneyCount;
//           list.Add(new ResultRemoveItemFromMarketAndSendMail(userNo, 1, 0, moneyCount));
//         }
//       }
//
//       TblWorldMarketBiddingBuys.RemoveRange(buying);
//
//       foreach (var registerQueueItem in activeRegisterQueue) {
//         var userNo = registerQueueItem.UserNo;
//         var queueItemKey = registerQueueItem.MainKey;
//         var queueEnchant = registerQueueItem.SubKey;
//         var count = registerQueueItem.LeftCount;
//         list.Add(new ResultRemoveItemFromMarketAndSendMail(userNo, queueItemKey, queueEnchant, count));
//       }
//
//       TblWorldMarketWaitBiddingSells.RemoveRange(activeRegisterQueue);
//
//       var grouped = list.GroupBy(x => new {
//         x.UserNo,
//         x.ItemKey,
//         x.EnchantLevel,
//       });
//
//       foreach (var group in grouped) {
//         var totalCount = group.Sum(x => x.Count);
//         var key = group.Key.ItemKey;
//         var ench = group.Key.EnchantLevel;
//         var userNo = group.Key.UserNo;
//         var mail = new TblMail(userNo,
//                                key,
//                                totalCount,
//                                (byte)ench,
//                                mailTitle,
//                                mailContent);
//         ctxGame.TblMails.Add(mail);
//       }
//     }
//   }

  public DbResult<List<ResultUserBiddingBuy>> ListUserBiddingBuy(long userNo) {
    try {
      var result = (from biddingBuy in TblWorldMarketBiddingBuys
                    join worldMarket in TblWorldMarkets
                      on new {
                        biddingBuy.MainKey,
                        biddingBuy.SubKey,
                      } equals new {
                        worldMarket.MainKey,
                        worldMarket.SubKey,
                      }
                    where biddingBuy.UserNo == userNo
                    select new ResultUserBiddingBuy {
                      _buyNo = biddingBuy.BuyNo,
                      _keyType = biddingBuy.KeyType,
                      _mainKey = biddingBuy.MainKey,
                      _subKey = biddingBuy.SubKey,
                      _chooseSubKey = biddingBuy.ChooseSubKey,
                      _leftCount = biddingBuy.LeftCount,
                      _boughtCount = biddingBuy.BoughtCount,
                      _registerMoneyCount = biddingBuy.RegisterMoneyCount,
                      _pricePerOne = biddingBuy.PricePerOne,
                      _basePrice = worldMarket.PricePerOne,
                      _minPrice = worldMarket.MinPrice,
                      _addEnchantPrice = biddingBuy.AddEnchantPrice,
                    }).ToList();
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListUserBiddingBuy Exception {UserNo}", userNo);
      return DbResult<List<ResultUserBiddingBuy>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult SetUpdateTickCount(int mainGroupNo,
                                     int updateTickCount) {
    try {
      var mainGroup = TblWorldMarketTickCounts.FirstOrDefault(x => x.MainGroupNo == mainGroupNo);
      if (mainGroup is null) {
        return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
        // //
        // mainGroup = new TblWorldMarketTickCount {
        //   MainGroupNo = mainGroupNo,
        //   UpdateTickCount = updateTickCount,
        // };
        // TblWorldMarketTickCounts.Add(mainGroup);
      }
      else {
        mainGroup.UpdateTickCount = updateTickCount;
        TblWorldMarketTickCounts.Update(mainGroup);
      }

      var affected = SaveChanges();
      if (affected <= 0) return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] SetUpdateTickCount Exception {MainGroupNo}/{UpdateTickCount}", mainGroupNo, updateTickCount);
      return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultWorldMarketCurrentPrice>> ListWorldMarketCurrentPrice(int mainCategory,
                                                                                   int subCategory) {
    try {
      var query = from item in TblWorldMarkets
                  where item.MainCategory == mainCategory && item.SubCategory == subCategory
                  select new ResultWorldMarketCurrentPrice {
                    _mainKey = item.MainKey,
                    _subKey = item.SubKey,
                    _pricePerOne = item.PricePerOne,
                  };
      return query.ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarketCurrentPrice Exception {MainCategory}/{SubCategory}", mainCategory, subCategory);
      return DbResult<List<ResultWorldMarketCurrentPrice>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultBiddingPrice>> ListBiddingPrice(int mainKey,
                                                             int subKey,
                                                             int maxGroupKey,
                                                             long pricePerOne,
                                                             double minPriceRatio,
                                                             double maxPriceRatio) {
    try {
      var minPrice = pricePerOne * minPriceRatio;
      var maxPrice = pricePerOne * maxPriceRatio;
      var sellQuery = from sell in TblWorldMarketBiddingSells
                      where sell.MainKey == mainKey
                            && sell.SubKey == subKey
                            && sell.SubKey < maxGroupKey
                            && sell.PricePerOne <= maxPrice
                            && minPrice <= sell.PricePerOne
                            && sell.LeftCount > 0
                      select new ResultBiddingPrice {
                        _pricePerOne = sell.PricePerOne,
                        _leftCount = sell.LeftCount,
                      };
      var buyQuery = from buy in TblWorldMarketBiddingBuys
                     where buy.MainKey == mainKey
                           && buy.SubKey == subKey
                           && buy.SubKey < maxGroupKey
                           && buy.PricePerOne <= maxPrice
                           && minPrice <= buy.PricePerOne
                           && buy.LeftCount > 0
                     select new ResultBiddingPrice {
                       _pricePerOne = buy.PricePerOne,
                       _leftCount = buy.LeftCount,
                     };
      var result = sellQuery.Union(buyQuery).ToList();
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreTradeDbManager] ListBiddingPrice Exception {MainKey}/{SubKey}/{MaxGroupKey}/{PricePerOne}",
                mainKey,
                subKey,
                maxGroupKey,
                pricePerOne);
      return DbResult<List<ResultBiddingPrice>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  private bool IsBlocked_Unsafe(long userNo) {
    var currentTime = CultureModule.GetCustomTimeNow();
    var exists = TblBlockUsers.Any(x => x.UserNo == userNo && (!x.DueDate.HasValue || x.DueDate > currentTime));
    return exists;
  }


  public DbResult CheckAndUpdateBlackUser(long userNo) {
    try {
      var isBlocked = IsBlocked_Unsafe(userNo);
      if (isBlocked) {
        return DbResult.Error(-1, GameErrorType.eErrNoBlockUser);
      }


      // using var tran = Database.BeginTransaction();
      var currentTime = CultureModule.GetCustomTimeNow();
      var walletInfo = TblWorldMarketWalletInfos
                       .Where(x => x.UserNo == userNo)
                       .FirstOrDefault();
      if (walletInfo is null) {
        return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      }

      var dateDiffSeconds = (walletInfo.BlackUserCheckTime - currentTime).TotalSeconds;
      walletInfo.BlackUserCheckTime = currentTime;

      if (dateDiffSeconds < 1) {
        walletInfo.BlackUserCheckCount++;
      }

      TblWorldMarketWalletInfos.Update(walletInfo);

      var affected = SaveChanges();
      if (affected <= 0) return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] CheckAndUpdateBlackUser Exception {UserNo}", userNo);
      return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  private DbResult PushWeightToMyWallet(
    long userNo,
    long weight,
    long maxWeight,
    bool isNecessaryUpdate) {
    var currentTime = CultureModule.GetCustomTimeNow();
    try {
      var isMaxWeightHasValue = maxWeight > 0;
      var isAnyAction = isMaxWeightHasValue && isNecessaryUpdate;
      if (!isAnyAction)
        return DbResult.Success();
      var walletInfo = TblWorldMarketWalletInfos
                       .Where(x => x.UserNo == userNo)
                       .FirstOrDefault();
      if (walletInfo is null) {
        return DbResult.Error(-1, GameErrorType.eErrNoDbInternalError);
      }

      if (isMaxWeightHasValue) {
        var addWeightBuffExpiration = walletInfo.AddWeightBuffExpiration;
        var addWeightByBuff = walletInfo.AddWeightByBuff;
        var addWeight = walletInfo.AddWeight;
        var walletWeight = walletInfo.Weight;
        if (addWeightByBuff > 0 && addWeightBuffExpiration < currentTime) {
          addWeightByBuff = 0;
        }

        var isWeightExceeded = (maxWeight + addWeight + addWeightByBuff) < walletWeight + weight;
        if (isWeightExceeded) {
          return DbResult.Error(-2, GameErrorType.eErrNoWorldMarketIsNotMaxWeight);
        }
      }

      if (isNecessaryUpdate) {
        walletInfo.Weight += weight;
        TblWorldMarketWalletInfos.Update(walletInfo);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreTradeDbManager] PushWeightToMyWallet({UserNo}/{Weight}/{MaxWeight}/{IsNecessaryUpdate}) Exception",
                userNo,
                weight,
                maxWeight,
                isNecessaryUpdate);
      return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  private DbResult<ResultBeforeAfterCount> PushItemToMyWallet(long userNo,
                                                              int mainKey,
                                                              int subKey,
                                                              bool isSealed,
                                                              long count) {
    try {
      var beforeCount = 0L;
      var walletItem = TblWorldMarketWallets
                       .Where(x => x.UserNo == userNo
                                   && x.MainKey == mainKey
                                   && x.SubKey == subKey
                                   && x.IsSealed == isSealed)
                       .FirstOrDefault();
      if (walletItem is null) {
        beforeCount = 0;
        walletItem = new TblWorldMarketWallet {
          KeyType = (int)KeyType.eItem,
          MainKey = mainKey,
          SubKey = subKey,
          Count = count,
          IsSealed = isSealed,
          UserNo = userNo,
        };
        TblWorldMarketWallets.Add(walletItem);
      }
      else {
        beforeCount = walletItem.Count;
        walletItem.Count += count;
        TblWorldMarketWallets.Update(walletItem);
      }

      var afterCount = beforeCount + count;
      return new ResultBeforeAfterCount() {
        BeforeCount = beforeCount,
        AfterCount = afterCount
      };
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreTradeDbManager] PushItemToMyWallet({UserNo}/{ItemMainKey}/{ItemSubKey}/{IsSealed}/{Count}) Exception",
                userNo,
                mainKey,
                subKey,
                isSealed,
                count);
      return DbResult<ResultBeforeAfterCount>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<ResultBeforeAfterCount> UpdateWaitFail(long waitNo,
                                                         long pushWeight) {
    using var tran = Database.BeginTransaction();
    try {
      var waitBiddingSellItem = TblWorldMarketWaitBiddingSells
                                .Where(x => x.WaitNo == waitNo && x.LeftCount == 1 && x.UsedType != 3)
                                .FirstOrDefault();


      if (waitBiddingSellItem is null) {
        return DbResult<ResultBeforeAfterCount>.Error(-1, GameErrorType.eErrNoDbInternalError);
      }

      waitBiddingSellItem.UsedType = 3;
      waitBiddingSellItem.LeftCount = 0;

      var userNo = waitBiddingSellItem.UserNo;
      var mainKey = waitBiddingSellItem.MainKey;
      var chooseKey = waitBiddingSellItem.ChooseSubKey;
      var isSealed = waitBiddingSellItem.IsSealed;
      var isRingBuff = waitBiddingSellItem.IsRingBuff;

      var resPushWeight = PushWeightToMyWallet(userNo, pushWeight, 0, true);
      if (!resPushWeight.Status) {
        return DbResult<ResultBeforeAfterCount>.Error(-2, resPushWeight.SymNo);
      }


      var resPushItem = PushItemToMyWallet(userNo,
                                           mainKey,
                                           chooseKey,
                                           isSealed,
                                           1);
      if (!resPushItem.Status) {
        return DbResult<ResultBeforeAfterCount>.Error(-3, resPushItem.SymNo);
      }

      if (isRingBuff) {
        var ringBuffData = TblWorldMarketRingBuffs.FirstOrDefault(x => x.UserNo == userNo && x.MaxCount == -1);
        if (ringBuffData is null) {
          return DbResult<ResultBeforeAfterCount>.Error(-4, GameErrorType.eErrNoDbInternalError);
        }

        if (ringBuffData.UsingCount > 0) {
          ringBuffData.UsingCount--;
        }
      }

      var notice = new TblWorldMarketWaitBiddingSellNotice {
        UserNo = userNo,
        WaitNo = waitNo,
        Status = 0,
        ResultMoneyCount = 0,
        UsedType = 3,
      };

      TblWorldMarketWaitBiddingSellNotices.Add(notice);

      var affected = SaveChanges();

      if (affected <= 0)
        return DbResult<ResultBeforeAfterCount>.Error(-4, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());

      tran.Commit();
      return new ResultBeforeAfterCount() {
        BeforeCount = resPushItem.Data.BeforeCount,
        AfterCount = resPushItem.Data.AfterCount
      };
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] UpdateWaitFail Exception {WaitNo}", waitNo);
      return DbResult<ResultBeforeAfterCount>.Error(-5, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public List<ResultNoticeItem> ListNoticeItem(long checkDateTimeStamp) {
    try {
      var query = TblWorldMarketNoticeItems
                  .Where(x => x.RegistTimeStamp > checkDateTimeStamp)
                  .Select(x => new ResultNoticeItem {
                    _keyType = x.KeyType,
                    _mainKey = x.MainKey,
                    _subKey = x.SubKey,
                    _registTimeStamp = x.RegistTimeStamp,
                    _price = x.Price,
                    _changedValue = x.ChangedValue,
                    _noticeType = x.NoticeType,
                  })
                  .Take(100)
                  .OrderBy(x => x._registTimeStamp);
      var result = query.ToList();
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListNoticeItem Exception {CheckDateTimeStamp}", checkDateTimeStamp);
      return new List<ResultNoticeItem>();
      // return DbResult<List<ResultNoticeItem>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult<List<ResultTickCount>> ListTickCount() {
    try {
      var query = TblWorldMarketTickCounts
        .Select(x => new ResultTickCount {
          _mainGroupNo = x.MainGroupNo,
          _updateTickCount = x.UpdateTickCount,
          _allowIndex = x.AllowIndex,
          _serverIp = x.ServerIp,
        });
      return query.ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] ListTickCount Exception");
      return DbResult<List<ResultTickCount>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult UpdateWorldMarketPassCount(int mainKey,
                                             int subKey,
                                             double minPriceRatio,
                                             double maxPriceRatio) {
    try {
      var marketItem = TblWorldMarkets
                       .Where(x => x.MainKey == mainKey && x.SubKey == subKey)
                       .FirstOrDefault();
      if (marketItem is null) {
        return DbResult.DbException(-1);
      }

      var pricePerOne = marketItem.PricePerOne;
      if (pricePerOne == 0) {
        return DbResult.Error(-2, GameErrorType.eErrNoDbInternalError);
      }

      var minBiddingPrice = pricePerOne * minPriceRatio;
      var maxBiddingPrice = pricePerOne * maxPriceRatio;

      var biddingBuyCount = TblWorldMarketBiddingBuys
        .Count(x => x.MainKey == mainKey
                    && x.SubKey == subKey
                    && minBiddingPrice <= x.PricePerOne
                    && x.PricePerOne <= maxBiddingPrice);

      var biddingSellCount = TblWorldMarketBiddingSells
        .Count(x => x.MainKey == mainKey
                    && x.SubKey == subKey
                    && minBiddingPrice <= x.PricePerOne
                    && x.PricePerOne <= maxBiddingPrice);
      long biddingCount = biddingBuyCount + biddingSellCount;

      marketItem.AccumulateTickCount += biddingCount;
      marketItem.AccumulateBiddingCount = biddingCount;

      TblWorldMarkets.Update(marketItem);
      var affected = SaveChanges();

      if (affected <= 0) return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreTradeDbManager] uspUpdateWorldMarketPassCount({MainKey}/{SubKey}) Exception",
                mainKey,
                subKey);
      return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public long GetItemPrice_Unsafe(int mainKey,
                                  int subKey) {
    return new TradeDbContext().TblWorldMarkets
                               .Where(x => x.MainKey == mainKey && x.SubKey == subKey)
                               .Select(x => x.PricePerOne)
                               .DefaultIfEmpty()
                               .FirstOrDefault();
  }


  public DbResult InitMarketOption(int ringRate) {
    try {
      var option = TblWorldMarketOptions
        .FirstOrDefault();
      if (option is null) {
        var optionData = new TblWorldMarketOption {
          RingBuff = ringRate,
          IsMarketOpen = false,
          WaitPrice = 15_000_000_0000,
          IsRingBuff = false
        };
        TblWorldMarketOptions.Add(option);
      }
      else {
        option.RingBuff = ringRate;
        TblWorldMarketOptions.Update(option);
      }

      var affected = SaveChanges();
      if (affected <= 0) return DbResult.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreTradeDbManager] InitMarketOption Exception {RingRate}", ringRate);
      return DbResult.Error(1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public List<ResultWorldMarketAccumulateTrade> ListWorldMarketAccumulateTrade_Unsafe(int mainGroupNo) {
    var query = TblWorldMarkets
                .Where(x => x.MainCategory == mainGroupNo)
                .OrderBy(x => x.MainCategory)
                .ThenBy(x => x.SubCategory)
                .Select(x => new ResultWorldMarketAccumulateTrade {
                  _keyType = x.KeyType,
                  _mainKey = x.MainKey,
                  _subKey = x.SubKey,
                  _pricePerOne = x.PricePerOne,
                  _minPrice = x.MinPrice,
                  _maxPrice = x.MaxPrice,
                  _accumulateBiddingCount = x.AccumulateBiddingCount,
                  _accumulateTickCount = x.AccumulateTickCount,
                  _maxTradeCount = x.MaxTradeCount,
                  _sumTradeCount = x.SumTradeCount,
                  _sumTradePrice = x.SumTradePrice,
                  _priceGroupKey = x.PriceGroupKey,
                });
    return query.ToList();
    // try {
    //  
    // }
    // catch (Exception ex) {
    //   Log.Error(ex, "[EfCoreTradeDbManager] ListWorldMarketAccumulateTrade Exception {MainGroupNo}", mainGroupNo);
    //   return DbResult<List<ResultWorldMarketAccumulateTrade>>.Error(-1, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    // }
  }


  public List<ResultWaitBiddingSell> ListWaitBiddingSell_Unsafe() {
    var _15MinAgo = CultureModule.GetCustomTimeNow().AddMinutes(-15);
    var query = TblWorldMarketWaitBiddingSells
                .Where(x => x.RegisterDate >= _15MinAgo && x.UsedType == 0)
                .Select(x => new ResultWaitBiddingSell {
                  _waitNo = x.WaitNo,
                  _userNo = x.UserNo,
                  _mainKey = x.MainKey,
                  _subKey = x.SubKey,
                  _chooseSubKey = x.ChooseSubKey,
                  _leftCount = x.LeftCount,
                  _pricePerOne = x.PricePerOne,
                  _isSealed = x.IsSealed,
                  _isRingBuff = x.IsRingBuff,
                  _keyType = x.KeyType,
                  _nationCode = x.NationCode,
                  _serverNo = x.ServerNo,
                });
    return query.ToList();
  }

  public DbResult<bool> IncreaseTickCount_Unsafe(int mainGroupNo) {
    using var tran = Database.BeginTransaction();
    var tickData = TblWorldMarketTickCounts.FirstOrDefault(x => x.MainGroupNo == mainGroupNo);
    if (tickData is null) {
      return DbResult<bool>.Error(-1, GameErrorType.eErrNoDbInternalError);
    }

    tickData.CurrentTickCount++;
    tickData.LastUpdateTime = CultureModule.GetCustomTimeNow();
    tickData.UpdateAccumulateCount++;
    var currentTickCount = tickData.CurrentTickCount;
    var updateTickCount = tickData.UpdateTickCount;
    var isUpdatePrice = currentTickCount >= updateTickCount;
    if (isUpdatePrice) {
      tickData.CurrentTickCount = 0;
    }

    TblWorldMarketTickCounts.Update(tickData);
    var affected = SaveChanges();
    if (affected <= 0) return DbResult<bool>.Error(-2, GameErrorType.eErrNoDbInternalError);
    tran.Commit();
    return isUpdatePrice;
  }

  public DbResult<List<int>> IncreaseTickCount_List_Unsafe(List<int> mainGroupNo) {
    using var tran = Database.BeginTransaction();
    var tickDataList = TblWorldMarketTickCounts.Where(x => mainGroupNo.Contains(x.MainGroupNo)).ToList();
    if (tickDataList is null || tickDataList.Count == 0) {
      return DbResult<List<int>>.Error(-1, GameErrorType.eErrNoDbInternalError);
    }

    var updatePriceList = new List<int>();
    var failedList = new List<int>();
    foreach (var tickData in tickDataList) {
      tickData.CurrentTickCount++;
      tickData.LastUpdateTime = CultureModule.GetCustomTimeNow();
      tickData.UpdateAccumulateCount++;
      var currentTickCount = tickData.CurrentTickCount;
      var updateTickCount = tickData.UpdateTickCount;
      var isUpdatePrice = currentTickCount >= updateTickCount;
      if (isUpdatePrice) {
        tickData.CurrentTickCount = 0;
        updatePriceList.Add(tickData.MainGroupNo);
      }

      TblWorldMarketTickCounts.Update(tickData);
      var affected = SaveChanges();
      if (affected <= 0) {
        failedList.Add(tickData.MainGroupNo);
      }
    }

    tran.Commit();
    return updatePriceList;
  }

  public List<ResultGroupBiddingPrice> ListGroupBiddingPrice_Unsafe(long priceGroupKey,
                                                                    long pricePerOne,
                                                                    double minPriceRatio,
                                                                    double maxPriceRatio) {
    var minPrice = pricePerOne * minPriceRatio;
    var maxPrice = pricePerOne * maxPriceRatio;

    var buyQuery = from buy in TblWorldMarketBiddingBuys
                   join item in TblWorldMarkets on new {
                     buy.MainKey,
                     buy.SubKey
                   } equals new {
                     item.MainKey,
                     item.SubKey
                   }
                   where item.PriceGroupKey == priceGroupKey
                         && minPrice <= buy.PricePerOne
                         && buy.PricePerOne <= maxPrice
                         && buy.LeftCount > 0
                   select new ResultGroupBiddingPrice {
                     _leftCount = buy.LeftCount,
                     _pricePerOne = buy.PricePerOne,
                   };

    var sellQuery = from sell in TblWorldMarketBiddingSells
                    join item in TblWorldMarkets on new {
                      sell.MainKey,
                      sell.SubKey
                    } equals new {
                      item.MainKey,
                      item.SubKey
                    }
                    where item.PriceGroupKey == priceGroupKey
                          && minPrice <= sell.PricePerOne
                          && sell.PricePerOne <= maxPrice
                          && sell.LeftCount > 0
                    select new ResultGroupBiddingPrice {
                      _leftCount = sell.LeftCount,
                      _pricePerOne = sell.PricePerOne,
                    };

    var unionQuery = buyQuery.Union(sellQuery);

    return unionQuery.ToList();


    // var query = (from worldMarket in TblWorldMarkets
    //              where worldMarket.PriceGroupKey == priceGroupKey
    //              join buy in TblWorldMarketBiddingBuys on new {
    //                worldMarket.MainKey,
    //                worldMarket.SubKey
    //              } equals new {
    //                buy.MainKey,
    //                buy.SubKey
    //              }
    //              join sell in TblWorldMarketBiddingSells on new {
    //                worldMarket.MainKey,
    //                worldMarket.SubKey
    //              } equals new {
    //                sell.MainKey,
    //                sell.SubKey
    //              }
    //              where minPrice <= buy.PricePerOne
    //                    && buy.PricePerOne <= maxPrice
    //                    && minPrice <= sell.PricePerOne
    //                    && sell.PricePerOne <= maxPrice
    //                    && sell.LeftCount > 0
    //                    && buy.LeftCount > 0
    //              select new ResultGroupBiddingPrice {
    //                _leftCount = sell.LeftCount + buy.LeftCount,
    //                _pricePerOne = worldMarket.PricePerOne,
    //              });
    // return query.ToList();
  }

  public int UpdateWaitFail(WaitItemModel model,
                            long weight,
                            DateTime currentTime) {
    var num = 0;
    var empty = string.Empty;
    long? beforeCount1;
    long? afterCount1;

    try {
      var updateResult = UpdateWaitFail(model.waitNo,
                                        weight);
      if (!updateResult.Status) {
        Log.Warning("[DB ERROR]uspUpdateWaitFail -  rv({Rv}) symNo({SymNo})", updateResult.Rv, updateResult.SymNo);
        return updateResult.Rv;
      }

      beforeCount1 = updateResult.Data.BeforeCount;
      afterCount1 = updateResult.Data.AfterCount;
    }
    catch (Exception ex) {
      Log.Error(ex, "[DB ERROR]uspUpdateWaitFail");
      return 1;
    }

    ///TODO 
    // WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
    //                                  LogReasonType.eWorldMarket_ReasonType_SellWaitFailUpdate,
    //                                  currentTime,
    //                                  new CommonModel.TradeMarketUserLogInfo {
    //                                    nationCode = model.nationCode,
    //                                    serverNo = model.worldNo,
    //                                    userNo = model.userNo
    //                                  },
    //                                  new CommonModel.TradeMarketItemLogInfo {
    //                                    keyType1 = model.sellKeyType,
    //                                    itemKey1 = model.sellMainKey,
    //                                    enchantLevel1 = model.sellSubKey,
    //                                    count1 = model.sellCount,
    //                                    beforeCount1 = Convert.ToInt64(beforeCount1),
    //                                    afterCount1 = Convert.ToInt64(afterCount1),
    //                                    keyType2 = 0,
    //                                    itemKey2 = 1,
    //                                    enchantLevel2 = 0,
    //                                    count2 = 0L
    //                                  },
    //                                  param2: model.sellChooseKey,
    //                                  param3: Convert.ToInt64(model.isSealed),
    //                                  param5: 2L,
    //                                  param7: model.waitNo);
    return num;
  }


  public DbResult<long> PrepareDepositToWorldMarket(int nationCode,
                                                    int serverNo,
                                                    long userNo,
                                                    int keyType,
                                                    int mainKey,
                                                    int subKey,
                                                    long param0,
                                                    long param1,
                                                    long param2,
                                                    long param3,
                                                    long param4,
                                                    long count,
                                                    bool isSealed,
                                                    long itemWeight,
                                                    long maxWeight) {
    var isGameMaster = IsGameMaster(userNo);
    if (!isGameMaster) {
      var isMarketOpen = IsMarketOpen();
      if (!isMarketOpen) {
        return DbResult<long>.Error(-1, MarketError.TRADE_MARKET_MAINTENANCE_TITLE.GetResourceValue());
      }
    }


    var isBlocked = IsBlocked(userNo);
    if (isBlocked) {
      return DbResult<long>.Error(-2, GameErrorType.eErrNoBlockUser);
    }


    if (mainKey != 1) {
      var totalWeight = itemWeight * count;
      var resPushWeightToMyWallet = PushWeightToMyWallet(userNo, totalWeight, maxWeight, false);

      if (!resPushWeightToMyWallet.Status) {
        //TODO LOG ignore error
        Log.Fatal(" [DB ERROR] PushWeightToMyWallet -  rv({Rv}) symNo({SymNo})", resPushWeightToMyWallet.Rv, resPushWeightToMyWallet.SymNo);
      }
    }
    else {
      var walletExists = WalletExists(userNo); //PushWeightToMyWallet already checks
      if (!walletExists) {
        return DbResult<long>.Error(-3, GameErrorType.eErrNoNotExistWallet);
      }
    }

    var marketPayload = new TblWorldMarketPayload {
      NationCode = nationCode,
      ServerNo = serverNo,
      UserNo = userNo,
      KeyType = keyType,
      MainKey = mainKey,
      SubKey = subKey,
      Param0 = param0,
      Param1 = param1,
      Param2 = param2,
      Param3 = param3,
      Param4 = param4,
      Count = count,
      IsSealed = isSealed,
      RegisterDate = CultureModule.GetCustomTimeNow(),
      Weight = itemWeight * count,
      Type = 0
    };
    Add(marketPayload);
    var save = SaveChanges();
    if (save <= 0) {
      return DbResult<long>.Error(-4, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }

    return marketPayload.Payload;
  }

  private bool WalletExists(long userNo) {
    return TblWorldMarketWalletInfos.Any(x => x.UserNo == userNo);
  }

  private bool IsBlocked(long userNo) {
    var currentTime = CultureModule.GetCustomTimeNow();
    var exists = TblBlockUsers.Any(x => x.UserNo == userNo && (!x.DueDate.HasValue || x.DueDate > currentTime));
    return exists;
  }

  private bool IsGameMaster(long userNo) {
    return TblWorldMarketWalletInfos.Where(x => x.UserNo == userNo).Select(x => x.IsGameMaster).FirstOrDefault();
  }

  public DbResult<short> GetWithDrawPayLoadState(long userNo,
                                                 int nationCode,
                                                 int serverNo,
                                                 long payload,
                                                 int mainKey,
                                                 int? subKey,
                                                 bool isSealed,
                                                 long count,
                                                 long param0,
                                                 long param1,
                                                 long param2,
                                                 long param3,
                                                 long param4) {
    var state = TblWorldMarketPayloads
                .Where(x => x.UserNo == userNo
                            && x.NationCode == nationCode
                            && x.ServerNo == serverNo
                            && x.Payload == payload
                            && x.MainKey == mainKey
                            && x.SubKey == subKey
                            && x.IsSealed == isSealed
                            && x.Count == count
                            && x.Param0 == param0
                            && x.Param1 == param1
                            && x.Param2 == param2
                            && x.Param3 == param3
                            && x.Param4 == param4)
                .Select(x => x.State)
                .FirstOrDefault((short)-1);
    if (state < 0) {
      return DbResult<short>.Error(-1, GameErrorType.eErrNoDbInternalError);
    }

    return state;
  }

  public record struct Result_ProcessWithdrawFromWorldMarket(
    short Reason,
    long BeforeCount1,
    long AfterCount1);

  public DbResult<Result_ProcessWithdrawFromWorldMarket> ProcessWithdrawFromWorldMarket(long payload) {
    var payloadData = TblWorldMarketPayloads
                      .Where(x => x.Payload == payload && x.State == 1)
                      .FirstOrDefault();
    if (payloadData is null) {
      return DbResult<Result_ProcessWithdrawFromWorldMarket>.Error(-1, GameErrorType.eErrNoDbInternalError);
    }

    if (payloadData.State == 1) {
      return new Result_ProcessWithdrawFromWorldMarket(1, 0, 0);
    }

    payloadData.State = 1;
    // var walletExists = WalletExists(payloadData.UserNo);
    // if (!walletExists) {
    //   return DbResult<Result_ProcessWithdrawFromWorldMarket>.Error(-2, GameErrorType.eErrNoNotExistWallet);
    // }
    //


    //  uspPopItemFromMyWallet__XXX START

    if (payloadData.Count <= 0) {
      return DbResult<Result_ProcessWithdrawFromWorldMarket>.Error(-3, GameErrorType.eErrNoItemInvalidCount);
    }

    var wallet = TblWorldMarketWallets
                 .Where(x =>
                          x.UserNo == payloadData.UserNo
                          && x.MainKey == payloadData.MainKey
                          && x.SubKey == payloadData.SubKey
                          && x.IsSealed == payloadData.IsSealed
                          && x.Count >= payloadData.Count)
                 .FirstOrDefault();
    if (wallet is null) {
      return DbResult<Result_ProcessWithdrawFromWorldMarket>.Error(-4, GameErrorType.eErrNoNotExistWallet);
    }

    var beforeCount = wallet.Count;
    wallet.Count -= payloadData.Count;
    var afterCount = wallet.Count;
    TblWorldMarketWallets.Update(wallet);

    var affected = SaveChanges();
    if (affected <= 0) {
      return DbResult<Result_ProcessWithdrawFromWorldMarket>.Error(-5, GameErrorType.eErrNoDbInternalError);
    }
    //  uspPopItemFromMyWallet__XXX END
    
    //uspPopItemFromMyWalletParam__XXX START
    
    var walletInfo = TblWorldMarketWalletInfos
                     .Where(x => x.UserNo == payloadData.UserNo)
                     .FirstOrDefault();
     
    
    //uspPopItemFromMyWalletParam__XXX END
    
    
    
  }
}