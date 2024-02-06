using BlackDesert.Trade.Business.Services;
using BlackDesert.Trade.Business.Services.Common;
using BlackDesert.Trade.Domain.Models.Api;

using Microsoft.AspNetCore.Mvc;

namespace BlackDesert.Trade.Api.Game.Controllers.Market;

[ApiController]
[Route("GameTradeMarket/[action]")]
public class GameTradeMarketController : Controller
{
  private readonly TradeWalletService _walletService;
  private readonly TradeTransactionService _transactionService;
  private readonly TradePayloadService _payloadService;
  private readonly TradeProcessService _processService;
  private readonly TradeBiddingService _biddingService;

  public GameTradeMarketController(TradeWalletService walletService,
                                   TradeTransactionService transactionService,
                                   TradePayloadService payloadService,
                                   TradeProcessService processService,
                                   TradeBiddingService biddingService) {
    _walletService = walletService;
    _transactionService = transactionService;
    _payloadService = payloadService;
    _processService = processService;
    _biddingService = biddingService;
  }

  [HttpPost]
  public JsonResult CreateMyWallet(GameTradeMarketRequestUserAuthModel model) {
    var result = _walletService.CreateMyWallet(model.userNo, model.certifiedKey);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] CreateOrUpdateMyWallet_Unsafe({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] CreateOrUpdateMyWallet_Unsafe({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }


  [HttpPost]
  public JsonResult SetMarketItem(GameTradeMarketRequestItemAuthModel model) {
    var result = _payloadService.SetMarketItem(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] SetMarketItem({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] SetMarketItem({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult RegisterMarketItem(GameTradeMarketRequestAuthPayload model) {
    var result = _payloadService.RegisterMarketItem(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] RegisterMarketItem({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] RegisterMarketItem({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult WithdrawItem(GameTradeMarketRequestItemAuthModel model) {
    var result = _payloadService.WithdrawItem(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] WithdrawItem({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] WithdrawItem({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult PopItemRestoration(GameTradeMarketRequestPopItemRestorationInfoModel model) {
    var result = _payloadService.PopItemRestoration(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] PopItemRestoration({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] PopItemRestoration({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    return Json(result);
  }


  [HttpPost]
  public JsonResult BuyItem(GameTradeMarketRequestBuyAuthModel model) {
    var result = _transactionService.BuyItem(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] BuyItem({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] BuyItem({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult SellItem(GameTradeMarketRequestSellAuthModel model) {
    var result = _transactionService.SellItem(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] SellItem({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] SellItem({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult WithdrawBuyBidding(GameTradeMarketRequestBuyBiddingAuthModel model) {
    var result = _biddingService.WithdrawBuyBidding(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] WithdrawBuyBidding({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] WithdrawBuyBidding({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult CalculateBuyBidding(GameTradeMarketRequestBuyBiddingAuthModel model) {
    var result = _biddingService.CalculateBuyBidding(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] CalculateBuyBidding({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] CalculateBuyBidding({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult WithdrawSellBidding(GameTradeMarketRequestSellBiddingAuthModel model) {
    var result = _biddingService.WithdrawSellBidding(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] WithdrawSellBidding({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] WithdrawSellBidding({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult CalculateSellBidding(GameTradeMarketRequestSellBiddingAuthModel model) {
    var result = _biddingService.CalculateSellBidding(model);
    if (result.resultCode == 0)
      Log.Debug("[GameTradeMarket] CalculateSellBidding({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[GameTradeMarket] CalculateSellBidding({model}}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }
}