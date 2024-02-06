using BlackDesert.Trade.Domain.Abstract;
using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Abstract;

public sealed class StockInfoManger : SingletonBase<StockInfoManger>
{
  protected DateTime LastHotStockUpdateTime;
  protected DateTime LastWaitStockUpdateTime;
  // protected object ManagerLocker = new();
  protected Dictionary<KeyValuePair<int, int>, DetailInfo> StockDetailInfoList;
  protected object StockDetailLocker = new();
  protected Dictionary<KeyValuePair<int, int>, MarketGroupInfo> StockGroupInfoList;
  protected object StockGroupLocker = new();
  protected Dictionary<int, MarketHotItemInfo> StockHotInfoList;
  protected object StockHotLocker = new();
  protected Dictionary<int, MarketItemInfo> StockInfoList;
  protected object StockInfoLocker = new();
  protected List<MarketWaitValue> StockWaitInfoList;
  protected object StockWaitLocker = new();

  private StockInfoManger() {
    StockInfoList = new Dictionary<int, MarketItemInfo>();
    StockGroupInfoList = new Dictionary<KeyValuePair<int, int>, MarketGroupInfo>();
    StockDetailInfoList = new Dictionary<KeyValuePair<int, int>, DetailInfo>();
    StockHotInfoList = new Dictionary<int, MarketHotItemInfo>();
    StockWaitInfoList = new List<MarketWaitValue>();
    LastHotStockUpdateTime = new DateTime();
    
    var stopwatch = Stopwatch.StartNew();
    var stockInfoListWrapper = ItemInfoManager.This.GetItemListXxx();
    ServerControlLogger.LogStart(nameof(StockInfoManger));
    foreach (var keyValuePair in stockInfoListWrapper) {
      var mainKey = keyValuePair.Value._mainKey;
      var subKey = keyValuePair.Value._subKey;
      if (keyValuePair.Value._enchantGroup == subKey) {
        var key1 = new KeyValuePair<int, int>(keyValuePair.Value._mainGroupNo, keyValuePair.Value._subGroupNo);
        var key2 = new KeyValuePair<int, int>(keyValuePair.Value._mainGroupNo, 0);
        if (!StockInfoList.ContainsKey(mainKey))
          StockInfoList[mainKey] = new MarketItemInfo();
        StockInfoList[mainKey]._infoList[subKey] = new MarketValue();
        if (!StockGroupInfoList.ContainsKey(key1))
          StockGroupInfoList[key1] = new MarketGroupInfo();
        if (!StockGroupInfoList[key1]._infoList.ContainsKey(mainKey))
          StockGroupInfoList[key1]._infoList[mainKey] = new MarketValue();
        if (!StockGroupInfoList.ContainsKey(key2))
          StockGroupInfoList[key2] = new MarketGroupInfo();
        if (!StockGroupInfoList[key2]._infoList.ContainsKey(mainKey))
          StockGroupInfoList[key2]._infoList[mainKey] = new MarketValue();
        if (!StockDetailInfoList.ContainsKey(key1))
          StockDetailInfoList[key1] = new DetailInfo();
        StockDetailInfoList[key1]._infoList[keyValuePair.Key] = new MarketValue();
        if (!StockDetailInfoList.ContainsKey(key2))
          StockDetailInfoList[key2] = new DetailInfo();
        StockDetailInfoList[key2]._infoList[keyValuePair.Key] = new MarketValue();
      }
    }
    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(StockInfoManger), stopwatch.ElapsedMilliseconds);
  }


  public CommonResult GetStockListByCategory(int mainCategory,
                                             int subCategory) {
    // var commonDbResult1 = new CommonDBResult<ResultWorldMarket>();
    var updateList = new TradeMarketList();
    var resCheckUpdateTimeByGroupInfo = IsUpdateTimeForGroupInfo(mainCategory, subCategory, CultureModule.GetCustomTimeNow());
    if (resCheckUpdateTimeByGroupInfo) {
      using var ctxTrade = new TradeDbContext();
      var efDbREs = ctxTrade.ListWorldMarket(mainCategory, subCategory,OptionManager.This.MinPriceRatio,OptionManager.This.MaxPriceRatio);
      if (!efDbREs.Status) {
        return efDbREs.ToCommonResult();
      }
      // var commonDbResult2 = TradeDbWrapper.ListWorldMarket(KeyType, mainCategory, subCategory);
      // result = efDbREs.ToCommonResult();
      // result.resultCode = commonDbResult2.resultCode;
      // result.resultMsg = commonDbResult2.resultMsg;
      var list = efDbREs.Data;
      // if (result.resultCode != 0)
      //   return result;
      updateList.list = list;
      if (!UpdateByGroupInfo(mainCategory, subCategory, ref updateList)) {
        return CommonResult.Error(-231, "0");
        // result.resultMsg = "0";
        // return result;
      }
    }
    var result = new CommonResult();
    var jsonRes = GetJsonStringByGroupInfo(mainCategory, subCategory, ref result);
    if (jsonRes)
      return result;
    result.resultMsg = "0";
    return result;
  }

  public CommonResult GetStockSubListByStockKey(int mainKey) {
    var marketListDetail = new TradeMarketListDetail();
    var commonDbResult = new CommonDBResult<ResultWorldMarketDetail>();
    var result = new CommonResult();
    if (IsUpdateTimeForItemInfo(mainKey)) {
      var ctxTrade = new TradeDbContext();
      var dbResult = ctxTrade.ListWorldMarketDetail( mainKey, true, OptionManager.This.MinPriceRatio, OptionManager.This.MaxPriceRatio);
      if (!dbResult.Status)
        return dbResult.ToCommonResult();
      var updateList = dbResult.Data;
      marketListDetail.list = dbResult.Data;
      if (!UpdateByItemInfo(ref updateList)) {
        result.resultMsg = "0";
        return result;
      }
    }

    if (GetJsonStringByItemInfo(mainKey, ref result))
      return result;
    result.resultMsg = "0";
    return result;
  }

  public bool IsUpdateTimeForItemInfo(int mainKey) {
    var  currentTime = CultureModule.GetCustomTimeNow();
    if (mainKey <= 0)
      return false;
    lock (StockInfoLocker) {
      if (!StockInfoList.ContainsKey(mainKey))
        return false;
      var lastUpdateTime = StockInfoList[mainKey]._lastUpdateTime;
      if (currentTime < lastUpdateTime.AddSeconds(1))
        return false;
      StockInfoList[mainKey]._lastUpdateTime = currentTime;
    }
    return true;
  }

  private bool IsUpdateTimeForGroupInfo(int mainGroupNo,
                                          int subGroupNo,
                                          DateTime currentTime) {
    if (mainGroupNo <= 0 || subGroupNo < 0)
      return false;
    lock (StockGroupLocker) {
      var key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
      if (!StockGroupInfoList.ContainsKey(key))
        return false;
      var lastUpdateTime = StockGroupInfoList[key]._lastUpdateTime;
      if (currentTime < lastUpdateTime.AddSeconds(1.0))
        return false;
      StockGroupInfoList[key]._lastUpdateTime = currentTime;
    }

    return true;
  }

  public bool IsUpdateTimeForDetailInfo(int mainGroupNo,
                                          int subGroupNo,
                                          DateTime currentTime) {
    if (mainGroupNo <= 0 || subGroupNo < 0)
      return false;
    lock (StockDetailLocker) {
      var key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
      if (!StockDetailInfoList.ContainsKey(key))
        return false;
      var lastUpdateTime = StockDetailInfoList[key]._lastUpdateTime;
      if (currentTime < lastUpdateTime.AddSeconds(1.0))
        return false;
      StockDetailInfoList[key]._lastUpdateTime = currentTime;
    }

    return true;
  }

  public bool IsUpdateTimeForHotItemInfo() {
    var currentTime = CultureModule.GetCustomTimeNow();
    var hotStockUpdateTime = LastHotStockUpdateTime;
    if (currentTime <= hotStockUpdateTime.AddSeconds(1)) 
      return false;
    lock (StockHotLocker) {
      if (currentTime <= hotStockUpdateTime.AddSeconds(1)) 
        return false;
      LastHotStockUpdateTime = currentTime;
    }
    return true;
  }

  public bool IsUpdateTimeForWaitItemInfo() {
    var currentTime = CultureModule.GetCustomTimeNow();
    var waitStockUpdateTime = LastWaitStockUpdateTime;
    if (currentTime <= waitStockUpdateTime.AddSeconds(1))
      return false;
    lock (StockWaitLocker) {
      if (currentTime <= waitStockUpdateTime.AddSeconds(1))
        return false;
      LastWaitStockUpdateTime = currentTime;
    }
    return true;
  }

  public bool UpdateByItemInfo(
    ref List<ResultWorldMarketDetail> updateList) {
    if (updateList.Count <= 0)
      return false;
    lock (StockInfoLocker) {
      foreach (var marketDetailResult in updateList) {
        var cMainKey = marketDetailResult._mainKey;
        var cSubKey = marketDetailResult._subKey;
        if (StockInfoList.ContainsKey(cMainKey) && StockInfoList[cMainKey]._infoList.ContainsKey(cSubKey)) {
          var info1 = StockInfoList[cMainKey]._infoList[cSubKey];
          var nullable = marketDetailResult._count;
          var num1 = nullable.Value;
          info1._count = num1;
          var info2 = StockInfoList[cMainKey]._infoList[cSubKey];
          nullable = marketDetailResult._totalTradeCount;
          var num2 = nullable.Value;
          info2._totalTradedCount = num2;
          var info3 = StockInfoList[cMainKey]._infoList[cSubKey];
          nullable = marketDetailResult._pricePerOne;
          var num3 = nullable.Value;
          info3._pricePerOne = num3;
          StockInfoList[cMainKey]._infoList[cSubKey]._minPrice = marketDetailResult._minPrice;
          StockInfoList[cMainKey]._infoList[cSubKey]._maxPrice = marketDetailResult._maxPrice;
          StockInfoList[cMainKey]._infoList[cSubKey]._lastTradePrice = marketDetailResult._lastTradePrice;
          StockInfoList[cMainKey]._infoList[cSubKey]._lastTradeTime = marketDetailResult._lastTradeTime;
          StockInfoList[cMainKey]._infoList[cSubKey]._isDisplay = marketDetailResult._isDisplay.Value;
        }
      }
    }

    return true;
  }

  private bool UpdateByGroupInfo(int mainGroupNo,
                                 int subGroupNo,
                                 ref TradeMarketList updateList) {
    if (mainGroupNo <= 0 || subGroupNo < 0 || updateList.list.Count <= 0)
      return false;
    lock (StockGroupLocker) {
      var key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
      if (!StockGroupInfoList.ContainsKey(key))
        return false;
      foreach (var worldMarketResult in updateList.list) {
        var cMainKey = worldMarketResult._mainKey;
        if (StockGroupInfoList[key]._infoList.ContainsKey(cMainKey)) {
          var info1 = StockGroupInfoList[key]._infoList[cMainKey];
          var nullable = worldMarketResult._sumCount;
          var num1 = nullable.Value;
          info1._count = num1;
          var info2 = StockGroupInfoList[key]._infoList[cMainKey];
          nullable = worldMarketResult._totalSumCount;
          var num2 = nullable.Value;
          info2._totalTradedCount = num2;
          var info3 = StockGroupInfoList[key]._infoList[cMainKey];
          nullable = worldMarketResult._minPrice;
          var num3 = nullable.Value;
          info3._pricePerOne = num3;
          StockGroupInfoList[key]._infoList[cMainKey]._isDisplay = worldMarketResult._isDisplay;
        }
      }
    }

    return true;
  }

  public bool UpdateByDetailInfo(
    int mainGroupNo,
    int subGroupNo,
    ref TradeMarketListDetailByCategory updateList) {
    if (mainGroupNo <= 0 || subGroupNo < 0 || updateList.list.Count <= 0)
      return false;
    lock (StockDetailLocker) {
      var key1 = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
      if (!StockDetailInfoList.ContainsKey(key1))
        return false;
      foreach (var byCategoryResult in updateList.list) {
        var key2 = new KeyValuePair<int, int>(byCategoryResult._mainKey, byCategoryResult._subKey);
        if (StockDetailInfoList[key1]._infoList.ContainsKey(key2)) {
          var info1 = StockDetailInfoList[key1]._infoList[key2];
          var nullable = byCategoryResult._count;
          var num1 = nullable.Value;
          info1._count = num1;
          var info2 = StockDetailInfoList[key1]._infoList[key2];
          nullable = byCategoryResult._totalTradeCount;
          var num2 = nullable.Value;
          info2._totalTradedCount = num2;
          var info3 = StockDetailInfoList[key1]._infoList[key2];
          nullable = byCategoryResult._pricePerOne;
          var num3 = nullable.Value;
          info3._pricePerOne = num3;
          StockDetailInfoList[key1]._infoList[key2]._minPrice = byCategoryResult._minPrice;
          StockDetailInfoList[key1]._infoList[key2]._maxPrice = byCategoryResult._maxPrice;
          StockDetailInfoList[key1]._infoList[key2]._isDisplay = byCategoryResult._isDisplay.Value;
        }
      }
    }

    return true;
  }

  public bool UpdateByHotItemInfo(List<ResultWorldMarketHot> updateList) {
    lock (StockHotLocker) {
      StockHotInfoList.Clear();
      StockHotInfoList = new Dictionary<int, MarketHotItemInfo>();
      foreach (var worldMarketHotResult in updateList) {
        var cMainKey = worldMarketHotResult._mainKey;
        var cSubKey = worldMarketHotResult._subKey;
        var tradeMarketItemInfo = ItemInfoManager.This.GetInfo(cMainKey, cSubKey);
        if (tradeMarketItemInfo.IsValid()) {
          if (!StockHotInfoList.ContainsKey(cMainKey))
            StockHotInfoList[cMainKey] = new MarketHotItemInfo();
          if (!StockHotInfoList[cMainKey]._infoList.ContainsKey(cSubKey))
            StockHotInfoList[cMainKey]._infoList[cSubKey] = new MarketHotValue();
          var info1 = StockHotInfoList[cMainKey]._infoList[cSubKey];
          var nullable = worldMarketHotResult._count;
          var num1 = nullable.Value;
          info1._count = num1;
          var info2 = StockHotInfoList[cMainKey]._infoList[cSubKey];
          nullable = worldMarketHotResult._totalTradeCount;
          var num2 = nullable.Value;
          info2._totalTradedCount = num2;
          var info3 = StockHotInfoList[cMainKey]._infoList[cSubKey];
          nullable = worldMarketHotResult._pricePerOne;
          var num3 = nullable.Value;
          info3._pricePerOne = num3;
          StockHotInfoList[cMainKey]._infoList[cSubKey]._fluctuationType = worldMarketHotResult._fluctuationType;
          StockHotInfoList[cMainKey]._infoList[cSubKey]._fluctuationPrice = worldMarketHotResult._fluctuationPrice;
          StockHotInfoList[cMainKey]._infoList[cSubKey]._minPrice = worldMarketHotResult._minPrice;
          StockHotInfoList[cMainKey]._infoList[cSubKey]._maxPrice = worldMarketHotResult._maxPrice;
          StockHotInfoList[cMainKey]._infoList[cSubKey]._lastTradePrice = worldMarketHotResult._lastTradePrice;
          StockHotInfoList[cMainKey]._infoList[cSubKey]._lastTradeTime = worldMarketHotResult._lastTradeTime;
        }
      }
    }

    return true;
  }

  public bool UpdateByWaitItemInfo(List<ResultWorldMarketWait> updateList) {
    lock (StockWaitLocker) {
      StockWaitInfoList.Clear();
      StockWaitInfoList = new List<MarketWaitValue>();
      foreach (var marketWaitResult in updateList) {
        var cMainKey = marketWaitResult._mainKey;
        var cChooseSubKey = marketWaitResult._chooseSubKey;
        var tradeMarketItemInfo = ItemInfoManager.This.GetInfo(cMainKey, cChooseSubKey);
        if (tradeMarketItemInfo.IsValid())
          StockWaitInfoList.Add(new MarketWaitValue {
            _mainKey = marketWaitResult._mainKey,
            _subKey = marketWaitResult._chooseSubKey,
            _pricePerOne = marketWaitResult._pricePerOne,
            _waitEndTime = marketWaitResult._waitEndTime.Value
          });
      }
    }

    return true;
  }

  public bool GetJsonStringByItemInfo(int mainKey,
                                      ref CommonResult result) {
    if (mainKey <= 0 || !StockInfoList.ContainsKey(mainKey))
      return false;
    var num1 = 0;
    foreach (var info in StockInfoList[mainKey]._infoList)
      if (0 < info.Value._isDisplay) {
        var num2 = info.Value._lastTradeTime.ToUniversalTime().ConvertUnixTime();
        if (num2 <= 0L)
          num2 = 0L;
        result.resultMsg = result.resultMsg + Convert.ToString(mainKey) + "-" + Convert.ToString(info.Key) + "-" + Convert.ToString(ItemInfoManager.This.GetEnchantMaxGroup(mainKey, info.Key)) +
                           "-" + Convert.ToString(info.Value._pricePerOne) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" +
                           Convert.ToString(info.Value._minPrice) + "-" + Convert.ToString(info.Value._maxPrice) + "-" + Convert.ToString(info.Value._lastTradePrice) + "-" + Convert.ToString(num2) +
                           "|";
        ++num1;
      }

    return num1 != 0;
  }

  public long GetMaterialItemInfoXxx(int mainKey) {
    return mainKey <= 0 || !StockInfoList.ContainsKey(mainKey) || 1 != StockInfoList[mainKey]._infoList.Count
             ? 0L
             : StockInfoList[mainKey]._infoList[0]._pricePerOne;
  }

  private bool GetJsonStringByGroupInfo(int mainGroupNo,
                                        int subGroupNo,
                                        ref CommonResult result) {
    if (mainGroupNo <= 0 || subGroupNo < 0)
      return false;
    var key = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
    if (!StockGroupInfoList.ContainsKey(key)) {
      result.resultMsg = "0";
      return false;
    }

    var num = 0;
    foreach (var info in StockGroupInfoList[key]._infoList)
      if (0 < info.Value._isDisplay) {
        result.resultMsg = result.resultMsg + Convert.ToString(info.Key) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" +
                           Convert.ToString(info.Value._pricePerOne) + "|";
        ++num;
      }

    if (num == 0)
      result.resultMsg = "0";
    return true;
  }

  public bool GetJsonStringByDetailInfo(int mainGroupNo,
                                        int subGroupNo,
                                        ref CommonResult result) {
    if (mainGroupNo <= 0 || subGroupNo < 0)
      return false;
    var key1 = new KeyValuePair<int, int>(mainGroupNo, subGroupNo);
    if (!StockDetailInfoList.ContainsKey(key1)) {
      result.resultMsg = "0";
      return false;
    }

    var num = 0;
    foreach (var info in StockDetailInfoList[key1]._infoList)
      if (0 < info.Value._isDisplay) {
        var key2 = info.Key.Key;
        var groupLevel = info.Key.Value;
        result.resultMsg = result.resultMsg + Convert.ToString(key2) + "-" + Convert.ToString(groupLevel) + "-" + Convert.ToString(ItemInfoManager.This.GetEnchantMaxGroup(key2, groupLevel)) + "-" +
                           Convert.ToString(info.Value._pricePerOne) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" +
                           Convert.ToString(info.Value._minPrice) + "-" + Convert.ToString(info.Value._maxPrice) + "|";
        ++num;
      }

    if (num != 0)
      return true;
    result.resultMsg = "0";
    return false;
  }

  public string GetJsonStringForHotItemInfo() {
    if (StockHotInfoList.Count == 0) {
      return "0";
    }
    lock (StockHotLocker) {
      var msg = "";
      var num1 = 0;
      foreach (var stockHotInfo in StockHotInfoList) {
        var key = stockHotInfo.Key;
        foreach (var info in stockHotInfo.Value._infoList) {
          var num2 = info.Value._lastTradeTime.ToUniversalTime().ConvertUnixTime();
          if (num2 <= 0L)
            num2 = 0L;
          msg = msg + Convert.ToString(key) + "-" + Convert.ToString(info.Key) + "-" + Convert.ToString(ItemInfoManager.This.GetEnchantMaxGroup(key, info.Key)) + "-" +
                Convert.ToString(info.Value._pricePerOne) + "-" + Convert.ToString(info.Value._count) + "-" + Convert.ToString(info.Value._totalTradedCount) + "-" +
                Convert.ToString(info.Value._fluctuationType) + "-" + Convert.ToString(info.Value._fluctuationPrice) + "-" + Convert.ToString(info.Value._minPrice) + "-" +
                Convert.ToString(info.Value._maxPrice) + "-" + Convert.ToString(info.Value._lastTradePrice) + "-" +
                Convert.ToString(num2) + "|";
          ++num1;
        }
      }

      if (num1 == 0) {
        return "0";
      }

      return msg;
    }
  }

  public string GetJsonStringForWaitItemInfo() {
    if (StockWaitInfoList.Count == 0) {
      return "0";
    }
    lock (StockWaitLocker) {
      if (StockWaitInfoList.Count == 0) {
        return "0";
      }
      var msg = "";
      foreach (var stockWaitInfo in StockWaitInfoList) {
        var num = stockWaitInfo._waitEndTime.ToUniversalTime().ConvertUnixTime();
        if (num <= 0L)
          num = 0L;
        msg = msg + Convert.ToString(stockWaitInfo._mainKey) + "-" + Convert.ToString(stockWaitInfo._subKey) + "-" + Convert.ToString(stockWaitInfo._pricePerOne) + "-" +
              Convert.ToString(num) + "|";
      }
      return msg;
    }
  }
}