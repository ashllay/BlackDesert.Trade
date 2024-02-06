namespace BlackDesert.Trade.Business.Manager;

public static class TradeDbWrapper
{
  // public static CommonDBResult<uspFindUser_Result> FindUser(
  //   int? serverNo,
  //   string userNickName) {
  //   var user = new CommonDBResult<uspFindUser_Result>();
  //   try {
  //     user.list = TradeDbManager.This.uspFindUser(serverNo,
  //                                                 userNickName,
  //                                                 out var symNo,
  //                                                 out var rv)
  //                               .ToList();
  //     user.resultCode = Convert.ToInt32(rv);
  //     user.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     user.resultCode = 1;
  //     user.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspFindUser({0}/{1}) Exception : {2}", serverNo, userNickName, ex), "ERROR");
  //   }
  //
  //   return user;
  // }

  // public static CommonDBResult<ResultWorldMarketMyWallet> ListWorldMarketMyWallet_Unsafe(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo) {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarketMyWallet>();
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListWorldMarketMyWallet(nationCode, serverNo, userNo, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketMyWallet({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<uspPersonalTradeList_Result> PersonalTradeList(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo) {
  //   var commonDbResult = new CommonDBResult<uspPersonalTradeList_Result>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspPersonalTradeList(nationCode, serverNo, userNo, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspPersonalTradeList({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonResult UpdateMyWalletWeight(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo,
  //   long totalWeight) {
  //   var commonResult = new CommonResult();
  //
  //   try {
  //     TradeDbManager.This.uspUpdateMyWalletWeight(nationCode,
  //                                                 serverNo,
  //                                                 userNo,
  //                                                 totalWeight,
  //                                                 out var symNo,
  //                                                 out var rv);
  //     commonResult.resultCode = Convert.ToInt32(rv);
  //     commonResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonResult.resultCode = 1;
  //     commonResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Error] uspUpdateMyWalletWeight({0}/{1}/{2}/{3}), Exception : {4})",
  //                                    nationCode,
  //                                    serverNo,
  //                                    userNo,
  //                                    totalWeight,
  //                                    ex),
  //                      "ERROR");
  //   }
  //
  //   return commonResult;
  // }

  // public static CommonResult WorldMarketMyWallet(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo,
  //   int? keyType,
  //   int? mainKey,
  //   int? subKey,
  //   bool? isSealed,
  //   ref string count) {
  //   var commonResult = new CommonResult();
  //
  //   try {
  //     TradeDbManager.This.uspWorldMarketMyWallet(nationCode,
  //                                                serverNo,
  //                                                userNo,
  //                                                keyType,
  //                                                mainKey,
  //                                                subKey,
  //                                                isSealed,
  //                                                out var count1,
  //                                                out var symNo,
  //                                                out var rv);
  //     count = Convert.ToString(count1);
  //     commonResult.resultCode = Convert.ToInt32(rv);
  //     commonResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonResult.resultCode = 1;
  //     commonResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspWorldMarketMyWallet({0}/{1}/{2}/{3}/{4}/{5}/{6}) Exception : {7}",
  //                                    nationCode,
  //                                    serverNo,
  //                                    userNo,
  //                                    keyType,
  //                                    mainKey,
  //                                    subKey,
  //                                    count,
  //                                    ex),
  //                      "ERROR");
  //   }
  //
  //   return commonResult;
  // }

  // public static CommonDBResult<uspBuyablePersonalTradeList_Result> BuyablePersonalTradeList(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo) {
  //   var commonDbResult = new CommonDBResult<uspBuyablePersonalTradeList_Result>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspBuyablePersonalTradeList(nationCode, serverNo, userNo, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspBuyablePersonalTradeList({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static int GetAddTaxDiscountRate(int _nationCode,
  //                                         int _worldNo,
  //                                         long _userNo) {
  //   try {
  //     TradeDbManager.This.uspGetAddTaxDiscountRate(_nationCode,
  //                                                  _worldNo,
  //                                                  _userNo,
  //                                                  out var addTaxDiscountRate,
  //                                                  out var familySkillAddTaxDiscountRate);
  //     return Convert.ToInt32(addTaxDiscountRate) + Convert.ToInt32(familySkillAddTaxDiscountRate);
  //   }
  //   catch (Exception ex) {
  //     LogUtil.WriteLog("[DB ERROR]getAddTaxDiscountRateError Exception=" + ex, "ERROR");
  //     return 0;
  //   }
  // }

  // public static CommonDBResult<ResultWorldMarket> ListWorldMarket(
  //   KeyType keyType,
  //   int mainCategory,
  //   int subCategory) {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarket>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListWorldMarket((int)keyType,
  //                                                                  mainCategory,
  //                                                                  subCategory,
  //                                                                  OptionManager.This.BiddingRatio,
  //                                                                  out var symNo,
  //                                                                  out var rv)
  //                                         .ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarket({0}/{1}) Exception : {2}", mainCategory, subCategory, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<ResultSearchListWorldMarket> SearchListWorldMarket(
  //   string searchResult) {
  //   var commonDbResult = new CommonDBResult<ResultSearchListWorldMarket>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspSearchListWorldMarket(searchResult,
  //                                                                        OptionManager.This.BiddingRatio,
  //                                                                        out var symNo,
  //                                                                        out var rv)
  //                                         .ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspSearchListWorldMarket({0}) Exception : {1}", searchResult, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<ResultWorldMarketDetail> ListWorldMarketDetail(
  //   KeyType keyType,
  //   int mainKey,
  //   bool isUsedTotalTradeCount) {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarketDetail>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListWorldMarketDetail((int)keyType,
  //                                                                        mainKey,
  //                                                                        isUsedTotalTradeCount,
  //                                                                        OptionManager.This.BiddingRatio,
  //                                                                        out var symNo,
  //                                                                        out var rv)
  //                                         .ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketDetail({0}) Exception : {1}", mainKey, ex), "ERROR");
  //     return commonDbResult;
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<ResultWorldMarketDetailByCategory> ListWorldMarketDetailByCategory(
  //   int? mainCategory,
  //   int? subCategory) {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarketDetailByCategory>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListWorldMarketDetailByCategory(mainCategory, subCategory, OptionManager.This.BiddingRatio, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketDetailByCategory({0}, {1}) Exception : {2}", mainCategory, subCategory, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<ResultWorldMarketHot> ListWorldMarketHot() {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarketHot>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListWorldMarketHot(OptionManager.This.BiddingRatio, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketHot() Exception : {0}", ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<ResultWorldMarketWait> ListWorldMarketWait() {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarketWait>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListWorldMarketWait(out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListWorldMarketHot() Exception : {0}", ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }



  // public static CommonDBResult<ResultUserBiddingBuy> ListUserBiddingBuy(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo) {
  //   var commonDbResult = new CommonDBResult<ResultUserBiddingBuy>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListUserBiddingBuy(nationCode, serverNo, userNo, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListUserBiddingBuy({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static CommonDBResult<ResultUserBiddingSell> ListUserBiddingSell(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo) {
  //   var commonDbResult = new CommonDBResult<ResultUserBiddingSell>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListUserBiddingSell(nationCode, serverNo, userNo, out var symNo, out var rv).ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListUserBiddingSell({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }

  // public static void getPearlItemTradeCount(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo,
  //   out int addPearlItemLimitedCount,
  //   out int currentPearlItemLimitedCount,
  //   out long addWeight,
  //   out int ringBuffCount) {
  //   addPearlItemLimitedCount = 0;
  //   currentPearlItemLimitedCount = 0;
  //   addWeight = 0L;
  //   ringBuffCount = 0;
  //   try {
  //     TradeDbManager.This.uspGetPearlItemLimitedCount(userNo,
  //                                                     serverNo,
  //                                                     nationCode,
  //                                                     out var addPearlItemLimitedCount1,
  //                                                     out var currentPearlItemLimitedCount1,
  //                                                     out var addWeight1,
  //                                                     out var ringBuffCount1);
  //     addPearlItemLimitedCount = Convert.ToInt32(addPearlItemLimitedCount1);
  //     currentPearlItemLimitedCount = Convert.ToInt32(currentPearlItemLimitedCount1);
  //     addWeight = Convert.ToInt64(addWeight1);
  //     ringBuffCount = Convert.ToInt32(ringBuffCount1);
  //   }
  //   catch (Exception ex) {
  //     LogUtil.WriteLog(string.Format("[DB Exception] getAddPearlItemTradeCount({0}/{1}/{2}) Exception : {3}", nationCode, serverNo, userNo, ex), "ERROR");
  //   }
  // }



  // public static CommonResult WorldMarketServnatNo(
  //   int? nationCode,
  //   int? serverNo,
  //   long? userNo,
  //   int? keyType,
  //   int? mainKey,
  //   int? subKey,
  //   ref long resultServantNo) {
  //   var commonResult = new CommonResult();
  //
  //   resultServantNo = 0L;
  //   try {
  //     TradeDbManager.This.uspGetServantNo(nationCode,
  //                                         serverNo,
  //                                         userNo,
  //                                         keyType,
  //                                         mainKey,
  //                                         subKey,
  //                                         out var servantNo,
  //                                         out var symNo,
  //                                         out var rv);
  //     commonResult.resultCode = Convert.ToInt32(rv);
  //     commonResult.resultMsg = Convert.ToString(symNo);
  //     if (commonResult.resultCode != 0)
  //       return commonResult;
  //     resultServantNo = Convert.ToInt64(servantNo);
  //   }
  //   catch (Exception ex) {
  //     commonResult.resultCode = 1;
  //     commonResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] WorldMarketServnatNo({0}/{1}/{2}) Exception : {3}", keyType, mainKey, subKey, ex), "ERROR");
  //     return commonResult;
  //   }
  //
  //   return commonResult;
  // }
  // public static CommonResult WorldMarketDetailOne(
  //   int? mainKey,
  //   int enchantGroup,
  //   ref long pricePerOne,
  //   ref long count,
  //   ref long minPrice,
  //   ref long maxPrice,
  //   ref long totalTradeCount,
  //   ref long lastTradePrice,
  //   ref long lastTradeTime) {
  //   var commonResult = new CommonResult();
  //
  //
  //   try {
  //     
  //     TradeDbManager.This.uspWorldMarketDetailOne(mainKey,
  //                                                 enchantGroup,
  //                                                 out var pricePerOne1,
  //                                                 out var count1,
  //                                                 out var minPrice1,
  //                                                 out var maxPrice1,
  //                                                 out var totalTradeCount1,
  //                                                 out var lastTradePrice1,
  //                                                 out var lastTradeTime1,
  //                                                 out var symNo,
  //                                                 out var rv);
  //     pricePerOne = Convert.ToInt64(pricePerOne1 == null || string.IsNullOrEmpty(pricePerOne1.ToString())
  //                                     ? 0
  //                                     : pricePerOne1);
  //     count = Convert.ToInt64(count1 == null || string.IsNullOrEmpty(count1.ToString())
  //                               ? 0
  //                               : count1);
  //     minPrice = Convert.ToInt64(minPrice1 == null || string.IsNullOrEmpty(minPrice1.ToString())
  //                                  ? 0
  //                                  : minPrice1);
  //     maxPrice = Convert.ToInt64(maxPrice1 == null || string.IsNullOrEmpty(maxPrice1.ToString())
  //                                  ? 0
  //                                  : maxPrice1);
  //     totalTradeCount = Convert.ToInt64(totalTradeCount1 == null || string.IsNullOrEmpty(totalTradeCount1.ToString())
  //                                         ? 0
  //                                         : totalTradeCount1);
  //     lastTradePrice = Convert.ToInt64(lastTradePrice1 == null || string.IsNullOrEmpty(lastTradePrice1.ToString())
  //                                        ? 0
  //                                        : lastTradePrice1);
  //     long num;
  //     if (lastTradeTime1 == null || string.IsNullOrEmpty(lastTradeTime1.ToString())) {
  //       num = 0L;
  //     }
  //     else {
  //       num = Convert.ToDateTime(lastTradeTime1).ToUniversalTime().ConvertUnixTime();
  //       if (num <= 0L)
  //         num = 0L;
  //     }
  //
  //     lastTradeTime = Convert.ToInt64(num);
  //     commonResult.resultCode = Convert.ToInt32(rv);
  //     commonResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonResult.resultCode = 1;
  //     commonResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspWorldMarketDetailOne({0}/{1}/{2}/{3}) Exception : {4}",
  //                                    mainKey,
  //                                    enchantGroup,
  //                                    pricePerOne,
  //                                    count,
  //                                    ex),
  //                      "ERROR");
  //   }
  //
  //   return commonResult;
  // }

  // public static CommonDBResult<ResultListBiddingInfo> ListBiddingInfo(
  //   int? keyType,
  //   int? mainKey,
  //   int? subKey,
  //   int enchantMaterialKey,
  //   double biddingRate) {
  //   var commonDbResult = new CommonDBResult<ResultListBiddingInfo>();
  //
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspListBiddingInfo(keyType,
  //                                                                  mainKey,
  //                                                                  subKey,
  //                                                                  enchantMaterialKey,
  //                                                                  biddingRate,
  //                                                                  out var symNo,
  //                                                                  out var rv)
  //                                         .ToList();
  //     commonDbResult.resultCode = Convert.ToInt32(rv);
  //     commonDbResult.resultMsg = Convert.ToString(symNo);
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] uspListBiddingInfo({0}/{1}/{2}/{3}) Exception : {4}",
  //                                    keyType,
  //                                    mainKey,
  //                                    subKey,
  //                                    enchantMaterialKey,
  //                                    ex),
  //                      "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }
  
   // public static CommonDBResult<ResultGetMarketPriceInfo> WorldMarketPriceInfo(
   //   int? keyType,
   //   int? mainKey,
   //   int? subKey) {
   //   var commonDbResult = new CommonDBResult<ResultGetMarketPriceInfo>();
   //   try {
   //     commonDbResult.list = TradeDbManager.This.uspGetMarketPriceInfo(keyType, mainKey, subKey, out var symNo).ToList();
   //     commonDbResult.resultCode = 0;
   //     commonDbResult.resultMsg = Convert.ToString(symNo);
   //   }
   //   catch (Exception ex) {
   //     commonDbResult.resultCode = 1;
   //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
   //     LogUtil.WriteLog(string.Format("[DB Exception] GetItemPriceHistoryInfoForGraph({0}/{1}/{2}) Exception : {3}", keyType, mainKey, subKey, ex), "ERROR");
   //   }
   //
   //   return commonDbResult;
   // }
  // public static CommonDBResult<ResultWorldMarketWaitNoticeList> WorldMarketMyWaitNoticeList(
  //   int nationCode,
  //   int serverNo,
  //   long userNo) {
  //   var commonDbResult = new CommonDBResult<ResultWorldMarketWaitNoticeList>();
  //   try {
  //     commonDbResult.list = TradeDbManager.This.uspWorldMarketWaitNoticeList(nationCode, serverNo, userNo).ToList();
  //   }
  //   catch (Exception ex) {
  //     commonDbResult.resultCode = 1;
  //     commonDbResult.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_DBException.GetResourceValue();
  //     LogUtil.WriteLog(string.Format("[DB Exception] WorldMarketMyWaitNoticeList userNo {0} EX {1}", userNo, ex), "ERROR");
  //   }
  //
  //   return commonDbResult;
  // }
}