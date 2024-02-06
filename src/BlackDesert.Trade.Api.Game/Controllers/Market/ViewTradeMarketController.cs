using BlackDesert.Trade.Business.Manager;
using BlackDesert.Trade.Business.Services;
using BlackDesert.Trade.Domain.Models.Api;

using Microsoft.AspNetCore.Mvc;

namespace BlackDesert.Trade.Api.Game.Controllers.Market;

[ApiController]
[Route("Trademarket/[action]")]
public class ViewTradeMarketController : Controller
{
  private readonly TradeWalletService _walletService;
  private readonly TradeViewService _viewService;
  private readonly TradeBiddingService _biddingService;

  public ViewTradeMarketController(TradeWalletService walletService,
                                   TradeViewService viewService,
                                   TradeBiddingService biddingService) {
    _walletService = walletService;
    _viewService = viewService;
    _biddingService = biddingService;
  }
  [HttpPost]
  public JsonResult GetMyWalletList(ViewRequestUserAuthModel model) {
    var result = _walletService.GetMyWalletList(model.userNo,model.certifiedKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetMyWalletList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetMyWalletList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetMyWallet(ViewRequestGetMyWallet model) {
    var result = _walletService.GetMyWallet(model);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetMyWallet({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetMyWallet({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketList(ViewRequestGetWorldMarketListModel model) {
    var result = _viewService.GetWorldMarketList(model.mainCategory, model.subCategory);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketSearchList([FromBody] ViewRequestGetWorldMarketSearchList model) {
    var result = _viewService.GetWorldMarketSearchList(model.searchResult);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketSearchList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketSearchList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketSubList(ViewRequestGetWorldMarketSubListModel model) {
    var result = _viewService.GetWorldMarketSubList( model.mainKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketSubList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketSubList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketSubListByCategory(ViewRequestGetWorldMarketSubListByCategory model) {
    var result = _viewService.GetWorldMarketSubListByCategory(model.mainCategory, model.subCategory);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketSubListByCategory({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketSubListByCategory({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketHotList() {
    //FULLY IMPLEMENTED 
    //NEED FULL TEST IF ALL DATA IS SAME
    var result = _viewService.GetWorldMarketHotList();
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketHotList() - {Rv}/{Msg}", result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketHotList() - {Rv}/{Msg}", result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketSubOne(ViewRequestGetWorldMarketSubOne model) {
    var result = _viewService.GetWorldMarketSubOne(model.mainKey, model.subKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketSubOne({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketSubOne({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetBiddingInfoList(ViewRequestGetBiddingInfoList model) {
    var result = _biddingService.GetBiddingInfoList(model.keyType, model.mainKey, model.subKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetBiddingInfoList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetBiddingInfoList({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetAddEnchantLevelPrice(ViewRequestGetAddEnchantLevelPrice model) {
    var result = _biddingService.GetAddEnchantLevelPrice(model.keyType, model.mainKey, model.subKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetAddEnchantLevelPrice({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetAddEnchantLevelPrice({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetMyBiddingList(ViewRequestUserAuthModel authInfo) {

    var result = _biddingService.GetMyBiddingList(authInfo);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetMyBiddingList({authInfo}) - {Rv}/{Msg}", authInfo.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetMyBiddingList({authInfo}) - {Rv}/{Msg}", authInfo.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetTradePrice(ViewRequestGetTradePrice model) {
    var result = _biddingService.GetTradePrice(model.KeyType, model.MainKey, model.SubKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetTradePrice({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetTradePrice({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetMarketPriceInfo(ViewRequestGetMarketPriceInfo model) {
    var result = _biddingService.GetMarketPriceInfo(model.keyType, model.mainKey, model.subKey);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetMarketPriceInfo({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetMarketPriceInfo({model}) - {Rv}/{Msg}", model.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetMyWaitNoticeList(ViewRequestUserAuthModel authInfo) {
    var result = _biddingService.GetMyWaitNoticeList(authInfo.userNo, authInfo.certifiedKey, authInfo.type);
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetMyWaitNoticeList({authInfo}) - {Rv}/{Msg}", authInfo.ToJsonString(), result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetMyWaitNoticeList({authInfo}) - {Rv}/{Msg}", authInfo.ToJsonString(), result.resultCode, result.resultMsg);

    return Json(result);
  }

  [HttpPost]
  public JsonResult GetWorldMarketWaitList() {
    var result = _biddingService.GetWorldMarketWaitList();
    if (result.resultCode == 0)
      Log.Debug("[TradeMarket] GetWorldMarketWaitList() - {Rv}/{Msg}", result.resultCode, result.resultMsg);
    else
      Log.Warning("[TradeMarket] GetWorldMarketWaitList() - {Rv}/{Msg}", result.resultCode, result.resultMsg);

    return Json(result);
  }
}