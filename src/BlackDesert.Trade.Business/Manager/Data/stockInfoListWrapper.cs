using System.Collections;

namespace BlackDesert.Trade.Business.Manager.Data;

public class stockInfoListWrapper :
  IEnumerable<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>>,
  IEnumerable
{
  private readonly Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> _stockInfoList;

  public stockInfoListWrapper(Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> list) {
    _stockInfoList = list;
  }

  public IEnumerator<KeyValuePair<KeyValuePair<int, int>, TradeMarketItemInfo>> GetEnumerator() {
    return _stockInfoList.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator() {
    return _stockInfoList.GetEnumerator();
  }

  public Dictionary<KeyValuePair<int, int>, TradeMarketItemInfo> getXXX() {
    return _stockInfoList;
  }
}