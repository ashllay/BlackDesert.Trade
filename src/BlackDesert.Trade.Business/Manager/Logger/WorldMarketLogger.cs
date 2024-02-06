using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Manager.Logger;

public class WorldMarketLogger
{
  private static void LogXxx(
    OperationType operationType,
    short reasonType,
    DateTime currentTime,
    CommonModel.TradeMarketUserLogInfo userInfo,
    CommonModel.TradeMarketItemLogInfo itemInfo,
    long param1 = 0,
    long param2 = 0,
    long param3 = 0,
    long param4 = 0,
    long param5 = 0,
    long param6 = 0,
    long param7 = 0,
    long param8 = 0,
    long param9 = 0,
    long param10 = 0,
    long param11 = 0,
    long param12 = 0,
    string textParam1 = "",
    string textParam2 = "") {
    var ctxLog = new LogDbContext();
    ctxLog.LogWorldMarketForOperation((short)operationType,
                                           currentTime,
                                           userInfo.nationCode,
                                           userInfo.serverNo,
                                           userInfo.userNo,
                                           itemInfo.keyType1,
                                           itemInfo.itemKey1,
                                           itemInfo.enchantLevel1,
                                           itemInfo.count1,
                                           itemInfo.beforeCount1,
                                           itemInfo.afterCount1,
                                           itemInfo.keyType2,
                                           itemInfo.itemKey2,
                                           itemInfo.enchantLevel2,
                                           itemInfo.count2,
                                           itemInfo.beforeCount2,
                                           itemInfo.afterCount2,
                                           param1,
                                           param2,
                                           param3,
                                           param4,
                                           param5,
                                           param6,
                                           param7,
                                           param8,
                                           param9,
                                           param10,
                                           param11,
                                           param12,
                                           textParam1,
                                           textParam2,
                                           reasonType);
  }

  public static void LogWorldMarket(
    OperationType operationType,
    LogReasonType reasonType,
    DateTime currentTime,
    CommonModel.TradeMarketUserLogInfo userInfo,
    CommonModel.TradeMarketItemLogInfo itemInfo,
    long param1 = 0,
    long param2 = 0,
    long param3 = 0,
    long param4 = 0,
    long param5 = 0,
    long param6 = 0,
    long param7 = 0,
    long param8 = 0,
    long param9 = 0,
    long param10 = 0,
    long param11 = 0,
    long param12 = 0,
    string textParam1 = "",
    string textParam2 = "") {
    LogXxx(operationType,
           (short)reasonType,
           currentTime,
           userInfo,
           itemInfo,
           param1,
           param2,
           param3,
           param4,
           param5,
           param6,
           param7,
           param8,
           param9,
           param10,
           param11,
           param12,
           textParam1,
           textParam2);
  }

  // public static void LogCommand(
  //   CommandReasonType type,
  //   DateTime currentTime,
  //   long param1 = 0,
  //   long param2 = 0,
  //   long param3 = 0,
  //   long param4 = 0,
  //   long param5 = 0,
  //   long param6 = 0,
  //   long param7 = 0,
  //   long param8 = 0,
  //   long param9 = 0,
  //   long param10 = 0,
  //   long param11 = 0,
  //   long param12 = 0,
  //   string textParam1 = "",
  //   string textParam2 = "") {
  //   LogXxx(OperationType.eWorldMarket_OperationType_Command,
  //          (short)type,
  //          currentTime,
  //          new CommonModel.TradeMarketUserLogInfo(),
  //          new CommonModel.TradeMarketItemLogInfo(),
  //          param1,
  //          param2,
  //          param3,
  //          param4,
  //          param5,
  //          param6,
  //          param7,
  //          param8,
  //          param9,
  //          param10,
  //          param11,
  //          param12,
  //          textParam1,
  //          textParam2);
  // }

  private static bool LogDbCheck() {
    try {
      //TODO Implement
      var ctxLog = new LogDbContext();
      var can = ctxLog.Database.CanConnect();
      if (!can) {
        LogUtil.WriteLog("logDbCheck : DB Connection Fail",
                         "ERROR");
        return false;
      }

      return true;
    }
    catch (Exception ex) {
      LogUtil.WriteLog(string.Format("logDbCheck Exception : {0}",
                                     ex),
                       "ERROR");
      return false;
    }
    return true;
  }
}