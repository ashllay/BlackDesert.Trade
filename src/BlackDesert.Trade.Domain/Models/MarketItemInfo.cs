namespace BlackDesert.Trade.Domain.Models;

public class MarketItemInfo
{
  public Dictionary<int, MarketValue> _infoList;
  public DateTime _lastUpdateTime;

  public MarketItemInfo() {
    _lastUpdateTime = new DateTime();
    _infoList = new Dictionary<int, MarketValue>();
  }
}