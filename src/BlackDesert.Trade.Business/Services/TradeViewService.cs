using BlackDesert.Trade.Business.Manager.Abstract;
using BlackDesert.Trade.Domain.DB.Context;

namespace BlackDesert.Trade.Business.Services;

public class TradeViewService
{
  private readonly TradeDbContext _tradeDbContext;

  public TradeViewService(TradeDbContext tradeDbContext) {
    _tradeDbContext = tradeDbContext;
  }
  
  [CacheAspect]
  public CommonResult GetWorldMarketList(int mainCategory,
                                         int subCategory) {
    WorldMarketValidator.MustBeHigherThanZero(mainCategory, "MainCategory is invalid: " + mainCategory);
    WorldMarketValidator.MustBeHigherThanZero(subCategory, "SubCategory is invalid: " + subCategory);
    // if (subCategory == 0 && mainCategory == 0) {
    //   return new CommonResult(0, "0");
    // }
    var stockListByCategory = StockInfoManger.This.GetStockListByCategory(mainCategory, subCategory);
    return stockListByCategory;
  }

  [CacheAspect]
  public CommonResult GetWorldMarketSearchList(string searchResult) {
    if (0 >= searchResult.Length || searchResult.Length >= 1000) return CommonResult.Error(21, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_StringOver.GetResourceValue());

    var parseLongList = searchResult.Split(',').Select(x => long.Parse(x)).ToList();
    var dbResult = _tradeDbContext.SearchListWorldMarket(parseLongList,OptionManager.This.BiddingRatio);
    // var dbResult = TradeDbWrapper.SearchListWorldMarket(searchResult);
    var resultMsg = "";
    if (!dbResult.Status)
      return dbResult.ToCommonResult();
    var list = dbResult.Data;
    if (list.Count == 0)
      return CommonResult.Error(44, "0");
    const string template = "{MainKey}-{SumCount}-{PricePerOne}-{TotalTradeCount}";
    for (var index = 0; index < list.Count; ++index) {
      var item = list[index];
      var sb = new StringBuilder();
      sb.Append(template);
      sb.Replace("{MainKey}", item._mainKey.ToString());
      sb.Replace("{SumCount}", item._sumCount.ToString());
      sb.Replace("{PricePerOne}", item._pricePerOne.ToString());
      sb.Replace("{TotalTradeCount}", item._totalTradeCount.ToString());
      resultMsg += sb.ToString();
      if (index < list.Count - 1)
        resultMsg += "|";
    }

    return CommonResult.Success(resultMsg);
  }

  [CacheAspect]
  public CommonResult GetWorldMarketSubList(int mainKey) {
    var subListByStockKey = StockInfoManger.This.GetStockSubListByStockKey(mainKey);
    return subListByStockKey;
  }

  public CommonResult GetWorldMarketSubListByCategory(int mainCategory,
                                                      int subCategory) {
    try {
      var updateList = new TradeMarketListDetailByCategory();
      // var commonDbResult1 = new CommonDBResult<ResultWorldMarketDetailByCategory>();
      var result = new CommonResult();
      if (StockInfoManger.This.IsUpdateTimeForDetailInfo(mainCategory, subCategory, CultureModule.GetCustomTimeNow())) {
        // var commonDbResult2 = TradeDbWrapper.ListWorldMarketDetailByCategory(mainCategory, subCategory);
        var dbRes = _tradeDbContext.ListWorldMarketDetailByCategory(mainCategory, subCategory);
        result = dbRes.ToCommonResult();
        if (result.resultCode != 0)
          return result;
        updateList.list = dbRes.Data;
        if (!StockInfoManger.This.UpdateByDetailInfo(mainCategory, subCategory, ref updateList)) {
          result.resultMsg = "0";
          return result;
        }
      }

      if (StockInfoManger.This.GetJsonStringByDetailInfo(mainCategory, subCategory, ref result))
        return result;
      result.resultMsg = "0";
      return result;
    }
    catch (Exception ex) {
      Log.Error(ex, "GetWorldMarketSubListByCategory({MainCategory}/{SubCategory}) Exception", mainCategory, subCategory);
      return CommonResult.Exception(0);
    }
  }

  [CacheAspect]
  public CommonResult GetWorldMarketHotList() {
    var commonDbResult = new CommonDBResult<ResultWorldMarketHot>();
    var result = new CommonResult();

    if (StockInfoManger.This.IsUpdateTimeForHotItemInfo()) {
      var dbResult = _tradeDbContext.ListWorldMarketHot(OptionManager.This.BiddingRatio);
      if (!dbResult.Status) {
        return dbResult.ToCommonResult();
      }
      var updateList = dbResult.Data;
      if (!StockInfoManger.This.UpdateByHotItemInfo(updateList)) {
        result.resultMsg = "0";
        return result;
      }
    }
    var resStr = StockInfoManger.This.GetJsonStringForHotItemInfo();
    return CommonResult.Success(resStr);
  }

  public CommonResult GetWorldMarketSubOne(int mainKey,
                                           int subKey) {
    var info = ItemInfoManager.This.GetInfo(mainKey, subKey);
    if (!info.IsValid()) return new CommonResult(8, MarketError.TRADE_MARKET_WEB_ERROR_eWorldTradeMarketErrorNo_InvalidItem.GetResourceValue());
    var dbResult = _tradeDbContext.WorldMarketDetailOne(mainKey, info._enchantGroup);
    if (!dbResult.Status) {
      return dbResult.ToCommonResult();
    }

    var pricePerOne = dbResult.Data.PricePerOne;
    var count = dbResult.Data.Count;
    var minPrice = dbResult.Data.MinPrice;
    var maxPrice = dbResult.Data.MaxPrice;
    var totalTradeCount = dbResult.Data.TotalTradeCount;
    var lastTradePrice = dbResult.Data.LastTradePrice;
    var lastTradeTime = dbResult.Data.LastTradeTime;
    var msg = mainKey + "-" +
              info._enchantGroup + "-" +
              Convert.ToString(ItemInfoManager.This.GetEnchantMaxGroup(mainKey, info._enchantGroup)) + "-" +
              pricePerOne + "-" +
              count + "-" +
              subKey + "-" +
              minPrice + "-" +
              maxPrice + "-" +
              totalTradeCount + "-" +
              lastTradePrice + "-" +
              lastTradeTime;
    return CommonResult.Success(msg);
  }
}