using BlackDesert.Trade.Db.Entities.LogEntities;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Models;
using Serilog;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class LogDbContext
{
  public void LogWorldMarketForOperation(short? operationLogType,
                                         DateTime? registerDate,
                                         int? nationCode,
                                         int? serverNo,
                                         long? userNo,
                                         int? keyType1,
                                         int? mainKey1,
                                         int? subKey1,
                                         long? count1,
                                         long? beforeCount1,
                                         long? afterCount1,
                                         int? keyType2,
                                         int? mainKey2,
                                         int? subKey2,
                                         long? count2,
                                         long? beforeCount2,
                                         long? afterCount2,
                                         long? param1,
                                         long? param2,
                                         long? param3,
                                         long? param4,
                                         long? param5,
                                         long? param6,
                                         long? param7,
                                         long? param8,
                                         long? param9,
                                         long? param10,
                                         long? param11,
                                         long? param12,
                                         string textParam1,
                                         string textParam2,
                                         short? reason) {
    //TODO FİX LOGNO AUTO INCREASE
    return;
    var log = new TblWorldMarketLog();
    log.OperationLogType = operationLogType;
    log.RegisterUtc = registerDate;
    log.NationCode = nationCode;
    log.ServerNo = serverNo;
    log.UserNo = userNo;
    log.KeyType1 = keyType1;
    log.MainKey1 = mainKey1;
    log.SubKey1 = subKey1;
    log.Count1 = count1;
    log.BeforeCount1 = beforeCount1;
    log.AfterCount1 = afterCount1;
    log.KeyType2 = keyType2;
    log.MainKey2 = mainKey2;
    log.SubKey2 = subKey2;
    log.Count2 = count2;
    log.BeforeCount2 = beforeCount2;
    log.AfterCount2 = afterCount2;
    //TODO CHECK
    // log.Param1 = param1;
    // log.Param2 = param2;
    // log.Param3 = param3;
    // log.Param4 = param4;
    // log.Param5 = param5;
    // log.Param6 = param6;
    // log.Param7 = param7;
    // log.Param8 = param8;
    // log.Param9 = param9;
    // log.Param10 = param10;
    // log.Param11 = param11;
    // log.Param12 = param12;
    log.TextParam1 = textParam1;
    log.TextParam2 = textParam2;
    log.Reason = reason.ToString();
    // DbLogQueue.Enqueue(new Action(() => {
    //   try {
    //     var ctxLog = new LogDbContext();
    //     ctxLog.TblWorldMarketLogs.Add(log);
    //     var affected = ctxLog.SaveChanges();
    //     if (affected == 0) throw new Exception("LogWorldMarketForOperation - Save Fail");
    //   }
    //   catch (Exception ex) {
    //     Log.Error(ex, "LogWorldMarketForOperation Exception {@LogData}", log);
    //   }
    // }));
  }

  public void LogWorldMarket(OperationType eWorldMarketOperationTypeUser,
                             LogReasonType eWorldMarketReasonTypeCreateWallet,
                             DateTime getCustomTimeNow,
                             CommonModel.TradeMarketUserLogInfo userInfo,
                             CommonModel.TradeMarketItemLogInfo itemInfo) {
    // WorldMarketLogger.LogWorldMarket(eWorldMarketOperationTypeUser,
    //                                  eWorldMarketReasonTypeCreateWallet,
    //                                  getCustomTimeNow,
    //                                  userInfo,
    //                                  itemInfo);
  }

  public void Log_CreateMyWallet_Created(long userNo) {
    return;
    //TODO LOG
    // LogWorldMarket(OperationType.eWorldMarket_OperationType_User,
    //                              LogReasonType.eWorldMarket_ReasonType_CreateWallet,
    //                              CultureModule.GetCustomTimeNow(),
    //                              userInfo,
    //                              itemInfo);
  }
}