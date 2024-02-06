using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.EfCore;
using BlackDesert.Trade.Domain.Models.Process;

namespace BlackDesert.Trade.Business.Services.Common;

public sealed class TradeProcessService
{
  private readonly TradeDbContext _tradeDbContext;

  public TradeProcessService(TradeDbContext tradeDbContext) {
    _tradeDbContext = tradeDbContext;
  }

  private static int _currentIndex;

  
  public DbResult<long> SetMarketItemProcess(ProcessTradeMarketItemInfoModel model) {
    var operationType = OperationType.eWorldMarket_OperationType_Item;
    // var tradeMarketItemInfo1 = new ProcessTradeMarketItemInfoModel();
    // var data = new ProcessTradeMarketPayload();
    TradeMarketItemInfo tradeMarketItemInfo3;
    tradeMarketItemInfo3 = ItemInfoManager.This.GetInfo(model.mainKey, model.subKey);
    if (!tradeMarketItemInfo3.IsValid() && 1 != model.mainKey) {
      LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.mainKey, model.subKey), "WARN");
      return DbResult< long>.Error(8, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue()) ;
    }

    //TODO CHECK DİSABLED MAX STACK
    // if (tradeMarketItemInfo3._maxStackCount < model.count && 1 != model.mainKey) {
    //   
    //   LogUtil.WriteLog(string.Format("[Item Error]SetMarketItemProcess({0}) itemInfo({1}, {2}) ItemStack is Invalid", model, model.mainKey, model.subKey), "WARN");
    //   data.result.resultCode = 16;
    //   data.result.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemStack.GetResourceValue();
    //   return data;
    // }

    var resPrepareDepositToWorldMarket=  _tradeDbContext.PrepareDepositToWorldMarket(model.nationCode,
                                                                                     model.serverNo,
                                                                                     model.userNo,
                                                                                     model.keyType,
                                                                                     model.mainKey,
                                                                                     model.subKey,
                                                                                     model.param0,
                                                                                     model.param1,
                                                                                     model.param2,
                                                                                     model.param3,
                                                                                     model.param4,
                                                                                     model.count,
                                                                                     model.isSealed,
                                                                                     tradeMarketItemInfo3._weight,
                                                                                     OptionManager.This.GetMaxWeight());
    if ( !resPrepareDepositToWorldMarket.Status) {
      return resPrepareDepositToWorldMarket;
    }
    WorldMarketLogger.LogWorldMarket(operationType,
                                     LogReasonType.eWorldMarket_ReasonType_Push,
                                     CultureModule.GetCustomTimeNow(),
                                     new CommonModel.TradeMarketUserLogInfo {
                                       nationCode = model.nationCode,
                                       serverNo = model.serverNo,
                                       userNo = model.userNo
                                     },
                                     new CommonModel.TradeMarketItemLogInfo {
                                       keyType1 = model.keyType,
                                       itemKey1 = model.mainKey,
                                       enchantLevel1 = model.subKey,
                                       count1 = model.count
                                     },
                                     0,
                                     model.param0,
                                     model.param1,
                                     model.param2,
                                     model.param3,
                                     model.param4,
                                     Convert.ToInt64(model.isSealed));
    return resPrepareDepositToWorldMarket;
  }

  public ProcessTradeMarketIncludePayloadModel RegisterMarketItemProcess(ProcessTradeMarketIncludePayloadModel model) {
    var empty1 = string.Empty;
    var data1 = new ProcessTradeMarketIncludePayloadModel();
    var num = 0;
    long? beforeCount1 = 0;
    long? afterCount1 = 0;
    var operationType = OperationType.eWorldMarket_OperationType_End;
    try {
      TradeDbManager.This.uspProcessDepositToWorldMarket(model.payload,
                                                         out var reason,
                                                         out var keyType,
                                                         out var mainKey,
                                                         out var subKey,
                                                         out var isSealed,
                                                         out var objectParameter1,
                                                         out var objectParameter2,
                                                         out var objectParameter3,
                                                         out var objectParameter4,
                                                         out var objectParameter5,
                                                         out var count,
                                                         out beforeCount1,
                                                         out afterCount1,
                                                         out var symNo,
                                                         out var rv);
      var int32 = Convert.ToInt32(rv);
      var textParam1 = Convert.ToString(symNo);
      num = Convert.ToInt32(reason);
      if (keyType != 0) throw new NotImplementedException();
      operationType = OperationType.eWorldMarket_OperationType_Item;
      if (int32 != 0) {
        WorldMarketLogger.LogWorldMarket(operationType,
                                         LogReasonType.eWorldMarket_ReasonType_Fail_Push,
                                         CultureModule.GetCustomTimeNow(),
                                         new CommonModel.TradeMarketUserLogInfo {
                                           nationCode = model.nationCode,
                                           serverNo = model.serverNo,
                                           userNo = model.userNo
                                         },
                                         new CommonModel.TradeMarketItemLogInfo {
                                           keyType1 = model.keyType,
                                           itemKey1 = model.mainKey,
                                           enchantLevel1 = model.subKey,
                                           count1 = model.count,
                                           beforeCount1 = 0L,
                                           afterCount1 = 0L
                                         },
                                         model.payload,
                                         int32,
                                         model.param0,
                                         model.param1,
                                         model.param2,
                                         model.param3,
                                         model.param4,
                                         textParam1: textParam1);
        LogUtil.WriteLog(string.Format("[DB Error]RegisterMarketItemProcess() - uspProcessDepositToWorldMarket({0}), rv({1})", model, int32), "WARN");
        model.result.resultCode = int32;
        model.result.resultMsg = textParam1;
        return model;
      }

      model.keyType = Convert.ToInt32(keyType);
      model.mainKey = Convert.ToInt32(mainKey);
      model.subKey = Convert.ToInt32(subKey);
      model.param0 = Convert.ToInt64(objectParameter1);
      model.param1 = Convert.ToInt64(objectParameter2);
      model.param2 = Convert.ToInt64(objectParameter3);
      model.param3 = Convert.ToInt64(objectParameter4);
      model.param4 = Convert.ToInt64(objectParameter5);
      model.count = Convert.ToInt64(count);
      model.isSealed = Convert.ToBoolean(isSealed);
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]RegisterMarketItemProcess() - uspProcessDepositToWorldMarket({0}) Exception : {1}", model, ex), "ERROR");
      model.result.resultCode = 1;
      return model;
    }

    var userInfo = new CommonModel.TradeMarketUserLogInfo();
    userInfo.nationCode = model.nationCode;
    userInfo.serverNo = model.serverNo;
    userInfo.userNo = model.userNo;
    var itemInfo = new CommonModel.TradeMarketItemLogInfo();
    itemInfo.keyType1 = model.keyType;
    itemInfo.itemKey1 = model.mainKey;
    itemInfo.enchantLevel1 = model.subKey;
    itemInfo.count1 = model.count;
    itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1);
    itemInfo.afterCount1 = Convert.ToInt64(beforeCount1);
    WorldMarketLogger.LogWorldMarket(operationType,
                                     LogReasonType.eWorldMarket_ReasonType_Push,
                                     CultureModule.GetCustomTimeNow(),
                                     userInfo,
                                     itemInfo,
                                     model.payload,
                                     1L,
                                     num,
                                     model.param0,
                                     model.param1,
                                     model.param2,
                                     model.param3,
                                     Convert.ToInt64(model.isSealed));
    if (model.isRestoration)
      WorldMarketLogger.LogWorldMarket(operationType,
                                       LogReasonType.eWorldMarket_ReasonType_Restoration,
                                       CultureModule.GetCustomTimeNow(),
                                       userInfo,
                                       itemInfo,
                                       model.payload,
                                       num,
                                       param4: model.param0,
                                       param5: model.param1,
                                       param6: model.param2,
                                       param7: model.param3,
                                       param8: model.param4);
    return model;
  }

  public ProcessTradeMarketIncludePayloadModel PreWithdrawItemProcess(ProcessTradeMarketItemInfoModel model) {
    if (model.keyType != 0) throw new NotImplementedException();
    var empty1 = string.Empty;
    var tradeMarketItemInfo1 = new ProcessTradeMarketItemInfoModel();
    var data = new ProcessTradeMarketIncludePayloadModel();
    OperationType operationType;
    TradeMarketItemInfo tradeMarketItemInfo3;
    operationType = OperationType.eWorldMarket_OperationType_Item;
    tradeMarketItemInfo3 = ItemInfoManager.This.GetInfo(model.mainKey, model.subKey);
    if (!tradeMarketItemInfo3.IsValid() && 1 != model.mainKey) {
      LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.mainKey, model.subKey), "WARN");
      data.result.resultCode = 8;
      data.result.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    //TODO CHECK DİSABLED MAX STACK CHECK
    // if (tradeMarketItemInfo3._maxStackCount < model.count && 1 != model.mainKey) {
    //   LogUtil.WriteLog(string.Format("[Item Error]PreWithdrawItemProcess({0}) itemInfo({1}, {2}) ItemStack is Invalid", model, model.mainKey, model.subKey), "WARN");
    //   data.result.resultCode = 16;
    //   data.result.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemStack.GetResourceValue();
    //   return data;
    // }

    try {
      TradeDbManager.This.uspPrepareWithdrawFromWorldMarket(model.nationCode,
                                                            model.serverNo,
                                                            model.userNo,
                                                            model.keyType,
                                                            model.mainKey,
                                                            model.subKey,
                                                            model.isSealed,
                                                            model.count,
                                                            tradeMarketItemInfo3._weight,
                                                            out var payload,
                                                            out var objectParameter1,
                                                            out var objectParameter2,
                                                            out var objectParameter3,
                                                            out var objectParameter4,
                                                            out var objectParameter5,
                                                            out var symNo,
                                                            out var rv);
      var int32 = Convert.ToInt32(rv);
      var str = Convert.ToString(symNo);
      if (int32 != 0) {
        LogUtil.WriteLog(string.Format("[DB Error]PreWithdrawItemProcess - uspPrepareWithdrawFromWorldMarket({0}), rv({1})", model, int32), "WARN");
        data.result.resultCode = int32;
        data.result.resultMsg = str;
        return data;
      }

      data.payload = Convert.ToInt64(payload);
      data.param0 = Convert.ToInt64(objectParameter1);
      data.param1 = Convert.ToInt64(objectParameter2);
      data.param2 = Convert.ToInt64(objectParameter3);
      data.param3 = Convert.ToInt64(objectParameter4);
      data.param4 = Convert.ToInt64(objectParameter5);
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]PreWithdrawItemProcess() - uspPrepareWithdrawFromWorldMarket({0}) Exception : {1}", model, ex), "ERROR");
      data.result.resultCode = 1;
      return data;
    }

    WorldMarketLogger.LogWorldMarket(operationType,
                                     LogReasonType.eWorldMarket_ReasonType_Pop,
                                     CultureModule.GetCustomTimeNow(),
                                     new CommonModel.TradeMarketUserLogInfo {
                                       nationCode = model.nationCode,
                                       serverNo = model.serverNo,
                                       userNo = model.userNo
                                     },
                                     new CommonModel.TradeMarketItemLogInfo {
                                       keyType1 = model.keyType,
                                       itemKey1 = model.mainKey,
                                       enchantLevel1 = model.subKey,
                                       count1 = model.count
                                     },
                                     data.payload,
                                     data.param0,
                                     data.param1,
                                     data.param2,
                                     data.param3,
                                     data.param4,
                                     Convert.ToInt64(model.isSealed));
    return data;
  }


 public DbResult<List<ResultWorldMarketCurrentPrice>> UpdateCurrentPriceProcess() {
   var data = new CommonDBResult<ResultWorldMarketCurrentPrice>();
   var nextCategory = CategoryInfoManager.This.GetNextCategory(ref _currentIndex);
   return _tradeDbContext.ListWorldMarketCurrentPrice(nextCategory.Key, nextCategory.Value);
 }


  public ProcessTradeMarketIncludePayloadModel CompleteWithdrawItemProcess(ProcessTradeMarketIncludePayloadModel model) {
    if (model.keyType != 0) throw new NotImplementedException();
    var empty1 = string.Empty;
    var data1 = new ProcessTradeMarketIncludePayloadModel();

    var operationType = OperationType.eWorldMarket_OperationType_Item;
    var num = 0;
    long? beforeCount1 = 0;
    long? afterCount1 = 0;
    try {
      TradeDbManager.This.uspProcessWithdrawFromWorldMarket(model.payload,
                                                            out var reason,
                                                            out beforeCount1,
                                                            out afterCount1,
                                                            out var symNo,
                                                            out var rv);
      var int32 = Convert.ToInt32(rv);
      var textParam1 = Convert.ToString(symNo);
      num = Convert.ToInt32(reason);
      if (int32 != 0) {
        WorldMarketLogger.LogWorldMarket(operationType,
                                         LogReasonType.eWorldMarket_ReasonType_Fail_Pop,
                                         CultureModule.GetCustomTimeNow(),
                                         new CommonModel.TradeMarketUserLogInfo {
                                           nationCode = model.nationCode,
                                           serverNo = model.serverNo,
                                           userNo = model.userNo
                                         },
                                         new CommonModel.TradeMarketItemLogInfo {
                                           keyType1 = model.keyType,
                                           itemKey1 = model.mainKey,
                                           enchantLevel1 = model.subKey,
                                           count1 = model.count,
                                           beforeCount1 = 0L,
                                           afterCount1 = 0L
                                         },
                                         model.payload,
                                         int32,
                                         model.param0,
                                         model.param1,
                                         model.param2,
                                         model.param3,
                                         model.param4,
                                         textParam1: textParam1);
        LogUtil.WriteLog(string.Format("[DB Error]CompleteWithdrawItemProcess - uspProcessWithdrawFromWorldMarket({0}), rv({1})", model, int32), "WARN");
        model.result.resultCode = int32;
        model.result.resultMsg = textParam1;
        return model;
      }
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]CompleteWithdrawItemProcess() - uspProcessWithdrawFromWorldMarket({0}) Exception : {1}", model, ex), "ERROR");
      model.result.resultCode = 1;
      return model;
    }

    WorldMarketLogger.LogWorldMarket(operationType,
                                     LogReasonType.eWorldMarket_ReasonType_Pop,
                                     CultureModule.GetCustomTimeNow(),
                                     new CommonModel.TradeMarketUserLogInfo {
                                       nationCode = model.nationCode,
                                       serverNo = model.serverNo,
                                       userNo = model.userNo
                                     },
                                     new CommonModel.TradeMarketItemLogInfo {
                                       keyType1 = model.keyType,
                                       itemKey1 = model.mainKey,
                                       enchantLevel1 = model.subKey,
                                       count1 = model.count,
                                       beforeCount1 = Convert.ToInt64(beforeCount1),
                                       afterCount1 = Convert.ToInt64(afterCount1)
                                     },
                                     model.payload,
                                     1L,
                                     num,
                                     model.param0,
                                     model.param1,
                                     model.param2,
                                     model.param3,
                                     Convert.ToInt64(model.isSealed));
    return model;
  }


  public CommonResult BuyItemProcess(ProcessTradeMarketBuyInfo model) {
    if (model.buyKeyType != 0) throw new NotImplementedException();
    var data = new CommonResult();
    var empty1 = string.Empty;
    var unitPrice = VariedPriceInfoManager.This.GetUnitPrice(model.buyPrice);
    // var num1 = model.buyPrice % unitPrice;
    var isValidPrice = model.buyPrice % unitPrice == 0; 
    if (!isValidPrice) {
      LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) buyPrice Check Fail unitPrice({1} divide {2}", model, unitPrice, model.buyPrice % unitPrice), "WARN");
      data.resultCode = 14;
      data.resultMsg = MarketError.TRADE_MARKET_ERROR_MSG_PRICE_WORNG.GetResourceValue();
      return data;
    }

    var xmlItemInfo = ItemInfoManager.This.GetInfo(model.buyMainKey, model.buyChooseKey);
    if (!xmlItemInfo.IsValid()) {
      LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.buyMainKey, model.buyChooseKey), "WARN");
      data.resultCode = 8;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    if (xmlItemInfo._maxRegisterForWorldMarket < model.buyCount) {
      LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) buyCount({1}) Process Count Over", model, model.buyCount), "WARN");
      data.resultCode = 20;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemCountOver.GetResourceValue();
      return data;
    }

    var enchantMaxGroup1 = ItemInfoManager.This.GetEnchantMaxGroup(model.buyMainKey, xmlItemInfo._enchantGroup);
    if (xmlItemInfo._enchantGroup > model.buyChooseKey || model.buyChooseKey > enchantMaxGroup1) {
      LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", model, model.buyMainKey, xmlItemInfo._enchantGroup),
                       "WARN");
      data.resultCode = 9;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup.GetResourceValue();
      return data;
    }

    var enchantMaterialKey = xmlItemInfo._enchantMaterialKey;
    if (model.buyChooseKey == 0 && enchantMaxGroup1 != 0) {
      var info2 = ItemInfoManager.This.GetInfo(model.buyMainKey, 1);
      if (!info2.IsValid()) {
        LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.buyMainKey, model.buyChooseKey), "WARN");
        data.resultCode = 8;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
        return data;
      }

      enchantMaterialKey = info2._enchantMaterialKey;
    }

    var tradeMarketItemInfo = new TradeMarketItemInfo();
    if (enchantMaterialKey != 0) {
      tradeMarketItemInfo = ItemInfoManager.This.GetInfo(enchantMaterialKey, 0);
      if (!xmlItemInfo.IsValid()) {
        LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) itemInfo({1}, 0) Not Exist Material ItemInfo", model, enchantMaterialKey), "WARN");
        data.resultCode = 8;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
        return data;
      }
    }

    if (model.buySubKey != model.buyChooseKey) {
      var info3 = ItemInfoManager.This.GetInfo(model.buyMainKey, model.buySubKey);
      if (!info3.IsValid()) {
        LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) baseitemInfo({1}, {2}) Not Exist ItemInfo", model, model.buyMainKey, model.buySubKey), "WARN");
        data.resultCode = 8;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
        return data;
      }

      var enchantMaxGroup2 = ItemInfoManager.This.GetEnchantMaxGroup(model.buyMainKey, info3._enchantGroup);
      if (info3._enchantGroup > model.buyChooseKey || model.buyChooseKey > enchantMaxGroup2) {
        LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) getEnchantBaseMaxGroup({1}, {2}) Group : Out Of Range", model, model.buyMainKey, info3._enchantGroup),
                         "WARN");
        data.resultCode = 9;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup.GetResourceValue();
        return data;
      }
    }

    var buyCount = model.buyCount;
    long num2 = 0;
    long num3 = 0;
    var num4 = 0;
    string symNo;
    int rv;
    var customTime = CultureModule.GetCustomTimeNow();
    var userInfo = new CommonModel.TradeMarketUserLogInfo();
    userInfo.nationCode = model.nationCode;
    userInfo.serverNo = model.worldNo;
    userInfo.userNo = model.userNo;
    var itemInfo = new CommonModel.TradeMarketItemLogInfo();
    itemInfo.keyType1 = model.buyKeyType;
    itemInfo.itemKey1 = model.buyMainKey;
    itemInfo.enchantLevel1 = model.buySubKey;
    itemInfo.keyType2 = 0;
    itemInfo.itemKey2 = 1;
    itemInfo.enchantLevel2 = 0;
    var sellUserIdList = new List<string>();
    try {
      var resCheckAndUpdateBlackUser = _tradeDbContext.CheckAndUpdateBlackUser(model.userNo);
      if (!resCheckAndUpdateBlackUser.Status) {
        return resCheckAndUpdateBlackUser.ToCommonResult();
      }
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspCheckAndUpdateBlackUser({0}/{1}) Exception : {2}", model, buyCount, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    var num5 = 0;
    var flag1 = false;
    long? walletMoney = 0;
    long? realBuyCount = 0;
    long? totalMoneyCount = 0;
    long? sellNo = 0;
    long? sellUserNo = 0;
    long? sellUserId = 0;
    long? sellLeftCount = 0;
    long? raceCount = 0;
    int? stopType = 0;
    long? beforeCount1 = 0;
    long? afterCount1 = 0;
    long? beforeCount2 = 0;
    long? afterCount2 = 0;
    long? beforeCount = 0;
    long? beforeCount3 = 0;
    long? afterCount3 = 0;
    long? beforeCount4 = 0;
    long? afterCount4 = 0;
    long? leftCount = 0;
    long? registerMoneyCount = 0;
    long? boughtCount = 0;

    while (0L < buyCount)
      try {
        TradeDbManager.This.uspBuyBiddingFromWorldMarket(model.nationCode,
                                                         model.worldNo,
                                                         model.userNo,
                                                         model.buyKeyType,
                                                         model.buyMainKey,
                                                         model.buySubKey,
                                                         model.buyPrice,
                                                         buyCount,
                                                         model.buyChooseKey,
                                                         tradeMarketItemInfo._mainKey,
                                                         xmlItemInfo._enchantNeedCount,
                                                         OptionManager.This.BiddingRatio,
                                                         xmlItemInfo._weight,
                                                         OptionManager.This.GetMaxWeight() * OptionManager.This.GetMaxWeightRate(),
                                                         num5 == 0
                                                           ? model.retryBiddingNo
                                                           : 0L,
                                                         out walletMoney,
                                                         out realBuyCount,
                                                         out totalMoneyCount,
                                                         out sellNo,
                                                         out sellUserNo,
                                                         out sellUserId,
                                                         out sellLeftCount,
                                                         out raceCount,
                                                         out stopType,
                                                         out beforeCount1,
                                                         out afterCount1,
                                                         out beforeCount2,
                                                         out afterCount2,
                                                         out beforeCount3,
                                                         out afterCount3,
                                                         out beforeCount4,
                                                         out afterCount4,
                                                         out leftCount,
                                                         out registerMoneyCount,
                                                         out boughtCount,
                                                         out symNo,
                                                         out rv);
        data.resultCode = Convert.ToInt32(rv);
        var int64_1 = Convert.ToInt64(sellUserNo);
        var textParam1 = Convert.ToString(sellUserId);
        var int32 = (StopReasonType)Convert.ToInt32(stopType);
        if (data.resultCode == 0) {
          if (StopReasonType.eStopReasonType_Empty != int32) {
            if (StopReasonType.eStopReasonType_Fail == int32) {
              if (5 == num4) {
                LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}/{1}) Fail BuyBidding", model, buyCount), "WARN");
                data.resultCode = 11;
                data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_BuyBiddingRepeatOverFail.GetResourceValue();
                return data;
              }

              ++num4;
            }
            else if (int32 == StopReasonType.eStopReasonType_Normal) {
              var int64_2 = Convert.ToInt64(realBuyCount);
              var int64_3 = Convert.ToInt64(totalMoneyCount);
              var int64_4 = Convert.ToInt64(sellNo);
              Convert.ToInt64(walletMoney);
              buyCount -= int64_2;
              num2 += int64_2;
              num3 += int64_3;
              if (num5 == 0 && 0L < model.retryBiddingNo) {
                var int64_5 = Convert.ToInt64(boughtCount);
                var int64_6 = Convert.ToInt64(beforeCount1);
                var int64_7 = Convert.ToInt64(afterCount1);
                Convert.ToInt64(leftCount);
                var int64_8 = Convert.ToInt64(registerMoneyCount);
                var int64_9 = Convert.ToInt64(beforeCount2);
                var int64_10 = Convert.ToInt64(afterCount2);
                if (0L < Convert.ToInt64(boughtCount)) {
                  itemInfo.count1 = int64_5;
                  itemInfo.beforeCount1 = int64_6;
                  itemInfo.afterCount1 = int64_7;
                  itemInfo.count2 = 0L;
                  itemInfo.beforeCount2 = 0L;
                  itemInfo.afterCount2 = 0L;
                  WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                                   LogReasonType.eWorldMarket_ReasonType_BiddingBuyCalculate,
                                                   CultureModule.GetCustomTimeNow(),
                                                   userInfo,
                                                   itemInfo,
                                                   model.retryBiddingNo,
                                                   1L,
                                                   model.buyChooseKey,
                                                   Convert.ToInt64(model.isWebAccess));
                }

                if (0L < int64_8) {
                  itemInfo.count1 = Convert.ToInt64(leftCount);
                  itemInfo.beforeCount1 = 0L;
                  itemInfo.afterCount1 = 0L;
                  itemInfo.count2 = int64_8;
                  itemInfo.beforeCount2 = int64_9;
                  itemInfo.afterCount2 = int64_10;
                  WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                                   LogReasonType.eWorldMarket_ReasonType_BiddingBuyWithdraw,
                                                   CultureModule.GetCustomTimeNow(),
                                                   userInfo,
                                                   itemInfo,
                                                   model.retryBiddingNo,
                                                   1L,
                                                   param4: Convert.ToInt64(model.isWebAccess));
                }

                flag1 = true;
              }

              itemInfo.count1 = int64_2;
              itemInfo.beforeCount1 = Convert.ToInt64(beforeCount4);
              itemInfo.afterCount1 = Convert.ToInt64(afterCount4);
              itemInfo.count2 = int64_3;
              itemInfo.beforeCount2 = Convert.ToInt64(beforeCount3);
              itemInfo.afterCount2 = Convert.ToInt64(afterCount3);
              WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                               LogReasonType.eWorldMarket_ReasonType_BuyBidding,
                                               customTime,
                                               userInfo,
                                               itemInfo,
                                               int64_4,
                                               Convert.ToInt64(model.isWebAccess),
                                               model.buyChooseKey,
                                               int64_1,
                                               Convert.ToInt64(raceCount),
                                               model.retryBiddingNo,
                                               textParam1: textParam1);
              ++num5;
              if (Convert.ToInt64(sellLeftCount) == 0L) {
                var str = sellUserId.ToString();
                if (!sellUserIdList.Contains(str))
                  sellUserIdList.Add(str);
              }
            }
            else {
              LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}/{1}) StopReasonType({2}) is Invalid", model, buyCount, (int)int32),
                               "WARN");
              data.resultCode = 10;
              data.resultMsg = Convert.ToString(symNo);
              return data;
            }
          }
          else {
            break;
          }
        }
        else {
          LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}/{1}), rv({2})", model, buyCount, data.resultCode), "WARN");
          data.resultMsg = Convert.ToString(symNo);
          return data;
        }
      }
      catch (Exception ex) {
        LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyBiddingFromWorldMarket({0}/{1}) Exception : {2}", model, buyCount, ex), "ERROR");
        data.resultCode = 1;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
        return data;
      }

    if (!flag1 && 0L < model.retryBiddingNo) {
      var int64_11 = Convert.ToInt64(boughtCount);
      var int64_12 = Convert.ToInt64(beforeCount1);
      var int64_13 = Convert.ToInt64(afterCount1);
      Convert.ToInt64(leftCount);
      var int64_14 = Convert.ToInt64(registerMoneyCount);
      var int64_15 = Convert.ToInt64(beforeCount2);
      var int64_16 = Convert.ToInt64(afterCount2);
      if (0L < Convert.ToInt64(boughtCount)) {
        itemInfo.count1 = int64_11;
        itemInfo.beforeCount1 = int64_12;
        itemInfo.afterCount1 = int64_13;
        itemInfo.count2 = 0L;
        itemInfo.beforeCount2 = 0L;
        itemInfo.afterCount2 = 0L;
        WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                         LogReasonType.eWorldMarket_ReasonType_BiddingBuyCalculate,
                                         CultureModule.GetCustomTimeNow(),
                                         userInfo,
                                         itemInfo,
                                         model.retryBiddingNo,
                                         1L,
                                         model.buyChooseKey,
                                         Convert.ToInt64(model.isWebAccess));
      }

      if (0L < int64_14) {
        itemInfo.count1 = Convert.ToInt64(leftCount);
        itemInfo.beforeCount1 = 0L;
        itemInfo.afterCount1 = 0L;
        itemInfo.count2 = int64_14;
        itemInfo.beforeCount2 = int64_15;
        itemInfo.afterCount2 = int64_16;
        WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                         LogReasonType.eWorldMarket_ReasonType_BiddingBuyWithdraw,
                                         CultureModule.GetCustomTimeNow(),
                                         userInfo,
                                         itemInfo,
                                         model.retryBiddingNo,
                                         1L,
                                         param4: Convert.ToInt64(model.isWebAccess));
      }
    }

    if (buyCount == 0L) {
      data.resultMsg = Convert.ToString(model.buyMainKey) + "-" + Convert.ToString(model.buyChooseKey) + "-" + Convert.ToString(model.buyCount) + "-" + Convert.ToString(model.buyPrice) + "-" +
                       Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.retryBiddingNo);
      Task.Run(() => TradeAlarmService.This.SendAlarm(sellUserIdList, model.buyMainKey, "SELL"));
      return data;
    }

    var flag2 = false;
    if (xmlItemInfo._mainGroupNo == OptionManager.This.GetCashGroupNo())
      flag2 = true;
    try {
      TradeDbManager.This.uspBuyFromWorldMarket(model.nationCode,
                                                model.worldNo,
                                                model.userNo,
                                                model.buyKeyType,
                                                model.buyMainKey,
                                                model.buySubKey,
                                                model.buyPrice,
                                                buyCount,
                                                model.buyChooseKey,
                                                tradeMarketItemInfo._mainKey,
                                                xmlItemInfo._enchantNeedCount,
                                                OptionManager.This.BiddingRatio,
                                                flag2,
                                                xmlItemInfo._weight,
                                                OptionManager.This.GetMaxWeight() * OptionManager.This.GetMaxWeightRate(),
                                                out realBuyCount,
                                                out totalMoneyCount,
                                                out var buyNo,
                                                out var biddingMoneyCount,
                                                out beforeCount1,
                                                out afterCount1,
                                                out beforeCount2,
                                                out afterCount2,
                                                out symNo,
                                                out rv);
      data.resultCode = Convert.ToInt32(rv);
      if (data.resultCode == 0) {
        var int64_17 = Convert.ToInt64(realBuyCount);
        var int64_18 = Convert.ToInt64(totalMoneyCount);
        var int64_19 = Convert.ToInt64(biddingMoneyCount);
        var int64_20 = Convert.ToInt64(buyNo);
        var num6 = num2 + int64_17;
        var num7 = num3 + int64_18;
        if (num6 == 0L && int64_20 == 0L) {
          LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess({0}) ReserveBiddingFail", model), "WARN");
          data.resultCode = 22;
          data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ReserveBuyBiddingFail.GetResourceValue();
          return data;
        }

        data.resultMsg = Convert.ToString(model.buyMainKey) + "-" + Convert.ToString(model.buyChooseKey) + "-" + Convert.ToString(model.buyCount) + "-" + Convert.ToString(model.buyPrice) + "-" +
                         Convert.ToString(num6) + "-" + Convert.ToString(num7) + "-" + Convert.ToString(int64_19) + "-" + Convert.ToString(int64_20) + "-" + Convert.ToString(model.retryBiddingNo);
        var num8 = int64_18 - int64_19;
        if (0L < int64_17) {
          itemInfo.count1 = int64_17;
          itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1);
          itemInfo.afterCount1 = Convert.ToInt64(afterCount1);
          itemInfo.count2 = num8;
          itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2);
          itemInfo.afterCount2 = Convert.ToInt64(afterCount2);
          WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                           LogReasonType.eWorldMarket_ReasonType_Buy,
                                           customTime,
                                           userInfo,
                                           itemInfo,
                                           model.buyChooseKey,
                                           Convert.ToInt64(model.isWebAccess),
                                           model.retryBiddingNo);
        }

        if (int64_20 != 0L) {
          itemInfo.count1 = buyCount - int64_17;
          itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1);
          itemInfo.afterCount1 = Convert.ToInt64(afterCount1);
          itemInfo.count2 = int64_19;
          itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2);
          itemInfo.afterCount2 = Convert.ToInt64(afterCount2);
          WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                           LogReasonType.eWorldMarket_ReasonType_BiddingBuyRegister,
                                           customTime,
                                           userInfo,
                                           itemInfo,
                                           int64_20,
                                           Convert.ToInt64(model.isWebAccess),
                                           model.retryBiddingNo);
        }

        Task.Run(() => TradeAlarmService.This.SendAlarm(sellUserIdList, model.buyMainKey, "SELL"));
        return data;
      }

      if (0L < num2) {
        data.resultCode = 0;
        data.resultMsg = Convert.ToString(model.buyMainKey) + "-" + Convert.ToString(model.buyChooseKey) + "-" + Convert.ToString(model.buyCount) + "-" + Convert.ToString(model.buyPrice) + "-" +
                         Convert.ToString(num2) + "-" + Convert.ToString(num3) + "-" + Convert.ToString(0) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.retryBiddingNo);
        Task.Run(() => TradeAlarmService.This.SendAlarm(sellUserIdList, model.buyMainKey, "SELL"));
        return data;
      }

      LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyFromWorldMarket({0}/{1}), rv({2})", model, buyCount, data.resultCode), "WARN");
      data.resultMsg = Convert.ToString(symNo);
      Task.Run((Action)(() => TradeAlarmService.This.SendAlarm(sellUserIdList, model.buyMainKey, "SELL")));
      return data;
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyFromWorldMarket({0}/{1}) Exception : {2}", model, buyCount, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }
  }


  public CommonResult SellItemProcess(ProcessTradeMarketSellInfo model) {
    if (model.sellKeyType != 0) throw new NotImplementedException();
    var data = new CommonResult();
    byte num1 = 2;
    long num2 = 0;

    var unitPrice = VariedPriceInfoManager.This.GetUnitPrice(model.sellPrice);
    var num3 = model.sellPrice % unitPrice;
    if (num3 != 0L) {
      LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) sellPrice Check Fail unitPrice({1} divide EfCore {2}", model, unitPrice, num3), "WARN");
      data.resultCode = 14;
      data.resultMsg = MarketError.TRADE_MARKET_ERROR_MSG_PRICE_WORNG.GetResourceValue();
      return data;
    }

    var info1 = ItemInfoManager.This.GetInfo(model.sellMainKey, model.sellChooseKey);
    if (!info1.IsValid()) {
      LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.sellMainKey, model.sellChooseKey), "WARN");
      data.resultCode = 8;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    var num4 = info1._maxRegisterForWorldMarket * 10L;
    if (info1._mainGroupNo == OptionManager.This.GetCashGroupNo())
      num4 = 100L;
    if (num4 < model.sellCount) {
      LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) sellCount({1}) Process Count Over", model, model.sellCount), "WARN");
      data.resultCode = 20;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ItemCountOver.GetResourceValue();
      return data;
    }

    var tradeMarketItemInfo = new TradeMarketItemInfo();
    if (info1._enchantMaterialKey != 0) {
      tradeMarketItemInfo = ItemInfoManager.This.GetInfo(info1._enchantMaterialKey, 0);
      if (!info1.IsValid()) {
        LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) itemInfo({1}, 0) Not Exist Material ItemInfo", model, info1._enchantMaterialKey), "WARN");
        data.resultCode = 8;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
        return data;
      }
    }

    var enchantMaxGroup1 = ItemInfoManager.This.GetEnchantMaxGroup(model.sellMainKey, info1._enchantGroup);
    if (info1._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup1) {
      LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range", model, model.sellMainKey, info1._enchantGroup),
                       "WARN");
      data.resultCode = 9;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup.GetResourceValue();
      return data;
    }

    if (model.sellSubKey != model.sellChooseKey) {
      var info2 = ItemInfoManager.This.GetInfo(model.sellMainKey, model.sellSubKey);
      if (!info2.IsValid()) {
        LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) baseitemInfo({1}, {2}) Not Exist ItemInfo", model, model.sellMainKey, model.sellSubKey), "WARN");
        data.resultCode = 8;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
        return data;
      }

      var enchantMaxGroup2 = ItemInfoManager.This.GetEnchantMaxGroup(model.sellMainKey, info2._enchantGroup);
      if (info2._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup2) {
        LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) getEnchantBaseMaxGroup({1}, {2}) Group : Out Of Range", model, model.sellMainKey, info2._enchantGroup),
                         "WARN");
        data.resultCode = 9;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItemGroup.GetResourceValue();
        return data;
      }
    }

    var userInfo = new CommonModel.TradeMarketUserLogInfo();
    userInfo.nationCode = model.nationCode;
    userInfo.serverNo = model.worldNo;
    userInfo.userNo = model.userNo;
    var itemInfo = new CommonModel.TradeMarketItemLogInfo();
    itemInfo.keyType1 = model.sellKeyType;
    itemInfo.itemKey1 = model.sellMainKey;
    itemInfo.enchantLevel1 = model.sellSubKey;
    itemInfo.keyType2 = 0;
    itemInfo.itemKey2 = 1;
    itemInfo.enchantLevel2 = 0;
    long num5 = 0;
    var buyUserIdList = new List<string>();
    try {
      var resCheckAndUpdateBlackUser=  _tradeDbContext.CheckAndUpdateBlackUser(model.userNo);
      if (!resCheckAndUpdateBlackUser.Status) {
        return resCheckAndUpdateBlackUser.ToCommonResult();
      }
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspCheckAndUpdateBlackUser({0}) Exception : {1}", model, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    var sellCount = model.sellCount;
    long num6 = 0;
    long num7 = 0;
    var customTime = CultureModule.GetCustomTimeNow();
    var num8 = 0;
    var flag1 = false;
    if (info1._mainGroupNo == OptionManager.This.GetCashGroupNo())
      flag1 = true;
    if (model.isRingBuff && info1._mainGroupNo != OptionManager.This.GetCashGroupNo())
      num1 = 0;
    var num9 = 0;
    var flag2 = false;

    long? walletMoney = 0;
    long? realSellCount = 0;
    long? totalMoneyCount = 0;
    long? originalTotalMoneyCount = 0;
    DateTime? packageExpiration = DateTime.MinValue;
    long? buyNo = 0;
    long? buyUserNo = 0;
    long? buyUserId = 0;
    long? buyLeftCount = 0;
    int? stopType = 0;
    bool? isNextApplyRingBuff = false;
    long? resultWaitNo = 0;
    long? raceCount = 0;
    long? beforeCount1 = 0;
    long? afterCount1 = 0;
    long? beforeCount2 = 0;
    long? afterCount2 = 0;
    long? beforeCount3 = 0;
    long? afterCount3 = 0;
    long? beforeCount4 = 0;
    long? afterCount4 = 0;
    long? soldCount = 0;
    long? leftCount = 0;
    long? moneyCount = 0;
    long? calculateMoney = 0;
    bool? isCalculateRingBuff = false;
    // string symNo = string.Empty;
    // int rv = 0;

    while (0L < sellCount)
      try {
        TradeDbManager.This.uspSellBiddingToWorldMarket(model.nationCode,
                                                        model.worldNo,
                                                        model.userNo,
                                                        model.sellKeyType,
                                                        model.sellMainKey,
                                                        model.sellSubKey,
                                                        info1._mainGroupNo,
                                                        model.isSealed,
                                                        model.sellPrice,
                                                        sellCount,
                                                        model.sellChooseKey,
                                                        tradeMarketItemInfo._mainKey,
                                                        info1._enchantNeedCount,
                                                        OptionManager.This.BiddingRatio,
                                                        flag1,
                                                        info1._weight,
                                                        OptionManager.This.GetMaxWeight() * OptionManager.This.GetMaxWeightRate(),
                                                        OptionManager.This.GetPearlItemLimitedMaxCount(),
                                                        customTime,
                                                        num1,
                                                        num2,
                                                        model.isRingBuff,
                                                        num9 == 0
                                                          ? model.retryBiddingNo
                                                          : 0L,
                                                        out walletMoney,
                                                        out realSellCount,
                                                        out totalMoneyCount,
                                                        out originalTotalMoneyCount,
                                                        out packageExpiration,
                                                        out buyNo,
                                                        out buyUserNo,
                                                        out buyUserId,
                                                        out buyLeftCount,
                                                        out stopType,
                                                        out isNextApplyRingBuff,
                                                        out resultWaitNo,
                                                        out raceCount,
                                                        out beforeCount1,
                                                        out afterCount1,
                                                        out beforeCount2,
                                                        out afterCount2,
                                                        out beforeCount3,
                                                        out afterCount3,
                                                        out beforeCount4,
                                                        out afterCount4,
                                                        out soldCount,
                                                        out leftCount,
                                                        out moneyCount,
                                                        out calculateMoney,
                                                        out isCalculateRingBuff,
                                                        out var symNo,
                                                        out var rv);
        data.resultCode = Convert.ToInt32(rv);
        var int32 = (StopReasonType)Convert.ToInt32(stopType);
        if (data.resultCode == 0) {
          if (StopReasonType.eStopReasonType_Empty != int32) {
            if (StopReasonType.eStopReasonType_Fail == int32) {
              if (5 == num8) {
                LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellBiddingToWorldMarket({0}/{1}) Fail BuyBidding", model, sellCount), "WARN");
                data.resultCode = 13;
                data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_SellBiddingRepeatOverFail.GetResourceValue();
                return data;
              }

              ++num8;
            }
            else if (int32 == StopReasonType.eStopReasonType_Normal) {
              var int64_1 = Convert.ToInt64(realSellCount);
              var int64_2 = Convert.ToInt64(totalMoneyCount);
              var int64_3 = Convert.ToInt64(originalTotalMoneyCount);
              var int64_4 = Convert.ToInt64(buyNo);
              Convert.ToInt64(walletMoney);
              if (num9 == 0 && Convert.ToBoolean(isNextApplyRingBuff))
                num1 = 1;
              sellCount -= int64_1;
              num6 += int64_1;
              num7 += int64_2;
              if (num9 == 0 && 0L < model.retryBiddingNo) {
                var int64_5 = Convert.ToInt64(leftCount);
                var int64_6 = Convert.ToInt64(beforeCount2);
                var int64_7 = Convert.ToInt64(afterCount2);
                var int64_8 = Convert.ToInt64(soldCount);
                num5 = Convert.ToInt64(calculateMoney);
                var int64_9 = Convert.ToInt64(moneyCount);
                var int64_10 = Convert.ToInt64(beforeCount1);
                var int64_11 = Convert.ToInt64(afterCount1);
                var boolean = Convert.ToBoolean(isCalculateRingBuff);
                if (0L < num5) {
                  itemInfo.count1 = 0L;
                  itemInfo.beforeCount1 = 0L;
                  itemInfo.afterCount1 = 0L;
                  itemInfo.count2 = num5;
                  itemInfo.beforeCount2 = int64_10;
                  itemInfo.afterCount2 = int64_11;
                  WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                                   LogReasonType.eWorldMarket_ReasonType_BiddingSellCalculate,
                                                   CultureModule.GetCustomTimeNow(),
                                                   userInfo,
                                                   itemInfo,
                                                   model.retryBiddingNo,
                                                   1L,
                                                   num5,
                                                   Convert.ToInt32(model.isSealed),
                                                   int64_9,
                                                   Convert.ToInt64(model.isWebAccess),
                                                   int64_8,
                                                   Convert.ToInt64(boolean),
                                                   textParam1: packageExpiration.ToString());
                }

                if (0L < int64_5) {
                  itemInfo.count1 = int64_5;
                  itemInfo.beforeCount1 = int64_6;
                  itemInfo.afterCount1 = int64_7;
                  itemInfo.count2 = 0L;
                  itemInfo.beforeCount2 = 0L;
                  itemInfo.afterCount2 = 0L;
                  WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                                   LogReasonType.eWorldMarket_ReasonType_BiddingSellWithdraw,
                                                   customTime,
                                                   userInfo,
                                                   itemInfo,
                                                   model.retryBiddingNo,
                                                   1L,
                                                   model.sellChooseKey,
                                                   Convert.ToInt32(model.isSealed),
                                                   Convert.ToInt64(model.isWebAccess));
                }

                flag2 = true;
              }

              itemInfo.count1 = int64_1;
              itemInfo.beforeCount1 = Convert.ToInt64(beforeCount3);
              itemInfo.afterCount1 = Convert.ToInt64(afterCount3);
              itemInfo.count2 = int64_2;
              itemInfo.beforeCount2 = Convert.ToInt64(beforeCount4);
              itemInfo.afterCount2 = Convert.ToInt64(afterCount4);
              WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                               0L < Convert.ToInt64(resultWaitNo)
                                                 ? LogReasonType.eWorldMarket_ReasonType_SellWait
                                                 : LogReasonType.eWorldMarket_ReasonType_SellBidding,
                                               customTime,
                                               userInfo,
                                               itemInfo,
                                               int64_4,
                                               model.sellChooseKey,
                                               Convert.ToInt64(model.isSealed),
                                               int64_3,
                                               Convert.ToInt64(model.isWebAccess),
                                               Convert.ToInt64(num1),
                                               Convert.ToInt64(resultWaitNo),
                                               Convert.ToInt64(buyUserNo),
                                               Convert.ToInt64(raceCount),
                                               Convert.ToInt64(model.isRingBuff),
                                               model.retryBiddingNo,
                                               textParam1: packageExpiration.ToString());
              ++num9;
              if (0L < int64_4)
                if (Convert.ToInt64(buyLeftCount) == 0L) {
                  var str = buyUserId.ToString();
                  if (!buyUserIdList.Contains(str))
                    buyUserIdList.Add(str);
                }
            }
            else {
              LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellBiddingToWorldMarket({0}/{1}) StopReasonType({2}) is Invalid", model, sellCount, (int)int32),
                               "WARN");
              data.resultCode = 12;
              data.resultMsg = Convert.ToString(symNo);
              return data;
            }
          }
          else {
            break;
          }
        }
        else {
          LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellBiddingToWorldMarket({0}/{1}), rv({2})", model, sellCount, data.resultCode), "WARN");
          data.resultMsg = Convert.ToString(symNo);
          return data;
        }
      }
      catch (Exception ex) {
        LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspSellBiddingToWorldMarket({0}/{1}) Exception : {2}", model, sellCount, ex), "ERROR");
        data.resultCode = 1;
        data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
        return data;
      }

    if (!flag2 && 0L < model.retryBiddingNo) {
      var int64_12 = Convert.ToInt64(leftCount);
      var int64_13 = Convert.ToInt64(beforeCount2);
      var int64_14 = Convert.ToInt64(afterCount2);
      var int64_15 = Convert.ToInt64(soldCount);
      num5 = Convert.ToInt64(calculateMoney);
      var int64_16 = Convert.ToInt64(moneyCount);
      var int64_17 = Convert.ToInt64(beforeCount1);
      var int64_18 = Convert.ToInt64(afterCount1);
      var boolean = Convert.ToBoolean(isCalculateRingBuff);
      if (0L < num5) {
        itemInfo.count1 = 0L;
        itemInfo.beforeCount1 = 0L;
        itemInfo.afterCount1 = 0L;
        itemInfo.count2 = num5;
        itemInfo.beforeCount2 = int64_17;
        itemInfo.afterCount2 = int64_18;
        WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                         LogReasonType.eWorldMarket_ReasonType_BiddingSellCalculate,
                                         CultureModule.GetCustomTimeNow(),
                                         userInfo,
                                         itemInfo,
                                         model.retryBiddingNo,
                                         1L,
                                         num5,
                                         Convert.ToInt32(model.isSealed),
                                         int64_16,
                                         Convert.ToInt64(model.isWebAccess),
                                         int64_15,
                                         Convert.ToInt64(boolean),
                                         textParam1: packageExpiration.ToString());
      }

      if (0L < int64_12) {
        itemInfo.count1 = int64_12;
        itemInfo.beforeCount1 = int64_13;
        itemInfo.afterCount1 = int64_14;
        itemInfo.count2 = 0L;
        itemInfo.beforeCount2 = 0L;
        itemInfo.afterCount2 = 0L;
        WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                         LogReasonType.eWorldMarket_ReasonType_BiddingSellWithdraw,
                                         customTime,
                                         userInfo,
                                         itemInfo,
                                         model.retryBiddingNo,
                                         1L,
                                         model.sellChooseKey,
                                         Convert.ToInt32(model.isSealed),
                                         Convert.ToInt64(model.isWebAccess));
      }
    }

    if (0L < Convert.ToInt64(resultWaitNo)) {
      data.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(model.sellPrice) + "-" +
                       Convert.ToString(0) + "-" + Convert.ToString(0) + "-" + Convert.ToString(3) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" +
                       Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
      return data;
    }

    if (sellCount == 0L) {
      data.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(model.sellPrice) + "-" +
                       Convert.ToString(num6) + "-" + Convert.ToString(num7) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" +
                       Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
      Task.Run(() => TradeAlarmService.This.SendAlarm(buyUserIdList, model.sellMainKey, "BUY"));
      return data;
    }

    try {
      TradeDbManager.This.uspSellToWorldMarket(model.nationCode,
                                               model.worldNo,
                                               model.userNo,
                                               model.sellKeyType,
                                               model.sellMainKey,
                                               model.sellSubKey,
                                               info1._mainGroupNo,
                                               model.isSealed,
                                               model.sellPrice,
                                               sellCount,
                                               model.sellChooseKey,
                                               tradeMarketItemInfo._mainKey,
                                               info1._enchantNeedCount,
                                               OptionManager.This.BiddingRatio,
                                               flag1,
                                               info1._weight,
                                               OptionManager.This.GetPearlItemLimitedMaxCount(),
                                               customTime,
                                               num1,
                                               num2,
                                               out var sellPricePerOne,
                                               out realSellCount,
                                               out totalMoneyCount,
                                               out originalTotalMoneyCount,
                                               out packageExpiration,
                                               out var sellNo,
                                               out var isAppledRingBuff,
                                               out beforeCount1,
                                               out afterCount1,
                                               out beforeCount2,
                                               out afterCount2,
                                               out var symNo,
                                               out var rv);
      data.resultCode = Convert.ToInt32(rv);
      if (data.resultCode == 0) {
        var int64_19 = Convert.ToInt64(realSellCount);
        var int64_20 = Convert.ToInt64(totalMoneyCount);
        var int64_21 = Convert.ToInt64(originalTotalMoneyCount);
        var int64_22 = Convert.ToInt64(sellNo);
        var int64_23 = Convert.ToInt64(sellPricePerOne);
        var num10 = num6 + int64_19;
        var num11 = num7 + int64_20;
        if (num10 == 0L && int64_22 == 0L) {
          LogUtil.WriteLog(string.Format("[Item Error]SellItemProcess({0}) ReserveBiddingFail", model), "WARN");
          data.resultCode = 23;
          data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_ReserveSellBiddingFail.GetResourceValue();
          return data;
        }

        data.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(int64_23) + "-" +
                         Convert.ToString(num10) + "-" + Convert.ToString(num11) + "-" + Convert.ToString(int64_22) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" +
                         Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
        if (0L < int64_19) {
          itemInfo.count1 = int64_19;
          itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1);
          itemInfo.afterCount1 = Convert.ToInt64(afterCount1);
          itemInfo.count2 = int64_20;
          itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2);
          itemInfo.afterCount2 = Convert.ToInt64(afterCount2);
          WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                           LogReasonType.eWorldMarket_ReasonType_Sell,
                                           customTime,
                                           userInfo,
                                           itemInfo,
                                           model.sellChooseKey,
                                           Convert.ToInt64(model.isSealed),
                                           int64_21,
                                           Convert.ToInt64(model.isWebAccess),
                                           Convert.ToInt64(model.isRingBuff),
                                           Convert.ToInt64(num1),
                                           model.retryBiddingNo,
                                           textParam1: packageExpiration.ToString());
        }

        if (0L < int64_22) {
          itemInfo.count1 = sellCount - int64_19;
          itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1);
          itemInfo.afterCount1 = Convert.ToInt64(afterCount1);
          itemInfo.keyType2 = 0;
          itemInfo.itemKey2 = 0;
          itemInfo.enchantLevel2 = 0;
          itemInfo.count2 = 0L;
          itemInfo.beforeCount2 = 0L;
          itemInfo.afterCount2 = 0L;
          WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                           LogReasonType.eWorldMarket_ReasonType_BiddingSellRegister,
                                           customTime,
                                           userInfo,
                                           itemInfo,
                                           int64_22,
                                           model.sellChooseKey,
                                           Convert.ToInt64(model.isSealed),
                                           model.sellPrice,
                                           Convert.ToInt64(model.isWebAccess),
                                           Convert.ToInt64(model.isRingBuff),
                                           Convert.ToInt64(num1),
                                           model.retryBiddingNo,
                                           textParam1: packageExpiration.ToString());
        }
      }
      else {
        if (0L < num6) {
          var int64 = Convert.ToInt64(sellPricePerOne);
          data.resultCode = 0;
          data.resultMsg = Convert.ToString(model.sellMainKey) + "-" + Convert.ToString(model.sellChooseKey) + "-" + Convert.ToString(model.sellCount) + "-" + Convert.ToString(int64) + "-" +
                           Convert.ToString(num6) + "-" + Convert.ToString(num7) + "-" + Convert.ToString(0) + "-" + Convert.ToString(model.isSealed) + "-" + Convert.ToString(num1) + "-" +
                           Convert.ToString(model.retryBiddingNo) + "-" + Convert.ToString(num5);
          Task.Run(() => TradeAlarmService.This.SendAlarm(buyUserIdList, model.sellMainKey, "BUY"));
          return data;
        }

        LogUtil.WriteLog(string.Format("[DB Error]SellItemProcess - uspSellToWorldMarket({0}/{1}), rv({2})", model, sellCount, data.resultCode), "WARN");
        data.resultMsg = Convert.ToString(symNo);
      }
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]SellItemProcess() - uspSellToWorldMarket({@model}/{1}) Exception : {2}", model, sellCount, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    Task.Run(() => TradeAlarmService.This.SendAlarm(buyUserIdList, model.sellMainKey, "BUY"));
    return data;
  }

  public CommonResult WithdrawBuyBiddingProcess(ProcessTradeMarketBiddingInfo model) {
    var data = new CommonResult();
    var marketBiddingInfo1 = new ProcessTradeMarketBiddingInfo();
    var info = ItemInfoManager.This.GetInfo(model.mainKey, model.subKey);
    if (!info.IsValid()) {
      LogUtil.WriteLog(string.Format("[Item Error]WithdrawBuyBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.mainKey, model.subKey), "WARN");
      data.resultCode = 8;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    try {
      TradeDbManager.This.uspWithdrawBiddingBuy(model.biddingNo,
                                                model.keyType,
                                                model.mainKey,
                                                info._enchantGroup,
                                                model.count,
                                                model.nationCode,
                                                model.serverNo,
                                                model.userNo,
                                                model.subKey,
                                                out var differenceMoney,
                                                out var withdrawMoneyCount,
                                                out var isDelete,
                                                out var beforeCount1,
                                                out var afterCount1,
                                                out var symNo,
                                                out var rv);
      data.resultCode = Convert.ToInt32(rv);
      if (data.resultCode != 0) {
        LogUtil.WriteLog(string.Format("[DB Error]WithdrawBuyBiddingProcess - uspWithdrawBiddingBuy({0}), rv({1})", model, data.resultCode), "WARN");
        data.resultMsg = Convert.ToString(symNo);
        return data;
      }

      data.resultMsg = Convert.ToString(model.biddingNo) + "-" + Convert.ToString(model.count) + "-" + Convert.ToString(differenceMoney) + "-" + Convert.ToString(isDelete);
      WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                       LogReasonType.eWorldMarket_ReasonType_BiddingBuyWithdraw,
                                       CultureModule.GetCustomTimeNow(),
                                       new CommonModel.TradeMarketUserLogInfo {
                                         nationCode = model.nationCode,
                                         serverNo = model.serverNo,
                                         userNo = model.userNo
                                       },
                                       new CommonModel.TradeMarketItemLogInfo {
                                         keyType1 = model.keyType,
                                         itemKey1 = model.mainKey,
                                         enchantLevel1 = model.subKey,
                                         count1 = model.count,
                                         keyType2 = 0,
                                         itemKey2 = 1,
                                         enchantLevel2 = 0,
                                         count2 = Convert.ToInt64(withdrawMoneyCount),
                                         beforeCount2 = Convert.ToInt64(beforeCount1),
                                         afterCount2 = Convert.ToInt64(afterCount1)
                                       },
                                       model.biddingNo,
                                       Convert.ToInt32(isDelete),
                                       Convert.ToInt64(differenceMoney),
                                       Convert.ToInt64(model.isWebAccess));
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]WithdrawBuyBiddingProcess() - uspWithdrawBiddingBuy({0}) Exception : {1}", model, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    return data;
  }

  public CommonResult CalculateBuyBiddingProcess(ProcessTradeMarketBiddingInfo model) {
    var data = new CommonResult();
    var marketBiddingInfo1 = new ProcessTradeMarketBiddingInfo();
    var info = ItemInfoManager.This.GetInfo(model.mainKey, model.subKey);
    if (!info.IsValid()) {
      LogUtil.WriteLog(string.Format("[Item Error]CalculateBuyBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.mainKey, model.subKey), "WARN");
      data.resultCode = 8;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    try {
      TradeDbManager.This.uspCalculateBiddingBuy(model.biddingNo,
                                                 model.keyType,
                                                 model.mainKey,
                                                 info._enchantGroup,
                                                 model.nationCode,
                                                 model.serverNo,
                                                 model.userNo,
                                                 info._weight,
                                                 OptionManager.This.GetMaxWeight() * OptionManager.This.GetMaxWeightRate(),
                                                 out var boughtCount,
                                                 out var chooseSubKey,
                                                 out var isDelete,
                                                 out var beforeCount1,
                                                 out var afterCount1,
                                                 out var symNo,
                                                 out var rv);
      data.resultCode = Convert.ToInt32(rv);
      if (data.resultCode != 0) {
        LogUtil.WriteLog(string.Format("[DB Error]CalculateBuyBiddingProcess - uspCalculateBiddingBuy({0}), rv({1})", model, data.resultCode), "WARN");
        data.resultMsg = Convert.ToString(symNo);
        return data;
      }

      data.resultMsg = Convert.ToString(model.biddingNo) + "-" + Convert.ToString(isDelete) + "-" + Convert.ToString(boughtCount);
      WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                       LogReasonType.eWorldMarket_ReasonType_BiddingBuyCalculate,
                                       CultureModule.GetCustomTimeNow(),
                                       new CommonModel.TradeMarketUserLogInfo {
                                         nationCode = model.nationCode,
                                         serverNo = model.serverNo,
                                         userNo = model.userNo
                                       },
                                       new CommonModel.TradeMarketItemLogInfo {
                                         keyType1 = model.keyType,
                                         itemKey1 = model.mainKey,
                                         enchantLevel1 = model.subKey,
                                         count1 = Convert.ToInt64(boughtCount),
                                         beforeCount1 = Convert.ToInt64(beforeCount1),
                                         afterCount1 = Convert.ToInt64(afterCount1)
                                       },
                                       model.biddingNo,
                                       Convert.ToInt32(isDelete),
                                       Convert.ToInt32(chooseSubKey),
                                       Convert.ToInt64(model.isWebAccess),
                                       Convert.ToInt64(boughtCount));
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]CalculateBuyBiddingProcess() - uspCalculateBiddingBuy({0}) Exception : {1}", model, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    return data;
  }


  public CommonResult WithdrawSellBiddingProcess(ProcessTradeMarketBiddingInfo model) {
    var data = new CommonResult();
    var marketBiddingInfo1 = new ProcessTradeMarketBiddingInfo();

    var info = ItemInfoManager.This.GetInfo(model.mainKey, model.subKey);
    if (!info.IsValid()) {
      LogUtil.WriteLog(string.Format("[Item Error]WithdrawSellBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.mainKey, model.subKey), "WARN");
      data.resultCode = 8;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    var customTime = CultureModule.GetCustomTimeNow();
    try {
      TradeDbManager.This.uspWithdrawBiddingSell(model.biddingNo,
                                                 model.keyType,
                                                 model.mainKey,
                                                 info._enchantGroup,
                                                 model.isSealed,
                                                 model.count,
                                                 model.nationCode,
                                                 model.serverNo,
                                                 model.userNo,
                                                 info._weight,
                                                 OptionManager.This.GetMaxWeight() * OptionManager.This.GetMaxWeightRate(),
                                                 OptionManager.This.GetBiddingPercent(),
                                                 customTime,
                                                 out var chooseSubKey,
                                                 out var isDelete,
                                                 out var beforeCount1,
                                                 out var afterCount1,
                                                 out var symNo,
                                                 out var rv);
      data.resultCode = Convert.ToInt32(rv);
      if (data.resultCode != 0) {
        LogUtil.WriteLog(string.Format("[DB Error]WithdrawSellBiddingProcess - uspWithdrawBiddingSell({0}), rv({1})", model, data.resultCode), "WARN");
        data.resultMsg = Convert.ToString(symNo);
        return data;
      }

      data.resultMsg = Convert.ToString(model.biddingNo) + "-" + Convert.ToString(model.count) + "-" + Convert.ToString(isDelete);
      WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                       LogReasonType.eWorldMarket_ReasonType_BiddingSellWithdraw,
                                       customTime,
                                       new CommonModel.TradeMarketUserLogInfo {
                                         nationCode = model.nationCode,
                                         serverNo = model.serverNo,
                                         userNo = model.userNo
                                       },
                                       new CommonModel.TradeMarketItemLogInfo {
                                         keyType1 = model.keyType,
                                         itemKey1 = model.mainKey,
                                         enchantLevel1 = model.subKey,
                                         count1 = model.count,
                                         beforeCount1 = Convert.ToInt64(beforeCount1),
                                         afterCount1 = Convert.ToInt64(afterCount1)
                                       },
                                       model.biddingNo,
                                       Convert.ToInt32(isDelete),
                                       Convert.ToInt32(chooseSubKey),
                                       Convert.ToInt32(model.isSealed),
                                       Convert.ToInt64(model.isWebAccess));
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]WithdrawSellBiddingProcess() - uspWithdrawBiddingSell({0}) Exception : {1}", model, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    return data;
  }

  public CommonResult CalculateSellBiddingProcess(ProcessTradeMarketBiddingInfo model) {
    var data = new CommonResult();
    var marketBiddingInfo1 = new ProcessTradeMarketBiddingInfo();


    var info = ItemInfoManager.This.GetInfo(model.mainKey, model.subKey);
    if (!info.IsValid()) {
      LogUtil.WriteLog(string.Format("[Item Error]CalculateSellBiddingProcess({0}) itemInfo({1}, {2}) Not Exist ItemInfo", model, model.mainKey, model.subKey), "WARN");
      data.resultCode = 8;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue();
      return data;
    }

    try {
      TradeDbManager.This.uspCalculateBiddingSell(model.biddingNo,
                                                  model.keyType,
                                                  model.mainKey,
                                                  info._enchantGroup,
                                                  info._mainGroupNo,
                                                  model.isSealed,
                                                  model.nationCode,
                                                  model.serverNo,
                                                  model.userNo,
                                                  model.subKey,
                                                  out var soldCount,
                                                  out var isDelete,
                                                  out var amountMoney,
                                                  out var originalTotalMoneyCount,
                                                  out var packageExpiration,
                                                  out var isAppledRingBuff,
                                                  out var beforeCount1,
                                                  out var afterCount1,
                                                  out var symNo,
                                                  out var rv);
      data.resultCode = Convert.ToInt32(rv);
      if (data.resultCode != 0) {
        LogUtil.WriteLog(string.Format("[DB Error]CalculateSellBiddingProcess - uspCalculateBiddingSell({0}), rv({1})", model, data.resultCode), "WARN");
        data.resultMsg = Convert.ToString(symNo);
        return data;
      }

      data.resultMsg = Convert.ToString(model.biddingNo) + "-" + Convert.ToString(isDelete) + "-" + Convert.ToString(amountMoney) + "-" + Convert.ToString(soldCount);
      WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                       LogReasonType.eWorldMarket_ReasonType_BiddingSellCalculate,
                                       CultureModule.GetCustomTimeNow(),
                                       new CommonModel.TradeMarketUserLogInfo {
                                         nationCode = model.nationCode,
                                         serverNo = model.serverNo,
                                         userNo = model.userNo
                                       },
                                       new CommonModel.TradeMarketItemLogInfo {
                                         keyType1 = model.keyType,
                                         itemKey1 = model.mainKey,
                                         enchantLevel1 = model.subKey,
                                         count1 = model.count,
                                         keyType2 = 0,
                                         itemKey2 = 1,
                                         enchantLevel2 = 0,
                                         count2 = Convert.ToInt64(amountMoney),
                                         beforeCount2 = Convert.ToInt64(beforeCount1),
                                         afterCount2 = Convert.ToInt64(afterCount1)
                                       },
                                       model.biddingNo,
                                       Convert.ToInt32(isDelete),
                                       Convert.ToInt64(amountMoney),
                                       Convert.ToInt32(model.isSealed),
                                       Convert.ToInt64(originalTotalMoneyCount),
                                       Convert.ToInt64(model.isWebAccess),
                                       Convert.ToInt64(soldCount),
                                       Convert.ToInt64(isAppledRingBuff),
                                       textParam1: packageExpiration.ToString());
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("[DB Exception]CalculateSellBiddingProcess() - uspCalculateBiddingSell({0}) Exception : {1}", model, ex), "ERROR");
      data.resultCode = 1;
      data.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
      return data;
    }

    return data;
  }




  // public ProcessTradeMarketState CheckWithDrawPayLoadProcess(ProcessTradeMarketIncludePayloadModel model) {
  //   var empty1 = string.Empty;
  //   var data1 = new CommonResult();
  //   var data2 = new ProcessTradeMarketState();
  //   var marketIncludePayload1 = new ProcessTradeMarketIncludePayloadModel();
  //
  //   TradeDbManager.This.uspGetWithDrawPayLoadState(model.userNo,
  //                                                  model.nationCode,
  //                                                  model.serverNo,
  //                                                  model.payload,
  //                                                  model.mainKey,
  //                                                  model.subKey,
  //                                                  model.isSealed,
  //                                                  model.count,
  //                                                  model.param0,
  //                                                  model.param1,
  //                                                  model.param2,
  //                                                  model.param3,
  //                                                  model.param4,
  //                                                  out var state,
  //                                                  out var symNo,
  //                                                  out var rv);
  //   var int32 = Convert.ToInt32(rv);
  //   var str = Convert.ToString(symNo);
  //   data2.state = Convert.ToInt32(state);
  //   if (int32 != 0) {
  //     LogUtil.WriteLog(string.Format("[DB Error]CheckWithDrawPayLoadProcess - uspGetWithDrawPayLoadState({0}/{1}), rv({2})", model, str, int32), "WARN");
  //     data1.resultCode = int32;
  //     data1.resultMsg = str;
  //     data2.result = data1;
  //     return data2;
  //   }
  //
  //   return data2;
  // }

  // public UserInfomationResultModel GetMyWalletInfoProcess(ProcessTradeMarketUserId model) {
  //   var data = new UserInfomationResultModel();
  //   var tradeMarketUserId1 = new ProcessTradeMarketUserId();
  //
  //
  //   try {
  //     TradeDbManager.This.uspGetMyWalletInfo(model._accountNo.ToString(),
  //                                            out var userNo,
  //                                            out var userNickName,
  //                                            out var serviceType,
  //                                            out var worldNo,
  //                                            out var valuepackage,
  //                                            out var addWeightBuff,
  //                                            out var resultCode,
  //                                            out var resultMsg);
  //
  //     if (Convert.ToInt64(userNo) == 0L) {
  //       LogUtil.WriteLog(string.Format("[DB ERROR]uspGetMyWalletInfo({0}) - can't find userinfo ", model._accountNo), "WARN");
  //       data._result.resultCode = 1;
  //       data._result.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //       return data;
  //     }
  //
  //     data._userInfo = new UserInformationModel {
  //       _userNo = Convert.ToInt64(userNo),
  //       _nationCode = Convert.ToInt32(serviceType),
  //       _worldNo = Convert.ToInt32(worldNo),
  //       _userNickName = Convert.ToString(userNickName),
  //       _valuePackageExpiration = Convert.ToDateTime(valuepackage).AddHours(ConstantContainer.ServiceUtcTime),
  //       _addWeightBuffExpiration = Convert.ToDateTime(addWeightBuff).AddHours(ConstantContainer.ServiceUtcTime)
  //     };
  //   }
  //   catch (Exception ex) {
  //     LogUtil.WriteLog(string.Format("[DB Exception]CalculateSellBiddingProcess() - uspCalculateBiddingSell({0}) Exception : {1}", model, ex), "ERROR");
  //     data._result.resultCode = 1;
  //     data._result.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     return data;
  //   }
  //
  //   return data;
  // }
}