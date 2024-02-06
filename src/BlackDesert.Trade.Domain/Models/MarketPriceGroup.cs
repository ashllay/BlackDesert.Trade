namespace BlackDesert.Trade.Domain.Models;

public class MarketPriceGroup
{
  public List<KeyValuePair<int, int>> _enchantKeyList;

  public MarketPriceGroup() {
    _enchantKeyList = new List<KeyValuePair<int, int>>();
  }
}