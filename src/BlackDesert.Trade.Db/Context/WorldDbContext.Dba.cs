using BlackDesert.Trade.Db.Entities.WorldEntities;
using BlackDesert.Trade.Domain.Common;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Exceptions;
using BlackDesert.Trade.Domain.Models.Db;
using BlackDesert.Trade.Domain.Models.EfCore;
using Serilog;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class WorldDbContext
{
  public string GetUserId_Unsafe(long userNo) {
    var entry = TblUserInformations
                .Where(x => x.UserNo == userNo && x.IsValid == true)
                .Select(x => x.UserId)
                .FirstOrDefault();

    TradeMarketDbNotFoundException.ThrowIfNull(entry,
                                               nameof(TblUserInformation),
                                               userNo);
    return entry;
  }
  
  public bool IsGameMaster_Safe(long userNo) {
    try {
      return TblRoleGroupMembers
        .Any(x => x.UserNo == userNo && x.MacAddress != "" && x.IpAddress != "");
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreWorldDbManager] IsGameMaster_Safe Exception ({userNo})", userNo);
      return false;
    }
  }

  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////////////////////////////
  
  
    private void LogTradeAuthKeyHistoryFail(long userNo,
                                          string requestKey,
                                          int rv,
                                          TblTradeAuthKey? authKey) {
    //TODO: fails because TblTradeAuthKeyHistory has no primary key
    return;
    var task = new Action(() => {
      try {
        
        var entry = new TblTradeAuthKeyHistory {
          UserNo = userNo,
          RequestKey = requestKey,
          CurKey = authKey?.CurKey?.ToString(),
          PrevKey = authKey?.PrevKey?.ToString(),
          Type = 2,
          RegisterDate = DateTime.Now,
          ReturnValue = rv,
          CurUpdateDate = authKey?.CurUpdateDate,
          PrevUpdateDate = authKey?.PrevUpdateDate
        };
        TblTradeAuthKeyHistories.Add(entry);
        var res = SaveChanges();
        if (res != 1) Log.Fatal("LogTradeAuthKeyHistoryFail - Save Fail {UserNo}/{RequestKey}/{Rv}/{AuthKey}", userNo, requestKey, rv, authKey);
      }
      catch (Exception ex) {
        Log.Fatal(ex,
                  "[EfCoreWorldDbManager] LogTradeAuthKeyHistoryFail - Exception {UserNo}/{RequestKey}/{Rv}/{AuthKey}",
                  userNo,
                  requestKey,
                  rv,
                  authKey);
      }
    });
    // DbLogQueue.Enqueue(task); //TODO FIX
  }


  public DbResult<List<ResultWorldTradeMarketCommand>> ListWorldTradeMarketCommand() {
    try {
      throw new NotImplementedException();
      //TODO implement ListWorldTradeMarketCommand
      //   const string spName = DbSchema.PaOperationPublic + ".uspListWorldTradeMarketCommand";
    }
    catch (Exception ex) {
      Log.Fatal(ex, "[EfCoreWorldDbManager] ListWorldTradeMarketCommand - Exception");
      return DbResult<List<ResultWorldTradeMarketCommand>>.Error(-1, GameErrorType.eErrNoDbInternalError);
    }
  }

  public DbResult SetWorldTradeMarketCommandResult(long commandNo,
                                                   byte status) {
    try {
      //TODO implement SetWorldTradeMarketCommandResult
      throw new NotImplementedException();
      DataHelper.NullCheck(commandNo, nameof(commandNo));
      DataHelper.NullCheck(status, nameof(status));
      
      var entry = TblCommandInfos.FirstOrDefault(x => x.CommandNo == commandNo);
      if (entry is null) return DbResult.Error(-1, GameErrorType.eErrNoCommandResult);
      entry.Status = status;
      var res = SaveChanges();
      if (res == 0) return DbResult.Error(-2, GameErrorType.eErrNoDbInternalError);
      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Fatal(ex, "[EfCoreWorldDbManager] SetWorldTradeMarketCommandResult - Exception ({commandNo}|{status})", commandNo, status);
      return DbResult.Error(-3, GameErrorType.eErrNoDbInternalError);
    }
  }



  public DbResult<ResCheckAuthKey> CheckAuthKey(long userNo,
                                                string certifiedKey) {
    try {
      DataHelper.ValidateUserNo(userNo);
      DataHelper.ValidateCertifiedKey(certifiedKey);
      
      var entry = TblTradeAuthKeys.FirstOrDefault(x => x.UserNo == userNo);
      var userResult = TblUserInformations
                               .Where(x => x.UserNo == userNo && x.IsValid == true)
                               .Select(x => new ResCheckAuthKey {
                                 ServiceType = x.ServiceType ?? 0,
                                 WorldNo = x.LastWorldNo ?? 0,
                                 UserNickname = x.UserNickname
                               })
                               .FirstOrDefault();
      if (userResult is null) {
        LogTradeAuthKeyHistoryFail(userNo, certifiedKey, -1, entry);
        return DbResult<ResCheckAuthKey>.Error(-1, GameErrorType.eErrNoPublisherFailAuthetication);
      }

      if (entry is null) {
        LogTradeAuthKeyHistoryFail(userNo, certifiedKey, -2, entry);
        return DbResult<ResCheckAuthKey>.Error(-2, GameErrorType.eErrNoPublisherFailAuthetication);
      }

      if (entry.CurKey is null || entry.PrevKey is null) {
        LogTradeAuthKeyHistoryFail(userNo, certifiedKey, -3, entry);
        return DbResult<ResCheckAuthKey>.Error(-3, GameErrorType.eErrNoPublisherFailAuthetication);
      }

      var certKey = new Guid(certifiedKey);
      if (entry.CurKey != certKey && entry.PrevKey != certKey) {
        LogTradeAuthKeyHistoryFail(userNo, certifiedKey, -4, entry);
        return DbResult<ResCheckAuthKey>.Error(-4, GameErrorType.eErrNoPublisherFailAuthetication);
      }

      return userResult;
    }
    catch (Exception ex) {
      Log.Fatal(ex, "[EfCoreWorldDbManager] CheckAuthKey - Exception ({userNo}|{certifiedKey})", userNo, certifiedKey);
      return DbResult<ResCheckAuthKey>.Error(-5, GameErrorType.eErrNoDbInternalError);
    }
  }



  public bool ClearTradeAuthHistory() {
    try {
      const string sql = "TRUNCATE TABLE [PaGamePrivate].[TblTradeAuthKeyHistory]";
      Database.ExecuteSqlRaw(sql);
      return true;
    }
    catch (Exception ex) {
      Log.Fatal(ex, "[EfCoreWorldDbManager] ClearTradeAuthHistory - Exception");
      return false;
    }
  }

  public int uspCheckSecondPwd(long? userNo,
                               string secondPW,
                               out int? resultCode) {
    throw new NotImplementedException();
  }

  public string uspGetSecondPwd(long? userNo) {
    throw new NotImplementedException();
  }

  public int uspAccessByTradeWeb(long? userNo,
                                 out int? serviceType,
                                 out int? worldNo,
                                 out bool? isAdmissionToSpeedServer,
                                 out bool? isUpdatePackageBuff,
                                 out string symNo,
                                 out int rv) {
    throw new NotImplementedException();
  }

  public string GetUserFamilyName(long userNo) {
    try {
      
      var entry = TblUserInformations
                          .Where(x => x.UserNo == userNo && x.IsValid == true)
                          .Select(x => x.UserNickname)
                          .FirstOrDefault();
      if (entry is null) return string.Empty;
      return entry;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreWorldDbManager] GetUserFamilyName Exception ({userNo})", userNo);
      return string.Empty;
    }
  }
}