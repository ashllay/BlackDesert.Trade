using BlackDesert.Trade.Business.Manager.Abstract;
using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.Api;
using BlackDesert.Trade.Domain.Models.Process;

namespace BlackDesert.Trade.Business.Services;

public sealed class TradeBiddingService
{
  private readonly TradeProcessService _processService;
  private readonly TradeDbContext _tradeDbContext;

  public TradeBiddingService(TradeProcessService processService,
                             TradeDbContext tradeDbContext) {
    _processService = processService;
    _tradeDbContext = tradeDbContext;
  }

  public CommonResult WithdrawBuyBidding(GameTradeMarketRequestBuyBiddingAuthModel model) {
    var resultCheckAuthKey = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    if (0L > model.count) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());

    var marketBiddingInfo = new ProcessTradeMarketBiddingInfo {
      nationCode = resultCheckAuthKey.nationCode,
      serverNo = resultCheckAuthKey.worldNo,
      userNo = resultCheckAuthKey.userNo,
      biddingNo = model.buyNo,
      keyType = model.keyType,
      mainKey = model.mainKey,
      subKey = model.subKey,
      count = model.count,
      isWebAccess = false
    };
    var resultWithdrawBuyBiddingProcess = _processService.WithdrawBuyBiddingProcess(marketBiddingInfo);
    return resultWithdrawBuyBiddingProcess;
  }

  public CommonResult CalculateBuyBidding(GameTradeMarketRequestBuyBiddingAuthModel model) {
    // UserInformationModel userInfo = null;

    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var marketBiddingInfo = new ProcessTradeMarketBiddingInfo {
      nationCode = user.nationCode,
      serverNo = user.worldNo,
      userNo = user.userNo,
      biddingNo = model.buyNo,
      keyType = model.keyType,
      mainKey = model.mainKey,
      subKey = model.subKey,
      isWebAccess = false
    };
    var resultCalculateBuyBiddingProcess = _processService.CalculateBuyBiddingProcess(marketBiddingInfo);
    if (resultCalculateBuyBiddingProcess.resultCode != 0)
      return resultCalculateBuyBiddingProcess;

    var msg = resultCalculateBuyBiddingProcess.resultMsg + "-" + Convert.ToString(false); //userInfo._isReturn
    return new CommonResult(0, msg);
  }

  public CommonResult WithdrawSellBidding(GameTradeMarketRequestSellBiddingAuthModel model) {
    // UserInformationModel userInfo = null;
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var rvCheckValidCount = WorldMarketValidator.CheckValidCount(1, model.count);
    if (rvCheckValidCount != 0) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());

    var marketBiddingInfo = new ProcessTradeMarketBiddingInfo {
      nationCode = user.nationCode,
      serverNo = user.worldNo,
      userNo = user.userNo,
      biddingNo = model.sellNo,
      keyType = model.keyType,
      mainKey = model.mainKey,
      subKey = model.subKey,
      isSealed = bool.Parse(model.isSealed),
      count = model.count,
      isWebAccess = false
    };
    var resultWithdrawSellBiddingProcess = _processService.WithdrawSellBiddingProcess(marketBiddingInfo);
    return resultWithdrawSellBiddingProcess;
  }

  public CommonResult CalculateSellBidding(GameTradeMarketRequestSellBiddingAuthModel model) {
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var marketBiddingInfo = new ProcessTradeMarketBiddingInfo {
      nationCode = user.nationCode,
      serverNo = user.worldNo,
      userNo = user.userNo,
      biddingNo = model.sellNo,
      keyType = model.keyType,
      mainKey = model.mainKey,
      isSealed = bool.Parse(model.isSealed),
      subKey = model.subKey,
      isWebAccess = false
    };
    var resultCalculateSellBiddingProcess = _processService.CalculateSellBiddingProcess(marketBiddingInfo);
    if (resultCalculateSellBiddingProcess.resultCode != 0)
      return resultCalculateSellBiddingProcess;
    var msg = resultCalculateSellBiddingProcess.resultMsg + "-" + Convert.ToString(false);
    return new CommonResult(0, msg);
  }

  public CommonResult GetMyBiddingList(ViewRequestUserAuthModel authInfo) {
    var marketListUserBidding = new ProcessTradeMarketListUserBidding();
    var commonDbResult1 = new CommonDBResult<ResultUserBiddingBuy>();
    var commonDbResult2 = new CommonDBResult<ResultUserBiddingSell>();
    var commonDbResult3 = new CommonDBResult<ResultWorldMarketDetail>();
    var userInfo = TradeAuthService.AuthenticateForGame(authInfo.userNo, authInfo.certifiedKey);
    var resultBiddingBuy = _tradeDbContext.ListUserBiddingBuy(userInfo.userNo);
    if (!resultBiddingBuy.Status) {
      return resultBiddingBuy.ToCommonResult();
    }

    var resultBiddingSell = _tradeDbContext.ListUserBiddingSell(userInfo.userNo);
    if (!resultBiddingSell.Status) {
      return resultBiddingSell.ToCommonResult();
    }

    // var resListUserBiddingBuy = TradeDbWrapper.ListUserBiddingBuy(userInfo.nationCode, userInfo.worldNo, userInfo.userNo);
    // if (resListUserBiddingBuy.resultCode != 0)
    //   return new CommonResult(resListUserBiddingBuy.resultCode, resListUserBiddingBuy.resultMsg);
    marketListUserBidding.buylist = resultBiddingBuy.Data;
    // var resListUserBiddingSell = TradeDbWrapper.ListUserBiddingSell(userInfo.nationCode, userInfo.worldNo, userInfo.userNo);
    // if (resListUserBiddingSell.resultCode != 0)
    //   return new CommonResult(resListUserBiddingSell.resultCode, resListUserBiddingSell.resultMsg);
    marketListUserBidding.selllist = resultBiddingSell.Data;
    var resultMsg = string.Empty;
    if (marketListUserBidding.buylist.Count == 0 && marketListUserBidding.selllist.Count == 0) {
      resultMsg = "0";
    }
    else {
      for (var index = 0; index < marketListUserBidding.buylist.Count; ++index) {
        resultMsg = resultMsg + Convert.ToString(marketListUserBidding.buylist[index]._buyNo) + "-" + Convert.ToString(marketListUserBidding.buylist[index]._mainKey) + "-" +
                    Convert.ToString(marketListUserBidding.buylist[index]._subKey) + "-" + Convert.ToString(marketListUserBidding.buylist[index]._chooseSubKey) + "-" +
                    Convert.ToString(marketListUserBidding.buylist[index]._leftCount) + "-" + Convert.ToString(marketListUserBidding.buylist[index]._boughtCount) + "-" +
                    Convert.ToString(marketListUserBidding.buylist[index]._pricePerOne) + "-" + Convert.ToString(marketListUserBidding.buylist[index]._basePrice) + "-" +
                    Convert.ToString(marketListUserBidding.buylist[index]._minPrice) + "-" + Convert.ToString(marketListUserBidding.buylist[index]._addEnchantPrice) + "-" +
                    Convert.ToString(marketListUserBidding.buylist[index]._registerMoneyCount);
        if (index < marketListUserBidding.buylist.Count - 1)
          resultMsg += "|";
      }

      if (marketListUserBidding.buylist.Count == 0)
        resultMsg += "0";
      resultMsg += "+";
      for (var index = 0; index < marketListUserBidding.selllist.Count; ++index) {
        var cMainKey = marketListUserBidding.selllist[index]._mainKey;
        var cChooseSubKey = marketListUserBidding.selllist[index]._chooseSubKey;
        var info = ItemInfoManager.This.GetInfo(cMainKey, cChooseSubKey);
        if (!info.IsValid()) return new CommonResult(8, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue());

        var enchantMaxGroup = ItemInfoManager.This.GetEnchantMaxGroup(cMainKey, info._enchantGroup);
        if (info._enchantGroup > cChooseSubKey || cChooseSubKey > enchantMaxGroup)
          return new CommonResult(9, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup.GetResourceValue());

        long num;
        if (enchantMaxGroup == info._enchantGroup) {
          num = 0L;
        }
        else {
          if (StockInfoManger.This.IsUpdateTimeForItemInfo(info._enchantMaterialKey)) {
            var dbResult = _tradeDbContext.ListWorldMarketDetail(info._enchantMaterialKey, false, OptionManager.This.MinPriceRatio, OptionManager.This.MaxPriceRatio);
            if (!dbResult.Status) return dbResult.ToCommonResult();

            var updateList = dbResult.Data;
            if (0 >= updateList.Count) return new CommonResult(15, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemNotExist.GetResourceValue());

            if (!StockInfoManger.This.UpdateByItemInfo(ref updateList)) return new CommonResult(0, "0");
          }

          num = StockInfoManger.This.GetMaterialItemInfoXxx(info._enchantMaterialKey) * info._enchantNeedCount;
          if (num < 0L) return new CommonResult(14, MarketError.TRADE_MARKET_ERROR_MSG_PRICE_WORNG.GetResourceValue());
        }

        resultMsg = resultMsg + Convert.ToString(marketListUserBidding.selllist[index]._sellNo) + "-" + Convert.ToString(marketListUserBidding.selllist[index]._mainKey) + "-" +
                    Convert.ToString(marketListUserBidding.selllist[index]._subKey) + "-" + Convert.ToString(marketListUserBidding.selllist[index]._chooseSubKey) + "-" +
                    Convert.ToString(marketListUserBidding.selllist[index]._leftCount) + "-" + Convert.ToString(marketListUserBidding.selllist[index]._soldCount) + "-" +
                    Convert.ToString(marketListUserBidding.selllist[index]._pricePerOne) + "-" + Convert.ToString(marketListUserBidding.selllist[index]._accumulateMoneyCount) + "-" +
                    Convert.ToString(num) + "-" + Convert.ToString(marketListUserBidding.selllist[index]._isSealed) + "-" + Convert.ToString(marketListUserBidding.selllist[index]._isRingBuff);
        if (index < marketListUserBidding.selllist.Count - 1)
          resultMsg += "|";
      }

      if (marketListUserBidding.selllist.Count == 0)
        resultMsg += "0";
    }

    return CommonResult.Success(resultMsg);
  }

  [CacheAspect]
  public CommonResult GetBiddingInfoList(int keyType,
                                         int mainKey,
                                         int subKey) {
    var commonDbResult = new CommonDBResult<ResultListBiddingInfo>();
    var keyValuePair = new KeyValuePair<int, int>(mainKey, subKey);
    var jsonResult = new CommonResult();
    var info = ItemInfoManager.This.GetInfo(mainKey, subKey);
    if (!info.IsValid()) return new CommonResult(8, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue());

    var resultMsg = string.Empty;
    var lastUpdateBiddingTime = BiddingInfoManager.This.CheckBiddingUpdateTimeXxx(mainKey, info._enchantGroup, CultureModule.GetCustomTimeNow());
    if (lastUpdateBiddingTime) {
      var listResult = _tradeDbContext.ListBiddingInfo(keyType, mainKey, subKey, info._enchantMaterialKey, OptionManager.This.BiddingRatio);
      if (!listResult.Status) {
        return listResult.ToCommonResult();
      }

      var list = listResult.Data;
      // var list = TradeDbWrapper.ListBiddingInfo(keyType, mainKey, info._enchantGroup, info._enchantMaterialKey, OptionManager.This.BiddingRatio);
      // if (list.resultCode != 0)
      //   return new CommonResult(list.resultCode, list.resultMsg);
      if (!BiddingInfoManager.This.UpdateBiddingInfoListXxx(mainKey, info._enchantGroup, ref list)) {
        resultMsg = "0";
        return new CommonResult(0, resultMsg);
      }
    }

    BiddingInfoManager.This.GetJsonStringByBiddingListXxx(mainKey, info._enchantGroup, ref jsonResult);
    return jsonResult;
  }

  [CacheAspect]
  public CommonResult GetAddEnchantLevelPrice(int keyType,
                                              int mainKey,
                                              int subKey) {
    var commonDbResult = new CommonDBResult<ResultWorldMarketDetail>();
    var commonResult = new CommonResult();
    if (mainKey <= 0) return CommonResult.Error(8, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue());

    var info = ItemInfoManager.This.GetInfo(mainKey, subKey);
    if (!info.IsValid()) return CommonResult.Error(8, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue());

    var enchantMaxGroup = ItemInfoManager.This.GetEnchantMaxGroup(mainKey, info._enchantGroup);
    if (info._enchantGroup > subKey || subKey > enchantMaxGroup) return CommonResult.Error(9, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup.GetResourceValue());

    if (enchantMaxGroup == info._enchantGroup) {
      commonResult.resultMsg = Convert.ToString(0) + "-" + Convert.ToString(subKey);
      return commonResult;
    }

    if (StockInfoManger.This.IsUpdateTimeForItemInfo(info._enchantMaterialKey)) {
      var dbResult = _tradeDbContext.ListWorldMarketDetail(info._enchantMaterialKey, false, OptionManager.This.MinPriceRatio, OptionManager.This.MaxPriceRatio);
      if (!dbResult.Status)
        return dbResult.ToCommonResult();
      var updateList = dbResult.Data;
      if (0 >= updateList.Count) {
        commonResult.resultCode = 15;
        commonResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemNotExist.GetResourceValue();
        return commonResult;
      }

      if (!StockInfoManger.This.UpdateByItemInfo(ref updateList)) {
        commonResult.resultMsg = "0";
        return commonResult;
      }
    }

    var num = StockInfoManger.This.GetMaterialItemInfoXxx(info._enchantMaterialKey) * info._enchantNeedCount;
    if (num < 0L) {
      commonResult.resultCode = 14;
      commonResult.resultMsg = MarketError.TRADE_MARKET_ERROR_MSG_PRICE_WORNG.GetResourceValue();
      return commonResult;
    }

    commonResult.resultMsg = Convert.ToString(num) + "-" + Convert.ToString(subKey);
    return commonResult;
  }

  [CacheAspect]
  public CommonResult GetTradePrice(int keyType,
                                    int mainKey,
                                    int subKey) {
    var commonDbResult = new CommonDBResult<ResultWorldMarketDetail>();
    var commonResult1 = new CommonResult();
    var commonResult2 = new CommonResult();
    commonResult2.resultMsg = Convert.ToString(0) + "-" + Convert.ToString(mainKey) + "-" + Convert.ToString(subKey);

    if (mainKey <= 0) return commonResult2;

    var info = ItemInfoManager.This.GetInfo(mainKey, subKey);
    if (!info.IsValid()) return commonResult2;

    var enchantMaxGroup = ItemInfoManager.This.GetEnchantMaxGroup(mainKey, info._enchantGroup);
    if (info._enchantGroup > subKey || subKey > enchantMaxGroup) return commonResult2;


    var resWorldMarketDetailOne = _tradeDbContext.WorldMarketDetailOne(mainKey,
                                                                       info._enchantGroup);
    if (!resWorldMarketDetailOne.Status) {
      return resWorldMarketDetailOne.ToCommonResult();
    }

    var pricePerOne = resWorldMarketDetailOne.Data.PricePerOne;
    var count = resWorldMarketDetailOne.Data.Count;
    var minPrice = resWorldMarketDetailOne.Data.MinPrice;
    var maxPrice = resWorldMarketDetailOne.Data.MaxPrice;
    var totalTradeCount = resWorldMarketDetailOne.Data.TotalTradeCount;
    var lastTradePrice = resWorldMarketDetailOne.Data.LastTradePrice;
    var lastTradeTime = resWorldMarketDetailOne.Data.LastTradeTime;
    // var commonResult3 = TradeDbWrapper.WorldMarketDetailOne(mainKey,
    //                                                         info._enchantGroup,
    //                                                         ref pricePerOne,
    //                                                         ref count,
    //                                                         ref minPrice,
    //                                                         ref maxPrice,
    //                                                         ref totalTradeCount,
    //                                                         ref lastTradePrice,
    //                                                         ref lastTradeTime);
    // if (commonResult3.resultCode != 0)
    //   return commonResult2;
    if (enchantMaxGroup == info._enchantGroup) {
      return CommonResult.Success(Convert.ToString(pricePerOne) + "-" + Convert.ToString(mainKey) + "-" + Convert.ToString(subKey));
    }

    if (StockInfoManger.This.IsUpdateTimeForItemInfo(info._enchantMaterialKey)) {
      var dbResult = _tradeDbContext.ListWorldMarketDetail(info._enchantMaterialKey, false, OptionManager.This.MinPriceRatio, OptionManager.This.MaxPriceRatio);
      if (!dbResult.Status)
        return dbResult.ToCommonResult();
      var updateList = dbResult.Data;
      if (0 >= updateList.Count) return commonResult2;

      if (!StockInfoManger.This.UpdateByItemInfo(ref updateList))
        return commonResult2;
    }

    var num = StockInfoManger.This.GetMaterialItemInfoXxx(info._enchantMaterialKey) * info._enchantNeedCount;
    if (num < 0L) return commonResult2;
    return CommonResult.Success(Convert.ToString(pricePerOne + num) + "-" + Convert.ToString(mainKey) + "-" + Convert.ToString(subKey));
  }

  public CommonResult GetMarketPriceInfo(int keyType,
                                         int mainKey,
                                         int subKey) {
    WorldMarketValidator.ValidateItemMainKey(mainKey);
    WorldMarketValidator.CheckValidItemSubKey(subKey);
    // var commonDbResult1 = new CommonDBResult<ResultGetMarketPriceInfo>();
    var errorMsg = 0.ToString() + "-" + mainKey.ToString() + "-" + subKey.ToString();
    var info = ItemInfoManager.This.GetInfo(mainKey, subKey);
    if (!info.IsValid()) return CommonResult.Error(-1, errorMsg);
    var enchantMaxGroup = ItemInfoManager.This.GetEnchantMaxGroup(mainKey, info._enchantGroup);
    if (info._enchantGroup > subKey || subKey > enchantMaxGroup) return CommonResult.Error(-2, errorMsg);
    // long pricePerOne = 0;
    // long count = 0;
    // long minPrice = 0;
    // long maxPrice = 0;
    // long totalTradeCount = 0;
    // long lastTradePrice = 0;
    // long lastTradeTime = 0;
    // var commonResult3 = TradeDbWrapper.WorldMarketDetailOne(mainKey,
    //                                                         info._enchantGroup,
    //                                                         ref pricePerOne,
    //                                                         ref count,
    //                                                         ref minPrice,
    //                                                         ref maxPrice,
    //                                                         ref totalTradeCount,
    //                                                         ref lastTradePrice,
    //                                                         ref lastTradeTime);

    var resultItemPricePerOne = _tradeDbContext.GetItemPrice(mainKey, info._enchantGroup);
    if (!resultItemPricePerOne.Status) {
      return resultItemPricePerOne.ToCommonResult();
    }

    var pricePerOne = resultItemPricePerOne.Data;

    // var result = TradeDbWrapper.GetItemPriceHistoryInfoForGraph(keyType, mainKey, info._enchantGroup);
    var dbResult = _tradeDbContext.GetItemPriceHistoryInfoForGraph(keyType, mainKey, info._enchantGroup);
    if (!dbResult.Status) {
      return dbResult.ToCommonResult();
    }


    var list = dbResult.Data;
    // var commonDbResult2 = TradeDbWrapper.GetItemPriceHistoryInfoForGraph(keyType, mainKey, subKey);
    // if (commonResult3.resultCode != 0)
    //   return commonResult2;
    var customTime = CultureModule.GetCustomTimeNow();
    var numArray1 = new long[90];
    numArray1.Initialize();
    if (list.Count == 0) {
      for (var index = 0; index < numArray1.Length; ++index)
        numArray1[index] = pricePerOne;
    }
    else {
      for (var index = 0; index < list.Count; ++index) {
        var timeSpan = customTime - list[index]._dateTime;
        if (timeSpan.Days < numArray1.Length) {
          var numArray2 = numArray1;
          numArray2[numArray2.Length - 1 - timeSpan.Days] = list[index]._price;
        }
      }

      long num1 = 0;
      long num2 = 0;
      for (var index1 = numArray1.Length - 1; 0 <= index1; --index1)
        if (numArray1[index1] == 0L) {
          ++num2;
        }
        else {
          for (var index2 = 0; index2 < num2; ++index2)
            numArray1[index1 + index2 + 1] = numArray1[index1];
          num1 = numArray1[index1];
          num2 = 0L;
        }

      for (var index = 0; index < num2; ++index)
        numArray1[index] = num1;
    }

    var strArray = numArray1.Select(x => x.ToString()).ToArray();
    var last = strArray.Last();
    var lastIndex = strArray.Length - 1;
    strArray[lastIndex] = pricePerOne.ToString();
    var msg = string.Join("-", strArray);
    return CommonResult.Success(msg);
  }

  public CommonResult GetMyWaitNoticeList(long userNo,
                                          string certifiedKey,
                                          int type) {
    var user = TradeAuthService.AuthenticateForGame(userNo, certifiedKey);
    // var commonDbResult2 = TradeDbWrapper.WorldMarketMyWaitNoticeList(user.nationCode, user.worldNo, user.userNo);
    var dbResult = _tradeDbContext.WorldMarketMyWaitNoticeList(user.userNo);
    if (!dbResult.Status) {
      return dbResult.ToCommonResult();
    }

    var list = dbResult.Data;
    var resultMsg = "";
    if (list.Count == 0)
      resultMsg = "0";
    else
      for (var index = 0; index < list.Count; ++index) {
        var num1 = 0;
        long num2 = 0;
        if (1 == list[index]._usedType)
          num1 = 1;
        if (2 == list[index]._usedType)
          num2 = 1L;
        if (3 == list[index]._usedType)
          num2 = 2L;
        resultMsg = Convert.ToString(list[index]._mainKey) + "-" + Convert.ToString(list[index]._chooseSubKey) + "-" + Convert.ToString(1) + "-" +
                    Convert.ToString(list[index]._pricePerOne) + "-" + Convert.ToString(num1) + "-" + Convert.ToString(list[index]._resultMoneyCount) + "-" +
                    Convert.ToString(num2) + "-" + Convert.ToString(false) + "-" + Convert.ToString(list[index]._usedType) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0);
        if (index < list.Count - 1)
          resultMsg += "|";
      }

    return new CommonResult(0, resultMsg);
  }

  [CacheAspect]
  public CommonResult GetWorldMarketWaitList() {
    var commonDbResult = new CommonDBResult<ResultWorldMarketWait>();
    var result = new CommonResult();
    if (StockInfoManger.This.IsUpdateTimeForWaitItemInfo()) {
      var dbResult = _tradeDbContext.ListWorldMarketWait();
      if (!dbResult.Status) {
        return dbResult.ToCommonResult();
      }

      var updateList = dbResult.Data;
      if (!StockInfoManger.This.UpdateByWaitItemInfo(updateList)) {
        result.resultMsg = "0";
        return result;
      }
    }

    var msg = StockInfoManger.This.GetJsonStringForWaitItemInfo();
    return CommonResult.Success(msg);
  }
}