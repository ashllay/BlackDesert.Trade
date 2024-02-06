using BlackDesert.Trade.Db.Entities.GameEntities;
using BlackDesert.Trade.Domain.Common;
using BlackDesert.Trade.Domain.Enum;
using BlackDesert.Trade.Domain.Models.Db;
using BlackDesert.Trade.Domain.Models.EfCore;
using Serilog;

namespace BlackDesert.Trade.Domain.DB.Context;

public partial class GameDbContext
{
  public int GetTradeRingBuff_Safe(long userNo) {
    try {
      var data = TblBuffCounts
                 .Where(x => x.UserNo == userNo && x.Type == 0)
                 .Select(x => x.Count)
                 .FirstOrDefault();
      var asInt = Convert.ToInt32(data);
      return asInt;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] GetTradeRingBuff_Safe - Exception ({userNo})", userNo);
      return 0;
    }
  }

  public DateTime GetValuePackageExpiration_Safe(long userNo) {
    try {
      return TblBriefUserInformations
             .Where(x => x.UserNo == userNo)
             .Select(x => x.PremiumPackageBuffExpiration)
             .FirstOrDefault() ?? DateTime.MinValue;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] GetValuePackageExpiration_Safe - Exception ({userNo})", userNo);
      return DateTime.MinValue;
    }
  }

  public DateTime GetChargeBuffExpiration_Safe(long userNo,
                                               byte type) {
    try {
      if (type == 0)
        return TblBriefUserInformations
               .Where(x => x.UserNo == userNo)
               .Select(x => x.StarterPackageBuffExpiration)
               .FirstOrDefault() ?? DateTime.MinValue;
      return TblBuffExpirationDates
             .Where(x => x.UserNo == userNo && x.Type == type)
             .Select(x => x.ExpirationDate)
             .FirstOrDefault() ?? DateTime.MinValue;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] GetChargeBuffExpiration_Safe - Exception ({userNo}|{type}", userNo, type);
      return DateTime.MinValue;
    }
  }

  public List<int> GetFamilySkillList_Safe(long userNo) {
    try {
      return TblFamilySkills
             .Where(x => x.UserNo == userNo)
             .Select(x => x.SkillNo)
             .ToList();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] GetFamilySkillList_Safe - Exception ({userNo})", userNo);
      return new List<int>();
    }
  }

  public int GetFamilyPoint_Safe(long userNo) {
    try {
      var point = 0;
      point +=
        (from ch in TblCharacterInformations
         where ch.UserNo == userNo && !ch.DeletedDate.HasValue && ch.IsSpecialCharacter == false && ch.Level < 56
         select new {
           Point = ch.Level
         })
        .Sum(x => x.Point);

      point +=
        (from ch in TblCharacterInformations
         where ch.UserNo == userNo && !ch.DeletedDate.HasValue && ch.IsSpecialCharacter == false && ch.Level >= 56 && ch.Level < 60
         select new {
           Point = ch.Level * 2
         })
        .Sum(x => x.Point);

      point +=
        (from ch in TblCharacterInformations
         where ch.UserNo == userNo && !ch.DeletedDate.HasValue && ch.IsSpecialCharacter == false && ch.Level >= 60
         select new {
           Point = ch.Level
         })
        .Sum(x => x.Point) * 5;

      point +=
        (from life in TblLifeExperiences
         join ch in TblCharacterInformations on life.UserNo equals ch.UserNo
         where !ch.DeletedDate.HasValue && ch.IsSpecialCharacter == false && life.Level > 30 && ch.UserNo == userNo
         select new {
           Point = life.Level / 2
         })
        .Sum(x => x.Point);

      point +=
        (from life in TblLifeExperiences
         join ch in TblCharacterInformations on life.UserNo equals ch.UserNo
         where !ch.DeletedDate.HasValue && ch.IsSpecialCharacter == false && life.Level > 80 && ch.UserNo == userNo
         select new {
           Point = life.Level / 2
         })
        .Sum(x => x.Point);

      point +=
        (from exp in TblExplorationPoints
         where userNo == exp.UserNo && exp.TerritoryKey == 0
         select new {
           Point = exp.AquiredPoint
         })
        .Sum(x => x.Point);

      point +=
        (from exp in TblMentalCardLists
         where userNo == exp.UserNo
         select exp)
        .Count();
      return point;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] GetFamilyPoint_Safe - Exception ({userNo})", userNo);
      return 0;
    }
  }

  public int GetMaidCount_Safe(long userNo) {
    try {
      return TblMaids
        .Count(x => x.OwnerUserNo == userNo && ConstantContainer.MaidCharacterNoList.Contains(x.CharacterKey));
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] GetMaidCount_Safe - Exception ({userNo})", userNo);
      return 0;
    }
  }


  ///////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////
  ///////////////////////////////////////////////////////////////////////////////////


  public bool ClearNoticeItemList() {
    try {
      const string sql = "TRUNCATE TABLE [PaGamePrivate].[tblWorldMarketNoticeItem]";
      var affected = Database.ExecuteSqlRaw(sql);
      return true;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] ClearNoticeItemList - Exception");
      return false;
    }
  }


  public DbResult InsertToNoticeItem_Unsafe(long registerTimeStamp,
                                            int keyType,
                                            int mainKey,
                                            int subKey,
                                            long price,
                                            long changedValue,
                                            short noticeType) {
    var noticeItem = new TblWorldMarketNoticeItem {
      RegistTimeStamp = registerTimeStamp,
      KeyType = keyType,
      MainKey = mainKey,
      SubKey = subKey,
      Price = price,
      ChangedValue = changedValue,
      NoticeType = noticeType,
    };
    TblWorldMarketNoticeItems.Add(noticeItem);
    var affected = SaveChanges();
    if (affected == 0) {
      return DbResult.Error(-53, GameErrorType.eErrNoRegistItemFail);
    }

    return DbResult.Success();
  }

  public DbResult UpdateCurrentPrice(int mainKey,
                                     int subKey,
                                     long pricePerOne) {
    try {
      var data = TblWorldMarketCurrentPrices
                 .Where(x => x.MainKey == mainKey && x.SubKey == subKey)
                 .FirstOrDefault();
      if (data is null) {
        var newPrice = new TblWorldMarketCurrentPrice {
          MainKey = mainKey,
          SubKey = subKey,
          PricePerOne = pricePerOne,
          LastUpdateTime = CultureModule.GetCustomTimeNow()
        };
        TblWorldMarketCurrentPrices.Add(newPrice);
      }
      else {
        data.PricePerOne = pricePerOne;
        data.LastUpdateTime = CultureModule.GetCustomTimeNow();
        TblWorldMarketCurrentPrices.Update(data);
      }

      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult.Error(-53, GameErrorType.eErrNoRegistItemFail);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] UpdateCurrentPrice - Exception ({mainKey}|{subKey}|{pricePerOne})", mainKey, subKey, pricePerOne);
      return DbResult.DbException(-55);
    }
  }

  public DbResult<List<ResultPayload>> ListFailPayload(int serviceType,
                                                       int worldNo,
                                                       long userNo) {
    try {
      var _1HourAgoDate = CultureModule.GetCustomTimeNow().AddHours(-1);
      var list = TblWorldMarketPayloadGameDbs
                 .Where(x => x.State != 2 && x.IsMovingTradeWeb == false && x.ServerNo == worldNo && x.NationCode == serviceType && x.UserNo == userNo && x.RegisterDate > _1HourAgoDate)
                 .ToList();

      var result = list
                   .Select(x => new ResultPayload {
                     _payload = x.Payload,
                     _state = x.State,
                     _nationCode = x.NationCode,
                     _serverNo = x.ServerNo,
                     _userNo = x.UserNo,
                     _keyType = x.KeyType,
                     _mainKey = x.MainKey,
                     _subKey = x.SubKey,
                     _isSealed = x.IsSealed,
                     _param0 = x.Param0,
                     _param1 = x.Param1,
                     _param2 = x.Param2,
                     _param3 = x.Param3,
                     _param4 = x.Param4,
                     _count = x.Count,
                     _isMovingTradeWeb = x.IsMovingTradeWeb,
                     _registerDate = x.RegisterDate,
                   })
                   .ToList();


      list.ForEach(x => x.IsMovingTradeWeb = true);
      TblWorldMarketPayloadGameDbs.UpdateRange(list);
      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult<List<ResultPayload>>.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] ListFailPayload - Exception ({serviceType}|{worldNo}|{userNo})", serviceType, worldNo, userNo);
      return DbResult<List<ResultPayload>>.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult UsingTicket(long? userNo,
                              byte? ticketType,
                              string ticketNo) {
    try {
      var parsedTicketNo = Guid.Parse(ticketNo);
      var ticket = TblWorldMarketTickets
                   .Where(x => x.UserNo == userNo && x.Type == ticketType && x.TicketNo.HasValue && x.TicketNo == parsedTicketNo)
                   .FirstOrDefault();
      if (ticket is null) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      ticket.TicketNo = null;
      TblWorldMarketTickets.Update(ticket);
      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] UsingTicket - Exception ({userNo}|{ticketType}|{ticketNo})", userNo, ticketType, ticketNo);
      return DbResult.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult WithdrawPayloadDestroy(long userNo,
                                         int nationCode,
                                         int serverNo,
                                         long payload,
                                         int mainKey,
                                         int subKey,
                                         bool isSealed,
                                         long count,
                                         long param0,
                                         long param1,
                                         long param2,
                                         long param3,
                                         long param4) {
    var payloadData = TblWorldMarketPayloadGameDbs
                      .Where(x => x.UserNo == userNo
                                  && x.NationCode == nationCode && x.ServerNo == serverNo && x.Payload == payload && x.MainKey == mainKey && x.SubKey == subKey && x.IsSealed == isSealed &&
                                  x.Count == count && x.Param0 == param0 && x.Param1 == param1 && x.Param2 == param2 && x.Param3 == param3 && x.Param4 == param4 && x.Type == 1 &&
                                  x.State == 0)
                      .FirstOrDefault();

    payloadData.State = -1;

    TblWorldMarketPayloadGameDbs.Update(payloadData);
    var affected = SaveChanges();
    if (affected == 0) {
      return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
    }

    return DbResult.Success();
  }

  public DbResult CompletePayloadForRegisterItem(int? serviceType,
                                                 int? worldNo,
                                                 long? userNo,
                                                 int? keyType,
                                                 int? itemKey,
                                                 int? enchantLevel,
                                                 long? itemCount,
                                                 bool? isSealed,
                                                 long? payload,
                                                 long? param0,
                                                 long? param1,
                                                 long? param2,
                                                 long? param3,
                                                 long? param4) {
    try {
      var payloadData = TblWorldMarketPayloadGameDbs
                        .Where(x => x.UserNo == userNo
                                    && x.NationCode == serviceType && x.ServerNo == worldNo && x.Payload == payload && x.MainKey == itemKey && x.SubKey == enchantLevel &&
                                    x.IsSealed == isSealed &&
                                    x.Count == itemCount && x.Param0 == param0 && x.Param1 == param1 && x.Param2 == param2 && x.Param3 == param3 && x.Param4 == param4 && x.Type == 0 &&
                                    x.State == 1)
                        .FirstOrDefault();


      if (payloadData is null) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      payloadData.State = 2;

      TblWorldMarketPayloadGameDbs.Update(payloadData);
      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreGameDbManager] uspCompletePayloadForRegisterItem - Exception ({serviceType}|{worldNo}|{userNo}|{keyType}|{itemKey}|{enchantLevel}|{itemCount}|{isSealed}|{payload}|{param0}|{param1}|{param2}|{param3}|{param4})",
                serviceType,
                worldNo,
                userNo,
                keyType,
                itemKey,
                enchantLevel,
                itemCount,
                isSealed,
                payload,
                param0,
                param1,
                param2,
                param3,
                param4);
      return DbResult.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult CheckPayloadForRegisterItem(int? serviceType,
                                              int? worldNo,
                                              long? userNo,
                                              int? keyType,
                                              int? itemKey,
                                              int? enchantLevel,
                                              long? itemCount,
                                              bool? isSealed,
                                              long? payload,
                                              long? param0,
                                              long? param1,
                                              long? param2,
                                              long? param3,
                                              long? param4) {
    try {
      var payloadData = TblWorldMarketPayloadGameDbs
                        .Where(x => x.UserNo == userNo
                                    && x.Payload == payload
                                    && x.MainKey == itemKey
                                    && x.SubKey == enchantLevel
                                    && x.IsSealed == isSealed
                                    && x.Count == itemCount
                                    && x.Param0 == param0
                                    && x.Param1 == param1
                                    && x.Param2 == param2
                                    && x.Param3 == param3
                                    && x.Param4 == param4
                                    && x.Type == 0
                                    && x.State == 1)
                        .Any();

      if (payloadData) {
        return DbResult.Success();
      }

      return DbResult.Error(-53, GameErrorType.eErrNoRegistItemFail);
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreGameDbManager] uspCheckPayloadForRegisterItem - Exception ({serviceType}|{worldNo}|{userNo}|{keyType}|{itemKey}|{enchantLevel}|{itemCount}|{isSealed}|{payload}|{param0}|{param1}|{param2}|{param3}|{param4})",
                serviceType,
                worldNo,
                userNo,
                keyType,
                itemKey,
                enchantLevel,
                itemCount,
                isSealed,
                payload,
                param0,
                param1,
                param2,
                param3,
                param4);
      return DbResult.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }


  public DbResult UpdateForWithdrawToWorldMarket(long payload) {
    try {
      var payloadData = TblWorldMarketPayloadGameDbs
                        .Where(x => x.Payload == payload && x.Type == 1 && x.State == 0)
                        .FirstOrDefault();
      if (payloadData is null) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      payloadData.State = 1;
      TblWorldMarketPayloadGameDbs.Update(payloadData);
      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult.Error(-53, GameErrorType.eErrNoWithdrawItemFail);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex, "[EfCoreGameDbManager] UpdateForWithdrawToWorldMarket - Exception ({payload})", payload);
      return DbResult.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult RemoveForDepositToWorldMarket(long payload,
                                                int nationCode,
                                                int serverNo,
                                                long userNo,
                                                int keyType,
                                                int mainKey,
                                                int subKey,
                                                bool isSealed,
                                                long param0,
                                                long param1,
                                                long param2,
                                                long param3,
                                                long param4,
                                                long count,
                                                short state) {
    try {
      var payloadData = new TblWorldMarketPayloadGameDb() {
        Payload = payload,
        NationCode = nationCode,
        ServerNo = serverNo,
        UserNo = userNo,
        KeyType = keyType,
        MainKey = mainKey,
        SubKey = subKey,
        IsSealed = isSealed,
        Param0 = param0,
        Param1 = param1,
        Param2 = param2,
        Param3 = param3,
        Param4 = param4,
        Count = count,
        State = state,
        Type = 0,
        // IsMovingTradeWeb = false,
        // RegisterDate = CultureModule.GetCustomTimeNow()
      };
      TblWorldMarketPayloadGameDbs.Add(payloadData);

      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreGameDbManager] uspRemoveForDepositToWorldMarket - Exception ({payload}|{nationCode}|{serverNo}|{userNo}|{keyType}|{mainKey}|{subKey}|{isSealed}|{param0}|{param1}|{param2}|{param3}|{param4}|{count}|{state})",
                payload,
                nationCode,
                serverNo,
                userNo,
                keyType,
                mainKey,
                subKey,
                isSealed,
                param0,
                param1,
                param2,
                param3,
                param4,
                count,
                state);
      return DbResult.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }

  public DbResult CreateForWithdrawToWorldMarket(long payload,
                                                 int nationCode,
                                                 int serverNo,
                                                 long userNo,
                                                 int keyType,
                                                 int mainKey,
                                                 int subKey,
                                                 bool isSealed,
                                                 long param0,
                                                 long param1,
                                                 long param2,
                                                 long param3,
                                                 long param4,
                                                 long count,
                                                 short state) {
    try {
      var payloadData = new TblWorldMarketPayloadGameDb() {
        Payload = payload,
        NationCode = nationCode,
        ServerNo = serverNo,
        UserNo = userNo,
        KeyType = keyType,
        MainKey = mainKey,
        SubKey = subKey,
        IsSealed = isSealed,
        Param0 = param0,
        Param1 = param1,
        Param2 = param2,
        Param3 = param3,
        Param4 = param4,
        Count = count,
        State = state,
        Type = 1,
        // IsMovingTradeWeb = false,
        // RegisterDate = CultureModule.GetCustomTimeNow()
      };
      TblWorldMarketPayloadGameDbs.Add(payloadData);

      var affected = SaveChanges();
      if (affected == 0) {
        return DbResult.Error(-53, GameErrorType.eErrNoDbInternalError);
      }

      return DbResult.Success();
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[EfCoreGameDbManager] uspRemoveForDepositToWorldMarket - Exception ({payload}|{nationCode}|{serverNo}|{userNo}|{keyType}|{mainKey}|{subKey}|{isSealed}|{param0}|{param1}|{param2}|{param3}|{param4}|{count}|{state})",
                payload,
                nationCode,
                serverNo,
                userNo,
                keyType,
                mainKey,
                subKey,
                isSealed,
                param0,
                param1,
                param2,
                param3,
                param4,
                count,
                state);
      return DbResult.Error(-55, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue());
    }
  }
}