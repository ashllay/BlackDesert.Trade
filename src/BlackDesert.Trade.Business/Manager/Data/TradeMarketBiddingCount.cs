namespace BlackDesert.Trade.Business.Manager.Data;

public class TradeMarketBiddingCount
{
  public TradeMarketBiddingCount() {
    _sellCount = 0L;
    _buyCount = 0L;
  }

  public long _sellCount { get; set; }

  public long _buyCount { get; set; }
}