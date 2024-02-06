namespace BlackDesert.Trade.Domain.Models;

public class MarketHotItemInfo
{
  public Dictionary<int, MarketHotValue> _infoList;

  public MarketHotItemInfo() {
    _infoList = new Dictionary<int, MarketHotValue>();
  }
}