using System.Data;
using BlackDesert.Trade.Db;
using BlackDesert.Trade.Domain.DB.Abstract;
using BlackDesert.Trade.Domain.DB.Helper;
using Microsoft.Data.SqlClient;

namespace BlackDesert.Trade.Business.Manager.DB;

public sealed class TradeDbManager : BaseDbManager
{
  private static TradeDbManager? _instance;
  private TradeDbManager() : base(DbConnectionContainer.This.ConnectionStrings.Trade) { }

  public static TradeDbManager This {
    get {
      _instance ??= new TradeDbManager();
      return _instance;
    }
  }

  

  
 

  public int uspPrepareWithdrawFromWorldMarket(int? nationCode,
                                               int? serverNo,
                                               long? userNo,
                                               int? keyType,
                                               int? mainKey,
                                               int? subKey,
                                               bool? isSealed,
                                               long? count,
                                               long? itemWeight,
                                               out long? payload,
                                               out long? param0,
                                               out long? param1,
                                               out long? param2,
                                               out long? param3,
                                               out long? param4,
                                               out string symNo,
                                               out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspPrepareWithdrawFromWorldMarket";
    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@keyType", keyType));
    parameters.Add(new SqlParameter("@mainKey", mainKey));
    parameters.Add(new SqlParameter("@subKey", subKey));
    parameters.Add(new SqlParameter("@isSealed", isSealed));
    parameters.Add(new SqlParameter("@count", count));
    parameters.Add(new SqlParameter("@itemWeight", itemWeight));
    parameters.Add(new SqlParameter("@payload", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param0", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param3", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param4", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();
    conn.Close();
    payload = cmd.GetParamValue<long>("payload");
    param0 = cmd.GetParamValue<long>("param0");
    param1 = cmd.GetParamValue<long>("param1");
    param2 = cmd.GetParamValue<long>("param2");
    param3 = cmd.GetParamValue<long>("param3");
    param4 = cmd.GetParamValue<long>("param4");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }


 //
  


  // public int uspGetWithDrawPayLoadState(long? userNo,
  //                                       int? nationCode,
  //                                       int? serverNo,
  //                                       long? payload,
  //                                       int? mainKey,
  //                                       int? subKey,
  //                                       bool? isSealed,
  //                                       long? count,
  //                                       long? param0,
  //                                       long? param1,
  //                                       long? param2,
  //                                       long? param3,
  //                                       long? param4,
  //                                       out short? state,
  //                                       out string symNo,
  //                                       out int rv) {
  //   const string spName = DbSchema.PaGamePublic + ".uspGetWithDrawPayLoadState";
  //
  //   var parameters = new List<SqlParameter>();
  //   parameters.Add(new SqlParameter("@userNo", userNo));
  //   parameters.Add(new SqlParameter("@nationCode", nationCode));
  //   parameters.Add(new SqlParameter("@serverNo", serverNo));
  //   parameters.Add(new SqlParameter("@payload", payload));
  //   parameters.Add(new SqlParameter("@mainKey", mainKey));
  //   parameters.Add(new SqlParameter("@subKey", subKey));
  //   parameters.Add(new SqlParameter("@isSealed", isSealed));
  //   parameters.Add(new SqlParameter("@count", count));
  //   parameters.Add(new SqlParameter("@param0", param0));
  //   parameters.Add(new SqlParameter("@param1", param1));
  //   parameters.Add(new SqlParameter("@param2", param2));
  //   parameters.Add(new SqlParameter("@param3", param3));
  //   parameters.Add(new SqlParameter("@param4", param4));
  //   parameters.Add(new SqlParameter("@state", SqlDbType.SmallInt) { Direction = ParameterDirection.Output });
  //   parameters.Add(DbConst.SymNo());
  //   parameters.Add(DbConst.Rv());
  //
  //   using var conn = OpenConnection();
  //   using var cmd = CreateSpCommand(conn, spName, parameters);
  //   var num = cmd.ExecuteNonQuery();
  //   conn.Close();
  //   state = cmd.GetParamValue<short>("state");
  //   symNo = cmd.GetSymNo();
  //   rv = cmd.GetRv();
  //   return num;
  // }
  
 

  // public int uspPrepareDepositToWorldMarket(int? nationCode,
  //                                           int? serverNo,
  //                                           long? userNo,
  //                                           int? keyType,
  //                                           int? mainKey,
  //                                           int? subKey,
  //                                           long? param0,
  //                                           long? param1,
  //                                           long? param2,
  //                                           long? param3,
  //                                           long? param4,
  //                                           long? count,
  //                                           bool? isSealed,
  //                                           long? itemWeight,
  //                                           long? maxWeight,
  //                                           out long? payload,
  //                                           out bool? isNotError,
  //                                           out string symNo,
  //                                           out int rv) {
  //   const string spName = DbSchema.PaGamePublic + ".uspPrepareDepositToWorldMarket";
  //
  //   var parameters = new List<SqlParameter>();
  //   parameters.Add(new SqlParameter("@nationCode", nationCode));
  //   parameters.Add(new SqlParameter("@serverNo", serverNo));
  //   parameters.Add(new SqlParameter("@userNo", userNo));
  //   parameters.Add(new SqlParameter("@keyType", keyType));
  //   parameters.Add(new SqlParameter("@mainKey", mainKey));
  //   parameters.Add(new SqlParameter("@subKey", subKey));
  //   parameters.Add(new SqlParameter("@param0", param0));
  //   parameters.Add(new SqlParameter("@param1", param1));
  //   parameters.Add(new SqlParameter("@param2", param2));
  //   parameters.Add(new SqlParameter("@param3", param3));
  //   parameters.Add(new SqlParameter("@param4", param4));
  //   parameters.Add(new SqlParameter("@count", count));
  //   parameters.Add(new SqlParameter("@isSealed", isSealed));
  //   parameters.Add(new SqlParameter("@itemWeight", itemWeight));
  //   parameters.Add(new SqlParameter("@maxWeight", maxWeight));
  //   parameters.Add(new SqlParameter("@payload", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
  //   parameters.Add(new SqlParameter("@isNotError", SqlDbType.Bit) { Direction = ParameterDirection.Output });
  //   parameters.Add(DbConst.SymNo());
  //   parameters.Add(DbConst.Rv());
  //
  //   using var conn = OpenConnection();
  //   using var cmd = CreateSpCommand(conn, spName, parameters);
  //   var num = cmd.ExecuteNonQuery();
  //   conn.Close();
  //   payload = cmd.GetParamValue<long>("payload");
  //   isNotError = cmd.GetParamValue<bool>("isNotError");
  //   symNo = cmd.GetSymNo();
  //   rv = cmd.GetRv();
  //   return num;
  // }

  


 

  
  

  

  public int uspUpdateWorldMarketPrice(int? keyType,
                                       int? mainKey,
                                       int? subKey,
                                       long? newPrice,
                                       long? newGraphPrice,
                                       byte? fluctuationType,
                                       long? fluctuationPrice,
                                       long? newStockCount,
                                       out string symNo,
                                       out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspUpdateWorldMarketPrice";

    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@keyType", keyType));
    parameters.Add(new SqlParameter("@mainKey", mainKey));
    parameters.Add(new SqlParameter("@subKey", subKey));
    parameters.Add(new SqlParameter("@newPrice", newPrice));
    parameters.Add(new SqlParameter("@newGraphPrice", newGraphPrice));
    parameters.Add(new SqlParameter("@fluctuationType", fluctuationType));
    parameters.Add(new SqlParameter("@fluctuationPrice", fluctuationPrice));
    parameters.Add(new SqlParameter("@newStockCount", newStockCount));
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }



  public int uspUpdateWorldMarketGroupPrice(long? priceGroupKey,
                                            long? newPrice,
                                            long? newGraphPrice,
                                            byte? fluctuationType,
                                            long? fluctuationPrice,
                                            out string symNo,
                                            out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspUpdateWorldMarketGroupPrice";

    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@priceGroupKey", priceGroupKey));
    parameters.Add(new SqlParameter("@newPrice", newPrice));
    parameters.Add(new SqlParameter("@newGraphPrice", newGraphPrice));
    parameters.Add(new SqlParameter("@fluctuationType", fluctuationType));
    parameters.Add(new SqlParameter("@fluctuationPrice", fluctuationPrice));
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }






  public int uspBuyBiddingFromWorldMarket(int? nationCode,
                                          int? serverNo,
                                          long? userNo,
                                          int? buyKeyType,
                                          int? buyMainKey,
                                          int? buySubKey,
                                          long? buyPrice,
                                          long? buyCount,
                                          int? buyChooseKey,
                                          int? metarialMainKey,
                                          long? buyerMetarialCount,
                                          double? biddingRate,
                                          long? weightPerOne,
                                          long? maxWeight,
                                          long? retryBiddingNo,
                                          out long? walletMoney,
                                          out long? realBuyCount,
                                          out long? totalMoneyCount,
                                          out long? sellNo,
                                          out long? sellUserNo,
                                          out long? sellUserId,
                                          out long? sellLeftCount,
                                          out long? raceCount,
                                          out int? stopType,
                                          out long? beforeCount1,
                                          out long? afterCount1,
                                          out long? beforeCount2,
                                          out long? afterCount2,
                                          out long? beforeCount3,
                                          out long? afterCount3,
                                          out long? beforeCount4,
                                          out long? afterCount4,
                                          out long? leftCount,
                                          out long? registerMoneyCount,
                                          out long? boughtCount,
                                          out string symNo,
                                          out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspBuyBiddingFromWorldMarket";
    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@buyKeyType", buyKeyType));
    parameters.Add(new SqlParameter("@buyMainKey", buyMainKey));
    parameters.Add(new SqlParameter("@buySubKey", buySubKey));
    parameters.Add(new SqlParameter("@buyPrice", buyPrice));
    parameters.Add(new SqlParameter("@buyCount", buyCount));
    parameters.Add(new SqlParameter("@buyChooseKey", buyChooseKey));
    parameters.Add(new SqlParameter("@metarialMainKey", metarialMainKey));
    parameters.Add(new SqlParameter("@buyerMetarialCount", buyerMetarialCount));
    parameters.Add(new SqlParameter("@biddingRate", biddingRate));
    parameters.Add(new SqlParameter("@weightPerOne", weightPerOne));
    parameters.Add(new SqlParameter("@maxWeight", maxWeight));
    parameters.Add(new SqlParameter("@retryBiddingNo", retryBiddingNo));
    parameters.Add(new SqlParameter("@walletMoney", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@realBuyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@totalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@sellNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@sellUserNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@sellUserId", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@sellLeftCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@raceCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@stopType", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount3", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount3", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount4", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount4", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@leftCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@registerMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@boughtCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    walletMoney = cmd.GetParamValue<long>("walletMoneynt");
    realBuyCount = cmd.GetParamValue<long>("realBuyCount");
    totalMoneyCount = cmd.GetParamValue<long>("totalMoneyCount");
    sellNo = cmd.GetParamValue<long>("sellNo");
    sellUserNo = cmd.GetParamValue<long>("sellUserNo");
    sellUserId = cmd.GetParamValue<long>("sellUserId");
    sellLeftCount = cmd.GetParamValue<long>("sellLeftCount");
    raceCount = cmd.GetParamValue<long>("raceCount");
    stopType = cmd.GetParamValue<int>("stopType");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    beforeCount2 = cmd.GetParamValue<long>("beforeCount2");
    afterCount2 = cmd.GetParamValue<long>("afterCount2");
    beforeCount3 = cmd.GetParamValue<long>("beforeCount3");
    afterCount3 = cmd.GetParamValue<long>("afterCount3");
    beforeCount4 = cmd.GetParamValue<long>("beforeCount4");
    afterCount4 = cmd.GetParamValue<long>("afterCount4");
    leftCount = cmd.GetParamValue<long>("leftCount");
    registerMoneyCount = cmd.GetParamValue<long>("registerMoneyCount");
    boughtCount = cmd.GetParamValue<long>("boughtCount");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspSellBiddingToWorldMarket(int? nationCode,
                                         int? serverNo,
                                         long? userNo,
                                         int? sellKeyType,
                                         int? sellMainKey,
                                         int? sellSubKey,
                                         int? sellMainCategory,
                                         bool? isSealed,
                                         long? sellPrice,
                                         long? sellCount,
                                         int? sellChooseKey,
                                         int? metarialMainKey,
                                         long? needMetarialCount,
                                         double? biddingRate,
                                         bool? isNoticeItem,
                                         long? weightPerOne,
                                         long? maxWeight,
                                         long? maxPearlItemLimitedCount,
                                         DateTime? currentTime,
                                         byte? applyRingBuffType,
                                         long? waitNo,
                                         bool? isRingBuff,
                                         long? retryBiddingNo,
                                         out long? walletMoney,
                                         out long? realSellCount,
                                         out long? totalMoneyCount,
                                         out long? originalTotalMoneyCount,
                                         out DateTime? packageExpiration,
                                         out long? buyNo,
                                         out long? buyUserNo,
                                         out long? buyUserId,
                                         out long? buyLeftCount,
                                         out int? stopType,
                                         out bool? isNextApplyRingBuff,
                                         out long? resultWaitNo,
                                         out long? raceCount,
                                         out long? beforeCount1,
                                         out long? afterCount1,
                                         out long? beforeCount2,
                                         out long? afterCount2,
                                         out long? beforeCount3,
                                         out long? afterCount3,
                                         out long? beforeCount4,
                                         out long? afterCount4,
                                         out long? soldCount,
                                         out long? leftCount,
                                         out long? moneyCount,
                                         out long? calculateMoney,
                                         out bool? isCalculateRingBuff,
                                         out string symNo,
                                         out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspSellBiddingToWorldMarket";
    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@sellKeyType", sellKeyType));
    parameters.Add(new SqlParameter("@sellMainKey", sellMainKey));
    parameters.Add(new SqlParameter("@sellSubKey", sellSubKey));
    parameters.Add(new SqlParameter("@sellMainCategory", sellMainCategory));
    parameters.Add(new SqlParameter("@isSealed", isSealed));
    parameters.Add(new SqlParameter("@sellPrice", sellPrice));
    parameters.Add(new SqlParameter("@sellCount", sellCount));
    parameters.Add(new SqlParameter("@sellChooseKey", sellChooseKey));
    parameters.Add(new SqlParameter("@metarialMainKey", metarialMainKey));
    parameters.Add(new SqlParameter("@needMetarialCount", needMetarialCount));
    parameters.Add(new SqlParameter("@biddingRate", biddingRate));
    parameters.Add(new SqlParameter("@isNoticeItem", isNoticeItem));
    parameters.Add(new SqlParameter("@weightPerOne", weightPerOne));
    parameters.Add(new SqlParameter("@maxWeight", maxWeight));
    parameters.Add(new SqlParameter("@maxPearlItemLimitedCount", maxPearlItemLimitedCount));
    parameters.Add(new SqlParameter("@currentTime", currentTime));
    parameters.Add(new SqlParameter("@applyRingBuffType", applyRingBuffType));
    parameters.Add(new SqlParameter("@waitNo", waitNo));
    parameters.Add(new SqlParameter("@isRingBuff", isRingBuff));
    parameters.Add(new SqlParameter("@retryBiddingNo", retryBiddingNo));
    parameters.Add(new SqlParameter("@walletMoney", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@realSellCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@totalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@originalTotalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@packageExpiration", SqlDbType.DateTime) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@buyNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@buyUserNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@buyUserId", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@buyLeftCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@stopType", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isNextApplyRingBuff", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@resultWaitNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@raceCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount3", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount3", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount4", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount4", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@soldCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@leftCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@moneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@calculateMoney", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isCalculateRingBuff", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    walletMoney = cmd.GetParamValue<long>("walletMoneynt");
    realSellCount = cmd.GetParamValue<long>("realSellCount");
    totalMoneyCount = cmd.GetParamValue<long>("totalMoneyCount");
    originalTotalMoneyCount = cmd.GetParamValue<long>("originalTotalMoneyCount");
    packageExpiration = cmd.GetParamValue<DateTime>("packageExpiration");
    buyNo = cmd.GetParamValue<long>("buyNo");
    buyUserNo = cmd.GetParamValue<long>("buyUserNo");
    buyUserId = cmd.GetParamValue<long>("buyUserId");
    buyLeftCount = cmd.GetParamValue<long>("buyLeftCount");
    stopType = cmd.GetParamValue<int>("stopType");
    isNextApplyRingBuff = cmd.GetParamValue<bool>("isNextApplyRingBuff");
    resultWaitNo = cmd.GetParamValue<long>("resultWaitNo");
    raceCount = cmd.GetParamValue<long>("raceCount");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    beforeCount2 = cmd.GetParamValue<long>("beforeCount2");
    afterCount2 = cmd.GetParamValue<long>("afterCount2");
    beforeCount3 = cmd.GetParamValue<long>("beforeCount3");
    afterCount3 = cmd.GetParamValue<long>("afterCount3");
    beforeCount4 = cmd.GetParamValue<long>("beforeCount4");
    afterCount4 = cmd.GetParamValue<long>("afterCount4");
    soldCount = cmd.GetParamValue<long>("soldCount");
    leftCount = cmd.GetParamValue<long>("leftCount");
    moneyCount = cmd.GetParamValue<long>("moneyCount");
    calculateMoney = cmd.GetParamValue<long>("calculateMoney");
    isCalculateRingBuff = cmd.GetParamValue<bool>("isCalculateRingBuff");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

 
  
  

  public int uspCalculateBiddingBuy(long? buyNo,
                                    int? keyType,
                                    int? mainKey,
                                    int? subKey,
                                    int? nationCode,
                                    int? serverNo,
                                    long? userNo,
                                    long? weightPerOne,
                                    long? maxWeight,
                                    out long? boughtCount,
                                    out int? chooseSubKey,
                                    out bool? isDelete,
                                    out long? beforeCount1,
                                    out long? afterCount1,
                                    out string symNo,
                                    out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspCalculateBiddingBuy";
    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@buyNo", buyNo));
    parameters.Add(new SqlParameter("@keyType", keyType));
    parameters.Add(new SqlParameter("@mainKey", mainKey));
    parameters.Add(new SqlParameter("@subKey", subKey));
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@weightPerOne", weightPerOne));
    parameters.Add(new SqlParameter("@maxWeight", maxWeight));
    parameters.Add(new SqlParameter("@boughtCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@chooseSubKey", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isDelete", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();
    conn.Close();
    boughtCount = cmd.GetParamValue<long>("boughtCount");
    chooseSubKey = cmd.GetParamValue<int>("chooseSubKey");
    isDelete = cmd.GetParamValue<bool>("isDelete");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspWithdrawBiddingBuy(long? buyNo,
                                   int? keyType,
                                   int? mainKey,
                                   int? subKey,
                                   long? count,
                                   int? nationCode,
                                   int? serverNo,
                                   long? userNo,
                                   int? chooseSubKey,
                                   out long? differenceMoney,
                                   out long? withdrawMoneyCount,
                                   out bool? isDelete,
                                   out long? beforeCount1,
                                   out long? afterCount1,
                                   out string symNo,
                                   out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspWithdrawBiddingBuy";
    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@buyNo", buyNo));
    parameters.Add(new SqlParameter("@keyType", keyType));
    parameters.Add(new SqlParameter("@mainKey", mainKey));
    parameters.Add(new SqlParameter("@subKey", subKey));
    parameters.Add(new SqlParameter("@count", count));
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@chooseSubKey", chooseSubKey));
    parameters.Add(new SqlParameter("@differenceMoney", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@withdrawMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isDelete", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    differenceMoney = cmd.GetParamValue<long>("differenceMoney");
    withdrawMoneyCount = cmd.GetParamValue<long>("withdrawMoneyCount");
    isDelete = cmd.GetParamValue<bool>("isDelete");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspCalculateBiddingSell(long? sellNo,
                                     int? keyType,
                                     int? mainKey,
                                     int? subKey,
                                     int? mainCategory,
                                     bool? isSealed,
                                     int? nationCode,
                                     int? serverNo,
                                     long? userNo,
                                     int? chooseSubKey,
                                     out long? soldCount,
                                     out bool? isDelete,
                                     out long? amountMoney,
                                     out long? originalTotalMoneyCount,
                                     out DateTime? packageExpiration,
                                     out bool? isAppledRingBuff,
                                     out long? beforeCount1,
                                     out long? afterCount1,
                                     out string symNo,
                                     out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspCalculateBiddingSell";

    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@sellNo", sellNo));
    parameters.Add(new SqlParameter("@keyType", keyType));
    parameters.Add(new SqlParameter("@mainKey", mainKey));
    parameters.Add(new SqlParameter("@subKey", subKey));
    parameters.Add(new SqlParameter("@mainCategory", mainCategory));
    parameters.Add(new SqlParameter("@isSealed", isSealed));
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@chooseSubKey", chooseSubKey));
    parameters.Add(new SqlParameter("@soldCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isDelete", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@amountMoney", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@originalTotalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@packageExpiration", SqlDbType.DateTime) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isAppledRingBuff", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    soldCount = cmd.GetParamValue<long>("soldCount");
    isDelete = cmd.GetParamValue<bool>("isDelete");
    amountMoney = cmd.GetParamValue<long>("amountMoney");
    originalTotalMoneyCount = cmd.GetParamValue<long>("originalTotalMoneyCount");
    packageExpiration = cmd.GetParamValue<DateTime>("packageExpiration");
    isAppledRingBuff = cmd.GetParamValue<bool>("isAppledRingBuff");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspWithdrawBiddingSell(long? sellNo,
                                    int? keyType,
                                    int? mainKey,
                                    int? subKey,
                                    bool? isSealed,
                                    long? count,
                                    int? nationCode,
                                    int? serverNo,
                                    long? userNo,
                                    long? weightPerOne,
                                    long? maxWeight,
                                    long? maxPearlItemLimitedCount,
                                    DateTime? currentTime,
                                    out int? chooseSubKey,
                                    out bool? isDelete,
                                    out long? beforeCount1,
                                    out long? afterCount1,
                                    out string symNo,
                                    out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspWithdrawBiddingSell";

    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@sellNo", sellNo));
    parameters.Add(new SqlParameter("@keyType", keyType));
    parameters.Add(new SqlParameter("@mainKey", mainKey));
    parameters.Add(new SqlParameter("@subKey", subKey));
    parameters.Add(new SqlParameter("@isSealed", isSealed));
    parameters.Add(new SqlParameter("@count", count));
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@weightPerOne", weightPerOne));
    parameters.Add(new SqlParameter("@maxWeight", maxWeight));
    parameters.Add(new SqlParameter("@maxPearlItemLimitedCount", maxPearlItemLimitedCount));
    parameters.Add(new SqlParameter("@currentTime", currentTime));
    parameters.Add(new SqlParameter("@chooseSubKey", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isDelete", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    chooseSubKey = cmd.GetParamValue<int>("chooseSubKey");
    isDelete = cmd.GetParamValue<bool>("isDelete");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspSellToWorldMarket(int? nationCode,
                                  int? serverNo,
                                  long? userNo,
                                  int? sellKeyType,
                                  int? sellMainKey,
                                  int? sellSubKey,
                                  int? sellMainCategory,
                                  bool? isSealed,
                                  long? sellPrice,
                                  long? sellCount,
                                  int? sellChooseKey,
                                  int? metarialMainKey,
                                  long? needMetarialCount,
                                  double? biddingRate,
                                  bool? isNoticeItem,
                                  long? weightPerOne,
                                  long? maxPearlItemLimitedCount,
                                  DateTime? currentTime,
                                  byte? applyRingBuffType,
                                  long? waitNo,
                                  out long? sellPricePerOne,
                                  out long? realSellCount,
                                  out long? totalMoneyCount,
                                  out long? originalTotalMoneyCount,
                                  out DateTime? packageExpiration,
                                  out long? sellNo,
                                  out bool? isAppledRingBuff,
                                  out long? beforeCount1,
                                  out long? afterCount1,
                                  out long? beforeCount2,
                                  out long? afterCount2,
                                  out string symNo,
                                  out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspSellToWorldMarket";

    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@sellKeyType", sellKeyType));
    parameters.Add(new SqlParameter("@sellMainKey", sellMainKey));
    parameters.Add(new SqlParameter("@sellSubKey", sellSubKey));
    parameters.Add(new SqlParameter("@sellMainCategory", sellMainCategory));
    parameters.Add(new SqlParameter("@isSealed", isSealed));
    parameters.Add(new SqlParameter("@sellPrice", sellPrice));
    parameters.Add(new SqlParameter("@sellCount", sellCount));
    parameters.Add(new SqlParameter("@sellChooseKey", sellChooseKey));
    parameters.Add(new SqlParameter("@metarialMainKey", metarialMainKey));
    parameters.Add(new SqlParameter("@needMetarialCount", needMetarialCount));
    parameters.Add(new SqlParameter("@biddingRate", biddingRate));
    parameters.Add(new SqlParameter("@isNoticeItem", isNoticeItem));
    parameters.Add(new SqlParameter("@weightPerOne", weightPerOne));
    parameters.Add(new SqlParameter("@maxPearlItemLimitedCount", maxPearlItemLimitedCount));
    parameters.Add(new SqlParameter("@currentTime", currentTime));
    parameters.Add(new SqlParameter("@applyRingBuffType", applyRingBuffType));
    parameters.Add(new SqlParameter("@waitNo", waitNo));
    parameters.Add(new SqlParameter("@sellPricePerOne", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@realSellCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@totalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@originalTotalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@packageExpiration", SqlDbType.DateTime) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@sellNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isAppledRingBuff", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    sellPricePerOne = cmd.GetParamValue<long>("sellPricePerOne");
    realSellCount = cmd.GetParamValue<long>("realSellCount");
    totalMoneyCount = cmd.GetParamValue<long>("totalMoneyCount");
    originalTotalMoneyCount = cmd.GetParamValue<long>("originalTotalMoneyCount");
    packageExpiration = cmd.GetParamValue<DateTime>("packageExpiration");
    sellNo = cmd.GetParamValue<long>("sellNo");
    isAppledRingBuff = cmd.GetParamValue<bool>("isAppledRingBuff");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    beforeCount2 = cmd.GetParamValue<long>("beforeCount2");
    afterCount2 = cmd.GetParamValue<long>("afterCount2");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspBuyFromWorldMarket(int? nationCode,
                                   int? serverNo,
                                   long? userNo,
                                   int? buyKeyType,
                                   int? buyMainKey,
                                   int? buySubKey,
                                   long? buyPrice,
                                   long? buyCount,
                                   int? buyChooseKey,
                                   int? metarialMainKey,
                                   long? needMetarialCount,
                                   double? biddingRate,
                                   bool? isCashCategory,
                                   long? weightPerOne,
                                   long? maxWeight,
                                   out long? realBuyCount,
                                   out long? totalMoneyCount,
                                   out long? buyNo,
                                   out long? biddingMoneyCount,
                                   out long? beforeCount1,
                                   out long? afterCount1,
                                   out long? beforeCount2,
                                   out long? afterCount2,
                                   out string symNo,
                                   out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspBuyFromWorldMarket";
    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@nationCode", nationCode));
    parameters.Add(new SqlParameter("@serverNo", serverNo));
    parameters.Add(new SqlParameter("@userNo", userNo));
    parameters.Add(new SqlParameter("@buyKeyType", buyKeyType));
    parameters.Add(new SqlParameter("@buyMainKey", buyMainKey));
    parameters.Add(new SqlParameter("@buySubKey", buySubKey));
    parameters.Add(new SqlParameter("@buyPrice", buyPrice));
    parameters.Add(new SqlParameter("@buyCount", buyCount));
    parameters.Add(new SqlParameter("@buyChooseKey", buyChooseKey));
    parameters.Add(new SqlParameter("@metarialMainKey", metarialMainKey));
    parameters.Add(new SqlParameter("@needMetarialCount", needMetarialCount));
    parameters.Add(new SqlParameter("@biddingRate", biddingRate));
    parameters.Add(new SqlParameter("@isCashCategory", isCashCategory));
    parameters.Add(new SqlParameter("@weightPerOne", weightPerOne));
    parameters.Add(new SqlParameter("@maxWeight", maxWeight));
    parameters.Add(new SqlParameter("@realBuyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@totalMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@buyNo", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@biddingMoneyCount", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    realBuyCount = cmd.GetParamValue<long>("realBuyCount");
    totalMoneyCount = cmd.GetParamValue<long>("totalMoneyCount");
    buyNo = cmd.GetParamValue<long>("buyNo");
    biddingMoneyCount = cmd.GetParamValue<long>("biddingMoneyCount");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    beforeCount2 = cmd.GetParamValue<long>("beforeCount2");
    afterCount2 = cmd.GetParamValue<long>("afterCount2");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  public int uspProcessDepositToWorldMarket(long? payload,
                                            out short? reason,
                                            out int? keyType,
                                            out int? mainKey,
                                            out int? subKey,
                                            out bool? isSealed,
                                            out long? param0,
                                            out long? param1,
                                            out long? param2,
                                            out long? param3,
                                            out long? param4,
                                            out long? count,
                                            out long? beforeCount1,
                                            out long? afterCount1,
                                            out string symNo,
                                            out int rv) {
    const string spName = DbSchema.PaGamePublic + ".uspProcessDepositToWorldMarket";

    var parameters = new List<SqlParameter>();
    parameters.Add(new SqlParameter("@payload", payload));
    parameters.Add(new SqlParameter("@reason", SqlDbType.SmallInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@keyType", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@mainKey", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@subKey", SqlDbType.Int) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@isSealed", SqlDbType.Bit) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param0", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param2", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param3", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@param4", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@count", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
    parameters.Add(DbConst.SymNo());
    parameters.Add(DbConst.Rv());

    using var conn = OpenConnection();
    using var cmd = CreateSpCommand(conn, spName, parameters);
    var num = cmd.ExecuteNonQuery();

    conn.Close();
    reason = cmd.GetParamValue<short>("reason");
    keyType = cmd.GetParamValue<int>("keyType");
    mainKey = cmd.GetParamValue<int>("mainKey");
    subKey = cmd.GetParamValue<int>("subKey");
    isSealed = cmd.GetParamValue<bool>("isSealed");
    param0 = cmd.GetParamValue<long>("param0");
    param1 = cmd.GetParamValue<long>("param1");
    param2 = cmd.GetParamValue<long>("param2");
    param3 = cmd.GetParamValue<long>("param3");
    param4 = cmd.GetParamValue<long>("param4");
    count = cmd.GetParamValue<long>("count");
    beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
    afterCount1 = cmd.GetParamValue<long>("afterCount1");
    symNo = cmd.GetSymNo();
    rv = cmd.GetRv();
    return num;
  }

  // public int uspProcessWithdrawFromWorldMarket(long? payload,
  //                                              out short? reason,
  //                                              out long? beforeCount1,
  //                                              out long? afterCount1,
  //                                              out string symNo,
  //                                              out int rv) {
  //   const string spName = DbSchema.PaGamePublic + ".uspProcessWithdrawFromWorldMarket";
  //
  //   var parameters = new List<SqlParameter>();
  //   parameters.Add(new SqlParameter("@payload", payload));
  //   parameters.Add(new SqlParameter("@reason", SqlDbType.SmallInt) { Direction = ParameterDirection.Output });
  //   parameters.Add(new SqlParameter("@beforeCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
  //   parameters.Add(new SqlParameter("@afterCount1", SqlDbType.BigInt) { Direction = ParameterDirection.Output });
  //   parameters.Add(DbConst.SymNo());
  //   parameters.Add(DbConst.Rv());
  //
  //   using var conn = OpenConnection();
  //   using var cmd = CreateSpCommand(conn, spName, parameters);
  //   var num = cmd.ExecuteNonQuery();
  //
  //   conn.Close();
  //   reason = cmd.GetParamValue<short>("reason");
  //   beforeCount1 = cmd.GetParamValue<long>("beforeCount1");
  //   afterCount1 = cmd.GetParamValue<long>("afterCount1");
  //   symNo = cmd.GetSymNo();
  //   rv = cmd.GetRv();
  //   return num;
  // }

 
}












