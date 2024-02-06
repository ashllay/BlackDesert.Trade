namespace BlackDesert.Trade.Domain.Models;

public class DetailInfo
{
  public Dictionary<KeyValuePair<int, int>, MarketValue> _infoList;
  public DateTime _lastUpdateTime;

  public DetailInfo() {
    _lastUpdateTime = new DateTime();
    _infoList = new Dictionary<KeyValuePair<int, int>, MarketValue>();
  }
}