using BlackDesert.Trade.Domain.Abstract;

namespace BlackDesert.Trade.Business.Manager.Info;

public class BiddingInfoManager : SingletonBase<BiddingInfoManager>
{
  private readonly Dictionary<KeyValuePair<int, int>, TradeMarketBiddingInfo> _biddinginfoList;
  private readonly Dictionary<KeyValuePair<int, int>, DateTime> _biddingTimeList;

  private BiddingInfoManager() {
    _biddinginfoList = new Dictionary<KeyValuePair<int, int>, TradeMarketBiddingInfo>();
    _biddingTimeList = new Dictionary<KeyValuePair<int, int>, DateTime>();

    var stopwatch = Stopwatch.StartNew();
    ServerControlLogger.LogStart(nameof(BiddingInfoManager));
    foreach (var keyValuePair in ItemInfoManager.This.GetItemListXxx()) {
      var mainKey = keyValuePair.Value._mainKey;
      var subKey = keyValuePair.Value._subKey;
      _biddinginfoList[keyValuePair.Key] = new TradeMarketBiddingInfo(mainKey, subKey);
      _biddingTimeList[keyValuePair.Key] = new DateTime();
    }

    stopwatch.Stop();
    ServerControlLogger.LogComplete(nameof(BiddingInfoManager), stopwatch.ElapsedMilliseconds);
  }


  public bool CheckBiddingUpdateTimeXxx(int mainKey,
                                        int subKey,
                                        DateTime currentTime) {
    var key = new KeyValuePair<int, int>(mainKey, subKey);
    if (!_biddingTimeList.ContainsKey(key))
      return false;
    var biddingTime = _biddingTimeList[key];
    if (currentTime < biddingTime.AddSeconds(1.0))
      return false;
    _biddingTimeList[key] = currentTime;
    return true;
  }

  public bool UpdateBiddingInfoListXxx(
    int mainKey,
    int subKey,
    ref List<ResultListBiddingInfo> list) {
    if (list.Count <= 0)
      return false;
    var key = new KeyValuePair<int, int>(mainKey, subKey);

    if (!_biddinginfoList.ContainsKey(key))
      return false;
    _biddinginfoList[key]._biddingList.Clear();
    foreach (var biddingInfoResult in list) {
      var cSellCount = biddingInfoResult._sellCount;
      var cBuyCount = biddingInfoResult._buyCount;
      var cPricePerOne = biddingInfoResult._pricePerOne;
      if (!_biddinginfoList[key]._biddingList.ContainsKey(cPricePerOne)) {
        _biddinginfoList[key]._biddingList[cPricePerOne] = new TradeMarketBiddingCount();
        _biddinginfoList[key]._biddingList[cPricePerOne]._buyCount = cBuyCount;
        _biddinginfoList[key]._biddingList[cPricePerOne]._sellCount = cSellCount;
      }
      else {
        _biddinginfoList[key]._biddingList[cPricePerOne]._buyCount += cBuyCount;
        _biddinginfoList[key]._biddingList[cPricePerOne]._sellCount += cSellCount;
      }
    }

    return true;
  }

  public void GetJsonStringByBiddingListXxx(int mainKey,
                                            int subKey,
                                            ref CommonResult jsonResult) {
    var key = new KeyValuePair<int, int>(mainKey, subKey);

    if (!_biddinginfoList.ContainsKey(key))
      jsonResult.resultMsg = "0";
    else if (_biddinginfoList[key]._biddingList.Count <= 0)
      jsonResult.resultMsg = "0";
    else
      foreach (var bidding in _biddinginfoList[key]._biddingList)
        jsonResult.resultMsg = jsonResult.resultMsg + Convert.ToString(bidding.Key) + "-" + Convert.ToString(bidding.Value._sellCount) + "-" + Convert.ToString(bidding.Value._buyCount) + "|";
  }
}