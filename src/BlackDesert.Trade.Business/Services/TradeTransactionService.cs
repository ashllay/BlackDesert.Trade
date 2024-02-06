using BlackDesert.Trade.Domain.Models.Api;
using BlackDesert.Trade.Domain.Models.Process;

namespace BlackDesert.Trade.Business.Services;

public sealed class TradeTransactionService
{

  private readonly TradeProcessService _tradeProcessService;

  public TradeTransactionService(
                                 TradeProcessService tradeProcessService) {

    _tradeProcessService = tradeProcessService;
  }
  public CommonResult BuyItem(GameTradeMarketRequestBuyAuthModel model) {
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    // UserInformationModel userInfo = null;
    // var resultCheckAuthKey = TradeModule.CheckAuthKey(ref userInfo, model.userNo, model.certifiedKey, true);
    // if (resultCheckAuthKey.resultCode != 0) {
    //   return resultCheckAuthKey;
    // }

    // if (!userInfo._isWebAccess) {
    //   var resultCheckTicketNo = TradeModule.CheckTicketNo(userInfo._userNo, userInfo._worldNo, 0, model.ticketNo);
    //   if (resultCheckTicketNo.resultCode != 0) {
    //     return resultCheckTicketNo;
    //   }
    // }

    var rvCheckValidCount = WorldMarketValidator.CheckValidCount(model.buyPrice, model.buyCount);
    if (rvCheckValidCount != 0) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());

    var tradeMarketBuyInfo = new ProcessTradeMarketBuyInfo {
      nationCode = user.nationCode,
      worldNo = user.worldNo,
      userNo = user.userNo,
      buyKeyType = model.buyKeyType,
      buyMainKey = model.buyMainKey,
      buySubKey = model.buySubKey,
      buyPrice = model.buyPrice,
      buyCount = model.buyCount,
      buyChooseKey = model.buyChooseKey,
      isWebAccess = false,
      otp = model.otp,
      retryBiddingNo = model.retryBiddingNo
    };
    var resultBuyItemProcess = _tradeProcessService.BuyItemProcess(tradeMarketBuyInfo);
    if (resultBuyItemProcess.resultCode != 0)
      return resultBuyItemProcess;
    var msg = resultBuyItemProcess.resultMsg + "-" + Convert.ToString(false); //user._isReturn
    return new CommonResult(0, msg);
  }

  public CommonResult SellItem(GameTradeMarketRequestSellAuthModel model) {
    var isRingBuff = bool.Parse(model.isRingBuff);
    var isSealed = bool.Parse(model.isSealed);
    // UserInformationModel userInfo = null;
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    // var resultCheckAuthKey = TradeModule.CheckAuthKey(ref userInfo, model.userNo, model.certifiedKey, true);
    // if (resultCheckAuthKey.resultCode != 0) {
    //   return resultCheckAuthKey;
    // }

    // if (!userInfo._isWebAccess) {
    //   var resultCheckTicketNo = TradeModule.CheckTicketNo(user.userNo, user.worldNo, 1, model.ticketNo);
    //   if (resultCheckTicketNo.resultCode != 0) {
    //     return resultCheckTicketNo;
    //   }
    // }

    var rvCheckValidCount = WorldMarketValidator.CheckValidCount(model.sellPrice, model.sellCount);
    if (rvCheckValidCount != 0) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());

    if (model.sellMainKey.Equals(0)) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());

    var tradeMarketSellInfo = new ProcessTradeMarketSellInfo {
      nationCode = user.nationCode,
      worldNo = user.worldNo,
      userNo = user.userNo,
      sellKeyType = model.sellKeyType,
      sellMainKey = model.sellMainKey,
      sellSubKey = model.sellSubKey,
      sellPrice = model.sellPrice,
      sellCount = model.sellCount,
      sellChooseKey = model.sellChooseKey,
      isSealed = isSealed,
      isWebAccess = false,
      isRingBuff = isRingBuff,
      otp = model.otp,
      retryBiddingNo = model.retryBiddingNo
    };
    var resultSellItemProcess = _tradeProcessService.SellItemProcess(tradeMarketSellInfo);

    if (resultSellItemProcess.resultCode != 0)
      return resultSellItemProcess;

    var msg = resultSellItemProcess.resultMsg + "-" + Convert.ToString(false);
    return new CommonResult(0, msg);
  }
}