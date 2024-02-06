using BlackDesert.Trade.Domain.DB.Context;
using BlackDesert.Trade.Domain.Models.Api;
using BlackDesert.Trade.Domain.Models.Process;

namespace BlackDesert.Trade.Business.Services;

public sealed class TradePayloadService
{
  private readonly TradeProcessService _processService;
  private readonly GameDbContext _gameDbContext;
  private readonly TradeDbContext _tradeDbContext;

  public TradePayloadService(
    TradeProcessService processService,
    GameDbContext gameDbContext,
    TradeDbContext tradeDbContext) {
    _processService = processService;
    _gameDbContext = gameDbContext;
    _tradeDbContext = tradeDbContext;
  }

  public CommonResult SetMarketItem(GameTradeMarketRequestItemAuthModel model) {
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var rvCheckValidCount = WorldMarketValidator.CheckValidCount(1, model.count);
    if (rvCheckValidCount != 0) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());
    var marketItemInfoModel = new ProcessTradeMarketItemInfoModel {
      userNo = user.userNo,
      serverNo = user.worldNo,
      nationCode = user.nationCode,
      keyType = model.keyType,
      mainKey = model.mainKey,
      subKey = model.subKey,
      param0 = model.param0,
      param1 = model.param1,
      param2 = model.param2,
      param3 = model.param3,
      param4 = model.param4,
      count = model.count,
      isSealed = bool.Parse(model.isSealed)
    };
    var resTradeMarketPayload = _processService.SetMarketItemProcess(marketItemInfoModel);
    if (resTradeMarketPayload.Rv != 0) resTradeMarketPayload.ToCommonResult();
    if (resTradeMarketPayload.Data == 0L) return new CommonResult(17, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero.GetResourceValue());

    var res = _gameDbContext.RemoveForDepositToWorldMarket(resTradeMarketPayload.Data,
                                                           marketItemInfoModel.nationCode,
                                                           marketItemInfoModel.serverNo,
                                                           marketItemInfoModel.userNo,
                                                           marketItemInfoModel.keyType,
                                                           marketItemInfoModel.mainKey,
                                                           marketItemInfoModel.subKey,
                                                           marketItemInfoModel.isSealed,
                                                           marketItemInfoModel.param0,
                                                           marketItemInfoModel.param1,
                                                           marketItemInfoModel.param2,
                                                           marketItemInfoModel.param3,
                                                           marketItemInfoModel.param4,
                                                           marketItemInfoModel.count,
                                                           0);

