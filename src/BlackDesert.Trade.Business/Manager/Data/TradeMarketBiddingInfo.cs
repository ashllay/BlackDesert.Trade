namespace BlackDesert.Trade.Business.Manager.Data;

public class TradeMarketBiddingInfo
{
  public TradeMarketBiddingInfo(int itemKey,
                                int itemEnchantLevel) {
    _itemKey = itemKey;
    _itemEnchantLevel = itemEnchantLevel;
    _biddingList = new Dictionary<long, TradeMarketBiddingCount>();
  }

  public int _itemKey { get; set; }

  public int _itemEnchantLevel { get; set; }

  public Dictionary<long, TradeMarketBiddingCount> _biddingList { get; set; }
}