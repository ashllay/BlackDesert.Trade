// using BlackDesert.Trade.Business.Manager.Server;
//
// namespace BlackDesert.Trade.Business.Manager.Timers;
//
// public class UpdateSystemCountTimer
// {
//   private static readonly object _locker = new();
//   private static bool _flag;
//
//   public static void Execute(object? state) {
//     lock (_locker) {
//       if (_flag)
//         return;
//       _flag = true;
//     }
//
//     try {
//       UpdateSystemCount();
//       ServerControlLogger.LogRunTimer(nameof(UpdateSystemCountTimer));
//     }
//     catch (Exception ex) {
//       Log.Error(ex, "[Timers Error] UpdateSystemCountTimer Exception");
//     }
//
//     lock (_locker) {
//       _flag = false;
//     }
//   }
//
//   private static void UpdateSystemCount() {
//     var systemBuyPercent = OptionManager.This.GetSystemBuyPercent();
//     var systemStockPercent = OptionManager.This.GetSystemStockPercent();
//     if (systemBuyPercent <= 0 || systemStockPercent <= 0)
//       return;
//     foreach (var num1 in TickCountManager.This.GetMainGroupListXxx())
//       if (num1 == OptionManager.This.GetCashGroupNo()) {
//         var marketMainGroupList = new TradeMarketMainGroupList();
//         try {
//           //this only takes items if the _count column is greater than 0 in the database
//           //which normally it is always 0 
//           //no idea how this returns gets any items at all
//           marketMainGroupList.list = TradeDbManager.This.uspListWorldMarketByMainGroup(num1, out var symNo, out var rv).ToList();
//         }
//         catch (Exception ex) {
//           LogUtil.WriteLog(string.Format("uspListWorldMarketByMainGroup Exception : {0}", ex), "ERROR");
//           break;
//         }
//
//         foreach (var byMainGroupResult in marketMainGroupList.list) {
//           var random = new Random();
//           //TODO: CHECK WTF IS THIS RANDOM ????
//           /*
//            * NOT SURE BUT THIS  IS SHOULD PRE_STOCKING ITEMS
//            * BUYING ITEMS TO SYSTEM AND SELLING IT ON MARKET
//            * THIS SHOULD NOT BE DISABLED
//            *
//            * Basically all items that are in the database with a _count > 0
//            * Taken and by %10 chance it is bought by the system
//            */
//           var num2 = random.Next(0, 1000000);
//           
//           //in xml systemBuyPercent is %10 
//           if (systemBuyPercent < num2) continue;
//           var maxValue = (int)((int.MaxValue >= byMainGroupResult._count
//                                   ? (int)byMainGroupResult._count
//                                   : (double)int.MaxValue) * (systemStockPercent / 1000000.0));
//           if (maxValue == 0)
//             maxValue = 1;
//           var buyCount = random.Next(1, maxValue);
//           BuyItemSystemProcess(byMainGroupResult._keyType, byMainGroupResult._mainKey, byMainGroupResult._subKey, buyCount);
//         }
//       }
//   }
//
//   private static void BuyItemSystemProcess(
//     int buyKeyType,
//     int buyMainKey,
//     int buySubKey,
//     long buyCount) {
//
//      if (!WorldMarketLogger.LogDbCheck()) {
//       LogUtil.WriteLog("BuyItemSystemProcess log DB Exception", "WARN");
//     }
//     else {
//       var userInfo = new CommonModel.TradeMarketUserLogInfo();
//       var info = ItemInfoManager.This.GetInfo(buyMainKey, buySubKey);
//       if (!info.IsValid()) {
//         LogUtil.WriteLog(string.Format("[Item Error]BuyItemSystemProcess() itemInfo({0}, {0}) Not Exist ItemInfo", buyMainKey, buySubKey), "WARN");
//       }
//       else {
//         var tradeMarketItemInfo = new TradeMarketItemInfo();
//         if (info._enchantMaterialKey != 0) {
//           tradeMarketItemInfo = ItemInfoManager.This.GetInfo(info._enchantMaterialKey, 0);
//           if (!info.IsValid()) {
//             LogUtil.WriteLog(string.Format("[Item Error]BuyItemProcess() itemInfo({0}, {1}) Not Exist Material ItemInfo", info._enchantMaterialKey, 0), "WARN");
//             return;
//           }
//         }
//
//         var num1 = buyCount;
//         long num2 = 0;
//         long num3 = 0;
//         var num4 = 0;
//         var customTime = CultureModule.GetCustomTimeNow();
//         while (0L < num1)
//           try {
//             TradeDbManager.This.uspBuyBiddingFromWorldMarketBySystem(buyKeyType,
//                                                                      buyMainKey,
//                                                                      buySubKey,
//                                                                      num1,
//                                                                      buySubKey,
//                                                                      tradeMarketItemInfo._mainKey,
//                                                                      info._enchantNeedCount,
//                                                                      OptionManager.This.BiddingRatio,
//                                                                      out var realBuyCount,
//                                                                      out var totalMoneyCount,
//                                                                      out var sellNo,
//                                                                      out var stopType,
//                                                                      out var symNo,
//                                                                      out var rv);
//             var int32_1 = Convert.ToInt32(rv);
//             var int32_2 = (StopReasonType)Convert.ToInt32(stopType);
//             if (int32_1 == 0) {
//               if (StopReasonType.eStopReasonType_Empty != int32_2) {
//                 if (StopReasonType.eStopReasonType_Fail == int32_2) {
//                   if (5 == num4) {
//                     LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}) Fail BuyBidding", num1), "WARN");
//                     return;
//                   }
//
//                   ++num4;
//                 }
//                 else if (int32_2 == StopReasonType.eStopReasonType_Normal) {
//                   num1 -= Convert.ToInt64(realBuyCount);
//                   num2 += Convert.ToInt64(realBuyCount);
//                   num3 += Convert.ToInt64(totalMoneyCount);
//                   var int64 = Convert.ToInt64(sellNo);
//                   WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
//                                                    LogReasonType.eWorldMarket_ReasonType_BuyBiddingSystem,
//                                                    customTime,
//                                                    userInfo,
//                                                    new CommonModel.TradeMarketItemLogInfo {
//                                                      keyType1 = buyKeyType,
//                                                      itemKey1 = buyMainKey,
//                                                      enchantLevel1 = buySubKey,
//                                                      count1 = Convert.ToInt64(realBuyCount),
//                                                      keyType2 = 0,
//                                                      itemKey2 = 1,
//                                                      enchantLevel2 = 0,
//                                                      count2 = Convert.ToInt64(totalMoneyCount)
//                                                    },
//                                                    int64);
//                 }
//                 else {
//                   LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}) StopReasonType({1}) is Invalid", num1, (int)int32_2), "WARN");
//                   return;
//                 }
//               }
//               else {
//                 break;
//               }
//             }
//             else {
//               LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyBiddingFromWorldMarket({0}), rv({1})", num1, int32_1), "WARN");
//               return;
//             }
//           }
//           catch (Exception ex) {
//             LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyBiddingFromWorldMarket({0}) Exception : {1}", num1, ex), "ERROR");
//             return;
//           }
//
//         if (num1 == 0L)
//           return;
//         try {
//           TradeDbManager.This.uspBuyFromWorldMarketBySystem(buyKeyType,
//                                                             buyMainKey,
//                                                             buySubKey,
//                                                             num1,
//                                                             buySubKey,
//                                                             tradeMarketItemInfo._mainKey,
//                                                             info._enchantNeedCount,
//                                                             OptionManager.This.BiddingRatio,
//                                                             out var realBuyCount,
//                                                             out var totalMoneyCount,
//                                                             out var buyNo,
//                                                             out var symNo,
//                                                             out var rv);
//           var int32 = Convert.ToInt32(rv);
//           if (int32 == 0) {
//             if (0L >= num2 + Convert.ToInt64(realBuyCount))
//               return;
//             WorldMarketLogger.LogWorldMarket(OperationType.eWorldMarket_OperationType_Item,
//                                              LogReasonType.eWorldMarket_ReasonType_BuySystem,
//                                              customTime,
//                                              userInfo,
//                                              new CommonModel.TradeMarketItemLogInfo {
//                                                keyType1 = buyKeyType,
//                                                itemKey1 = buyMainKey,
//                                                enchantLevel1 = buySubKey,
//                                                count1 = Convert.ToInt64(realBuyCount),
//                                                keyType2 = 0,
//                                                itemKey2 = 1,
//                                                enchantLevel2 = 0,
//                                                count2 = 0L
//                                              },
//                                              buySubKey);
//           }
//           else {
//             if (0L < num2)
//               return;
//             LogUtil.WriteLog(string.Format("[DB Error]BuyItemProcess - uspBuyFromWorldMarket({0}), rv({1})", num1, int32), "WARN");
//           }
//         }
//         catch (Exception ex) {
//           LogUtil.WriteLog(string.Format("[DB Exception]BuyItemProcess() - uspBuyFromWorldMarket({0}) Exception : {1}", num1, ex), "ERROR");
//         }
//       }
//     }
//   }
// }