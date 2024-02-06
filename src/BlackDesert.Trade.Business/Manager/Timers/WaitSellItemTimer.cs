using BlackDesert.Trade.Business.Manager.Server;
using BlackDesert.Trade.Business.Services;
using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Timers;

public class WaitSellItemTimer
{
  private static readonly object Locker = new();
  private static bool _flag;

  public static void Execute(object? state) {
    lock (Locker) {
      if (_flag)
        return;
      _flag = true;
    }

    try {
      WaitSellItem();
      ServerControlLogger.LogRunTimer(nameof(WaitSellItemTimer));
    }
    catch (Exception ex) {
      Log.Error(ex, "[Timers Error] WaitSellItemTimer Exception");
    }

    lock (Locker) {
      _flag = false;
    }
  }

  private static void WaitSellItem() {
    var commonDbResult = new CommonDBResult<ResultWaitBiddingSell>();
    var rv = 0;
    var symNo = "";
    var ctxTrade = new TradeDbContext();
     
    try {
      commonDbResult.list = ctxTrade.ListWaitBiddingSell_Unsafe();
    }
    catch (Exception ex) {
      LogUtil.WriteLog("[DB Error]waitSellItem - uspListWaitBiddingSell () errorMsg : " + ex, "ERROR");
      return;
    }

    foreach (var waitItem in commonDbResult.list) {
      var num1 = 0;
      var model = new WaitItemModel(waitItem);
      byte num2 = 2;
      if (model.waitNo <= 0L) {
        LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) waitNo invaild{1}", model, model.waitNo),
                         "WARN");
      }
      else {
        var unitPrice = VariedPriceInfoManager.This.GetUnitPrice(model.sellPrice);
        var num3 = model.sellPrice % unitPrice;
        if (num3 != 0L) {
          LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) sellPrice Check Fail unitPrice({1} divide EfCore {2}",
                                         model,
                                         unitPrice,
                                         num3),
                           "WARN");
        }
        else {
          var info1 = ItemInfoManager.This.GetInfo(model.sellMainKey, model.sellChooseKey);
          if (!info1.IsValid()) {
            LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) itemInfo({1}, {2}) Not Exist ItemInfo",
                                           model,
                                           model.sellMainKey,
                                           model.sellChooseKey),
                             "WARN");
          }
          else {
            var num4 = info1._maxRegisterForWorldMarket * 10L;
            if (
              info1._mainGroupNo == OptionManager.This.GetCashGroupNo())
              num4 = 100L;
            if (num4 < model.sellCount) {
              LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) sellCount({1}) Process Count Over",
                                             model,
                                             model.sellCount),
                               "WARN");
            }
            else {
              var tradeMarketItemInfo = new TradeMarketItemInfo();
              if (info1._enchantMaterialKey != 0) {
                tradeMarketItemInfo = ItemInfoManager.This.GetInfo(info1._enchantMaterialKey, 0);
                if (!info1.IsValid()) {
                  LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) itemInfo({1}, 0) Not Exist Material ItemInfo",
                                                 model,
                                                 info1._enchantMaterialKey),
                                   "WARN");
                  return;
                }
              }

              var enchantMaxGroup1 = ItemInfoManager.This.GetEnchantMaxGroup(model.sellMainKey, info1._enchantGroup);
              if (info1._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup1) {
                LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) getEnchantMaxGroup({1}, {2}) Group : Out Of Range",
                                               model,
                                               model.sellMainKey,
                                               info1._enchantGroup),
                                 "WARN");
              }
              else {
                if (model.sellSubKey != model.sellChooseKey) {
                  var info2 = ItemInfoManager.This.GetInfo(model.sellMainKey, model.sellSubKey);
                  if (!info2.IsValid()) {
                    LogUtil.WriteLog(string.Format("[Item Error]waitSellItem({0}) baseitemInfo({1}, {2}) Not Exist ItemInfo",
                                                   model,
                                                   model.sellMainKey,
                                                   model.sellSubKey),
                                     "WARN");
                    return;
                  }

                  var enchantMaxGroup2 = ItemInfoManager.This.GetEnchantMaxGroup(model.sellMainKey, info2._enchantGroup);
                  if (info2._enchantGroup > model.sellChooseKey || model.sellChooseKey > enchantMaxGroup2) {
                    LogUtil
                      .WriteLog(string
                                  .Format("[Item Error]waitSellItem({0}) getEnchantBaseMaxGroup({1}, {2}) Group : Out Of Range",
                                          model,
                                          model.sellMainKey,
                                          info2._enchantGroup),
                                "WARN");
                    return;
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
                var customTime = CultureModule.GetCustomTimeNow();
                var buyUserIdList = new List<string>();
                try {
                  var resCheckAndUpdateBlackUser = ctxTrade.CheckAndUpdateBlackUser(model.userNo);
                  if (!resCheckAndUpdateBlackUser.Status) {
                    LogUtil.WriteLog("[DB Error]waitSellItem - CheckAndUpdateBlackUser() rv : " + resCheckAndUpdateBlackUser,
                                     "WARN");
                    ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                    return;
                  }
                }
                catch (Exception ex) {
                  LogUtil.WriteLog("[DB Exception]waitSellItem() - uspCheckAndUpdateBlackUser(" + model +
                                   ") Exception : " + ex,
                                   "ERROR");
                  ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                  return;
                }

                var sellCount = model.sellCount;
                long num5 = 0;
                long num6 = 0;
                var num7 = 0;
                var flag = false;
                if (
                  info1._mainGroupNo == OptionManager.This.GetCashGroupNo())
                  flag = true;
                if (model.isRingBuff &&
                    info1._mainGroupNo != OptionManager.This.GetCashGroupNo())
                  num2 = 1;
                var num8 = 0;
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
                                                                    flag,
                                                                    info1._weight,
                                                                    OptionManager.This.GetMaxWeight() * OptionManager.This.GetMaxWeightRate(),
                                                                    OptionManager.This.GetPearlItemLimitedMaxCount(),
                                                                    customTime,
                                                                    num2,
                                                                    model.waitNo,
                                                                    model.isRingBuff,
                                                                    0L,
                                                                    out var walletMoney,
                                                                    out var realSellCount,
                                                                    out var totalMoneyCount,
                                                                    out var originalTotalMoneyCount,
                                                                    out var packageExpiration,
                                                                    out var buyNo,
                                                                    out var buyUserNo,
                                                                    out var buyUserId,
                                                                    out var buyLeftCount,
                                                                    out var stopType,
                                                                    out var isNextApplyRingBuff,
                                                                    out var resultWaitNo,
                                                                    out var raceCount,
                                                                    out var beforeCount1,
                                                                    out var afterCount1,
                                                                    out var beforeCount2,
                                                                    out var afterCount2,
                                                                    out var beforeCount3,
                                                                    out var afterCount3,
                                                                    out var beforeCount4,
                                                                    out var afterCount4,
                                                                    out var soldCount,
                                                                    out var leftCount,
                                                                    out var moneyCount,
                                                                    out var calculateMoney,
                                                                    out var isCalculateRingBuff,
                                                                    out symNo,
                                                                    out rv);
                    var int32_1 = Convert.ToInt32(rv);
                    var int32_2 = (StopReasonType)Convert.ToInt32(stopType);
                    if (int32_1 == 0) {
                      if (StopReasonType.eStopReasonType_Empty != int32_2) {
                        if (StopReasonType.eStopReasonType_Fail == int32_2) {
                          if (5 == num7) {
                            LogUtil
                              .WriteLog(string
                                          .Format("[DB Error]waitSellItem - uspSellBiddingToWorldMarket({0}/{1}) Fail BuyBidding",
                                                  model,
                                                  sellCount),
                                        "WARN");
                            ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                            return;
                          }

                          ++num7;
                        }
                        else if (int32_2 == StopReasonType.eStopReasonType_Normal) {
                          var int64_1 = Convert.ToInt64(realSellCount);
                          var int64_2 = Convert.ToInt64(totalMoneyCount);
                          var int64_3 = Convert.ToInt64(originalTotalMoneyCount);
                          var int64_4 = Convert.ToInt64(buyNo);
                          Convert.ToInt64(walletMoney);
                          if (num8 == 0 && Convert.ToBoolean(isNextApplyRingBuff))
                            num2 = 1;
                          ++num8;
                          sellCount -= int64_1;
                          num5 += int64_1;
                          num6 += int64_2;
                          itemInfo.count1 = int64_1;
                          itemInfo.beforeCount1 = Convert.ToInt64(beforeCount3);
                          itemInfo.afterCount1 = Convert.ToInt64(afterCount3);
                          itemInfo.count2 = int64_2;
                          itemInfo.beforeCount2 = Convert.ToInt64(beforeCount4);
                          itemInfo.afterCount2 = Convert.ToInt64(afterCount4);
                          WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                                           LogReasonType.eWorldMarket_ReasonType_SellBidding,
                                                           customTime,
                                                           userInfo,
                                                           itemInfo,
                                                           int64_4,
                                                           model.sellChooseKey,
                                                           Convert.ToInt64(model.isSealed),
                                                           int64_3,
                                                           2L,
                                                           Convert.ToInt64(num2),
                                                           model.waitNo,
                                                           Convert.ToInt64(buyUserNo),
                                                           Convert.ToInt64(raceCount),
                                                           Convert.ToInt64(model.isRingBuff),
                                                           textParam1: packageExpiration.ToString());
                          if (Convert.ToInt64(buyLeftCount) == 0L) {
                            var str = buyUserId.ToString();
                            if (!buyUserIdList.Contains(str))
                              buyUserIdList.Add(str);
                          }
                        }
                        else {
                          LogUtil
                            .WriteLog(string
                                        .Format("[DB Error]waitSellItem - uspSellBiddingToWorldMarket({0}/{1}) StopReasonType({2}) is Invalid",
                                                model,
                                                sellCount,
                                                (int)int32_2),
                                      "WARN");
                          ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                          return;
                        }
                      }
                      else {
                        break;
                      }
                    }
                    else {
                      LogUtil.WriteLog(string.Format("[DB Error]waitSellItem - uspSellBiddingToWorldMarket({0}/{1}), rv({2})",
                                                     model,
                                                     sellCount,
                                                     int32_1),
                                       "WARN");
                      ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                      return;
                    }
                  }
                  catch (Exception ex) {
                    LogUtil
                      .WriteLog(string
                                  .Format("[DB Exception]waitSellItem() - uspSellBiddingToWorldMarket({0}/{1}) Exception : {2}",
                                          model,
                                          sellCount,
                                          ex),
                                "ERROR");
                    ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                    return;
                  }

                if (sellCount == 0L)
                  Task.Run(() => TradeAlarmService.This.SendAlarm(buyUserIdList, model.sellMainKey, "BUY"));
                else
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
                                                             flag,
                                                             info1._weight,
                                                             OptionManager.This.GetPearlItemLimitedMaxCount(),
                                                             customTime,
                                                             num2,
                                                             model.waitNo,
                                                             out var sellPricePerOne,
                                                             out var realSellCount,
                                                             out var totalMoneyCount,
                                                             out var originalTotalMoneyCount,
                                                             out var packageExpiration,
                                                             out var sellNo,
                                                             out var isAppledRingBuff,
                                                             out var beforeCount1,
                                                             out var afterCount1,
                                                             out var beforeCount2,
                                                             out var afterCount2,
                                                             out symNo,
                                                             out rv);
                    var int32 = Convert.ToInt32(rv);
                    if (int32 == 0) {
                      var int64_5 = Convert.ToInt64(realSellCount);
                      var int64_6 = Convert.ToInt64(totalMoneyCount);
                      var int64_7 = Convert.ToInt64(originalTotalMoneyCount);
                      var int64_8 = Convert.ToInt64(sellNo);
                      Convert.ToInt64(sellPricePerOne);
                      var num9 = num5 + int64_5;
                      var num10 = num6 + int64_6;
                      if (num9 == 0L && int64_8 == 0L) {
                        LogUtil.WriteLog("[Item Error]waitSellItem(" + model + ") ReserveBiddingFail", "WARN");
                        ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                      }
                      else {
                        if (0L < int64_5) {
                          itemInfo.count1 = int64_5;
                          itemInfo.beforeCount1 = Convert.ToInt64(beforeCount1);
                          itemInfo.afterCount1 = Convert.ToInt64(afterCount1);
                          itemInfo.count2 = int64_6;
                          itemInfo.beforeCount2 = Convert.ToInt64(beforeCount2);
                          itemInfo.afterCount2 = Convert.ToInt64(afterCount2);
                          WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
                                                           LogReasonType.eWorldMarket_ReasonType_Sell,
                                                           customTime,
                                                           userInfo,
                                                           itemInfo,
                                                           model.sellChooseKey,
                                                           Convert.ToInt64(model.isSealed),
                                                           int64_7,
                                                           2L,
                                                           Convert.ToInt64(model.isRingBuff),
                                                           Convert.ToInt64(num2),
                                                           model.waitNo,
                                                           textParam1: packageExpiration.ToString());
                        }

                        if (0L >= int64_8)
                          return;
                        itemInfo.keyType1 = model.sellKeyType;
                        itemInfo.itemKey1 = model.sellMainKey;
                        itemInfo.enchantLevel1 = model.sellSubKey;
                        itemInfo.count1 = sellCount - int64_5;
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
                                                         int64_8,
                                                         model.sellChooseKey,
                                                         Convert.ToInt64(model.isSealed),
                                                         model.sellPrice,
                                                         2L,
                                                         model.waitNo,
                                                         textParam1: packageExpiration.ToString());
                      }
                    }
                    else if (0L < num5) {
                      Convert.ToInt64(sellPricePerOne);
                      num1 = 0;
                      Task.Run((Action)(() => TradeAlarmService.This.SendAlarm(buyUserIdList, model.sellMainKey, "BUY")));
                    }
                    else {
                      LogUtil.WriteLog(string.Format("[DB Error]waitSellItem - uspSellToWorldMarket({0}/{1}), rv({2})",
                                                     model,
                                                     sellCount,
                                                     int32),
                                       "WARN");
                      ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                    }
                  }
                  catch (Exception ex) {
                    LogUtil
                      .WriteLog(string.Format("[DB Exception]waitSellItem() - uspSellToWorldMarket({0}/{1}) Exception : {2}",
                                              model,
                                              sellCount,
                                              ex),
                                "ERROR");
                    ctxTrade.UpdateWaitFail(model, info1._weight, customTime);
                  }
              }
            }
          }
        }
      }
    }
  }
}