    if (!res.Status)
      return res.ToCommonResult();
    return new CommonResult(0, resTradeMarketPayload.Data.ToString());
  }

  public CommonResult RegisterMarketItem(GameTradeMarketRequestAuthPayload model) {
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var marketIncludePayload1 = new ProcessTradeMarketIncludePayloadModel {
      nationCode = user.nationCode,
      serverNo = user.worldNo,
      userNo = user.userNo,
      isRestoration = bool.Parse(model.isRestoration)
    };
    var resCheckPayloadForRegisterItem = _gameDbContext.CheckPayloadForRegisterItem(marketIncludePayload1.nationCode,
                                                                                    marketIncludePayload1.serverNo,
                                                                                    marketIncludePayload1.userNo,
                                                                                    model.keyType,
                                                                                    model.mainKey,
                                                                                    model.subKey,
                                                                                    model.count,
                                                                                    bool.Parse(model.isSealed),
                                                                                    model.payload,
                                                                                    model.param0,
                                                                                    model.param1,
                                                                                    model.param2,
                                                                                    model.param3,
                                                                                    model.param4);

    if (!resCheckPayloadForRegisterItem.Status) {
      return CommonResult.Error(-1, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
    }

    marketIncludePayload1.payload = model.payload;
    var payloadRegisterMarketItemProcess = _processService.RegisterMarketItemProcess(marketIncludePayload1);
    if (payloadRegisterMarketItemProcess.result.resultCode != 0) return payloadRegisterMarketItemProcess.result;

    if (payloadRegisterMarketItemProcess.payload == 0L) return new CommonResult(17, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero.GetResourceValue());

    var resCompletePayloadForRegisterItem = _gameDbContext.CompletePayloadForRegisterItem(marketIncludePayload1.nationCode,
                                                                                          marketIncludePayload1.serverNo,
                                                                                          marketIncludePayload1.userNo,
                                                                                          model.keyType,
                                                                                          model.mainKey,
                                                                                          model.subKey,
                                                                                          model.count,
                                                                                          bool.Parse(model.isSealed),
                                                                                          model.payload,
                                                                                          model.param0,
                                                                                          model.param1,
                                                                                          model.param2,
                                                                                          model.param3,
                                                                                          model.param4);
    if (!resCompletePayloadForRegisterItem.Status) {
      return CommonResult.Error(-1, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
    }

    marketIncludePayload1.payload = model.payload;


    const string template = "{KeyType}-{MainKey}-{SubKey}-{IsSealed}-{Count}";
    var sb = new StringBuilder();
    sb.Append(template);
    sb.Replace("{KeyType}", ConstantContainer.KeyTypeInt.ToString());
    sb.Replace("{MainKey}", model.mainKey.ToString());
    sb.Replace("{SubKey}", model.subKey.ToString());
    sb.Replace("{IsSealed}", model.isSealed);
    sb.Replace("{Count}", model.count.ToString());
    var msg = sb.ToString();
    return new CommonResult(0, msg);
  }

  public CommonResult WithdrawItem(GameTradeMarketRequestItemAuthModel model) {
    // UserInformationModel userInfo = null;
    var user = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    // var resultCheckAuthKey = TradeAuthService.This.CheckAuthKey(model.userNo, model.certifiedKey);
    // if (resultCheckAuthKey.resultCode != 0) {
    //   return resultCheckAuthKey;
    // }

    var rvCheckValidCount = WorldMarketValidator.CheckValidCount(1, model.count);
    if (rvCheckValidCount != 0) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());

    var marketItemInfoModel = new ProcessTradeMarketItemInfoModel {
      nationCode = user.nationCode,
      serverNo = user.worldNo,
      userNo = user.userNo,
      keyType = model.keyType,
      mainKey = model.mainKey,
      subKey = model.subKey,
      count = model.count,
      isSealed = bool.Parse(model.isSealed)
    };
    var marketIncludePayload1 = _processService.PreWithdrawItemProcess(marketItemInfoModel);
    if (marketIncludePayload1.result.resultCode != 0) return marketIncludePayload1.result;

    if (marketIncludePayload1.payload == 0L) return new CommonResult(17, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero.GetResourceValue());

    var payloadResult = _gameDbContext.CreateForWithdrawToWorldMarket(marketIncludePayload1.payload,
                                                                      marketItemInfoModel.nationCode,
                                                                      marketItemInfoModel.serverNo,
                                                                      marketItemInfoModel.userNo,
                                                                      marketItemInfoModel.keyType,
                                                                      marketItemInfoModel.mainKey,
                                                                      marketItemInfoModel.subKey,
                                                                      marketItemInfoModel.isSealed,
                                                                      marketIncludePayload1.param0,
                                                                      marketIncludePayload1.param1,
                                                                      marketIncludePayload1.param2,
                                                                      marketIncludePayload1.param3,
                                                                      marketIncludePayload1.param4,
                                                                      marketItemInfoModel.count,
                                                                      0);

    if (!payloadResult.Status)
      return payloadResult.ToCommonResult();


    var marketIncludePayload2 = new ProcessTradeMarketIncludePayloadModel {
      nationCode = marketItemInfoModel.nationCode,
      serverNo = marketItemInfoModel.serverNo,
      userNo = marketItemInfoModel.userNo,
      keyType = marketItemInfoModel.keyType,
      mainKey = marketItemInfoModel.mainKey,
      subKey = marketItemInfoModel.subKey,
      isSealed = marketItemInfoModel.isSealed,
      param0 = marketIncludePayload1.param0,
      param1 = marketIncludePayload1.param1,
      param2 = marketIncludePayload1.param2,
      param3 = marketIncludePayload1.param3,
      param4 = marketIncludePayload1.param4,
      count = marketItemInfoModel.count,
      payload = marketIncludePayload1.payload
    };
    var tradeMarketPayload = _processService.CompleteWithdrawItemProcess(marketIncludePayload2);
    if (tradeMarketPayload.result.resultCode != 0) return tradeMarketPayload.result;

    if (tradeMarketPayload.payload == 0L) return new CommonResult(17, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_PayloadIsZero.GetResourceValue());

    try {
      var resUpdateForWithdrawToWorldMarket = _gameDbContext.UpdateForWithdrawToWorldMarket(tradeMarketPayload.payload);
      if (!resUpdateForWithdrawToWorldMarket.Status) {
        Log.Error("[DB ERROR] WithdrawItem() - UpdateForWithdrawToWorldMarket() rv : {0} , symNo : {1}", resUpdateForWithdrawToWorldMarket, marketIncludePayload2.mainKey);
        return CommonResult.Error(-1, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
      }
    }
    catch (Exception ex) {
      Log.Error(ex,
                "[DB Exception]WithdrawItem - uspUpdateForWithdrawToWorldMarket({marketIncludePayload2}/{tradeMarketPayload})",
                JsonConvert.SerializeObject(marketIncludePayload2),
                JsonConvert.SerializeObject(tradeMarketPayload));
      return new CommonResult(1, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
    }

    var msg = Convert.ToString(tradeMarketPayload.payload) + "-" + Convert.ToString(model.mainKey) + "-" + Convert.ToString(model.subKey) + "-" +
              Convert.ToString(marketIncludePayload1.param0) + "-" + Convert.ToString(marketIncludePayload1.param1) + "-" + Convert.ToString(marketIncludePayload1.param2) + "-" +
              Convert.ToString(marketIncludePayload1.param3) + "-" + Convert.ToString(marketIncludePayload1.param4) + "-" + Convert.ToString(model.count) + "-" +
              Convert.ToString(model.isSealed);
    return new CommonResult(0, msg);
  }

  public CommonResult PopItemRestoration(GameTradeMarketRequestPopItemRestorationInfoModel model) {
    var tradeMarketState1 = new ProcessTradeMarketState();
    var commonResult1 = new CommonResult();
    // UserInformationModel userInfo = null;
    // var relResult = string.Empty;
    // var errorMsg = string.Empty;
    // var empty = string.Empty;
    var userInfo = TradeAuthService.AuthenticateForGame(model.userNo, model.certifiedKey);
    var validCount = WorldMarketValidator.CheckValidCount(1, model.itemCount);
    if (validCount != 0) return new CommonResult(7, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue());
    // Log.Warning("[Count Error] PopItemRestoration({PopItemRestoration}) invalidCount({invalidCount})", JsonConvert.SerializeObject(model), model.itemCount);
    // commonResult2.resultCode = 7;
    // commonResult2.resultMsg = MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidCount.GetResourceValue();
    // return Json(commonResult2);
    var marketIncludePayload = new ProcessTradeMarketIncludePayloadModel {
      nationCode = userInfo.nationCode,
      serverNo = userInfo.worldNo,
      userNo = userInfo.userNo,
      keyType = 0,
      mainKey = model.mainKey,
      subKey = model.subKey,
      isSealed = model.isSealed,
      param0 = model.param0,
      param1 = model.param1,
      param2 = model.param2,
      param3 = model.param3,
      param4 = model.param4,
      count = model.itemCount,
      payload = model.payload
    };

    var tradeMarketState2 = _tradeDbContext.GetWithDrawPayLoadState(marketIncludePayload.userNo,
                                                                     marketIncludePayload.nationCode,
                                                                    marketIncludePayload.serverNo,
                                                                    marketIncludePayload.payload,
                                                                    marketIncludePayload.mainKey,
                                                                    marketIncludePayload.subKey,
                                                                    marketIncludePayload.isSealed,
                                                                    marketIncludePayload.count,
                                                                    marketIncludePayload.param0,
                                                                    marketIncludePayload.param1,
                                                                    marketIncludePayload.param2,
                                                                    marketIncludePayload.param3,
                                                                    marketIncludePayload.param4);
    if (!tradeMarketState2.Status) {
      return new CommonResult(5, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_JSONIsNull.GetResourceValue());
    }

    if (tradeMarketState2.Data == 0) {
      var resPayloadDestroy = _gameDbContext.WithdrawPayloadDestroy(marketIncludePayload.userNo,
                                                                    marketIncludePayload.nationCode,
                                                                    marketIncludePayload.serverNo,
                                                                    marketIncludePayload.payload,
                                                                    marketIncludePayload.mainKey,
                                                                    marketIncludePayload.subKey,
                                                                    marketIncludePayload.isSealed,
                                                                    marketIncludePayload.count,
                                                                    marketIncludePayload.param0,
                                                                    marketIncludePayload.param1,
                                                                    marketIncludePayload.param2,
                                                                    marketIncludePayload.param3,
                                                                    marketIncludePayload.param4);

      if (!resPayloadDestroy.Status) {
        Log.Error("[DB ERROR] PopItemRestoration() - WithdrawPayloadDestroy() rv : {0} , symNo : {1}", resPayloadDestroy, marketIncludePayload.mainKey);
        return CommonResult.Error(-1, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
      }

      return CommonResult.Success();


      var resultMsg = Convert.ToString(model.payload) + "-" + Convert.ToString(model.mainKey) + "-" + Convert.ToString(model.subKey) + "-" + Convert.ToString(model.itemCount) + "-" +
                      Convert.ToString(model.isSealed) + "-" + Convert.ToString(model.param0) + "-" + Convert.ToString(model.param1) + "-" + Convert.ToString(model.param2) + "-" +
                      Convert.ToString(model.param3) + "-" + Convert.ToString(model.param4) + "-False";
      return new CommonResult(0, resultMsg);
    }

    var res = _gameDbContext.UpdateForWithdrawToWorldMarket(model.payload);
    if (!res.Status) {
      Log.Error("[DB ERROR] PopItemRestoration() - UpdateForWithdrawToWorldMarket() rv : {0} , symNo : {1}", res, model.mainKey);
      return CommonResult.Error(-1, MarketError.TRADE_MARKET_ERROR_MSG_EXCEPTION.GetResourceValue());
    }

    var resultMsg2 = Convert.ToString(model.payload) + "-" + Convert.ToString(model.mainKey) + "-" + Convert.ToString(model.subKey) + "-" + Convert.ToString(model.itemCount) + "-" +
                     Convert.ToString(model.isSealed) + "-" + Convert.ToString(model.param0) + "-" + Convert.ToString(model.param1) + "-" + Convert.ToString(model.param2) + "-" +
                     Convert.ToString(model.param3) + "-" + Convert.ToString(model.param4) + "-True";
    return new CommonResult(0, resultMsg2);
  }
}