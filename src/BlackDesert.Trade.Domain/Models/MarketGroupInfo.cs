namespace BlackDesert.Trade.Domain.Models;

public class MarketGroupInfo
{
  public Dictionary<int, MarketValue> _infoList;
  public DateTime _lastUpdateTime;

  public MarketGroupInfo() {
    _lastUpdateTime = new DateTime();
    _infoList = new Dictionary<int, MarketValue>();
  }
}