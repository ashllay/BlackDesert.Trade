namespace BlackDesert.Trade.Domain.Models;

public class TradeMarketVariedPriceInfo
{
  public readonly long _endPrice;
  public readonly int _index;
  public readonly long _passBiddingCount;
  public readonly long _startPrice;
  public readonly long _uintPrice;
  public readonly long _worldMarketPricePoint;

  public TradeMarketVariedPriceInfo() {
    _startPrice = 0L;
    _endPrice = 0L;
    _uintPrice = 0L;
    _index = 0;
    _passBiddingCount = 0L;
    _worldMarketPricePoint = 0L;
  }

  public TradeMarketVariedPriceInfo(
    long startPrice,
    long endPrice,
    long uintPrice,
    int index,
    long passBiddingCount,
    long worldMarketPricePoint) {
    _startPrice = startPrice;
    _endPrice = endPrice;
    _uintPrice = uintPrice;
    _index = index;
    _passBiddingCount = passBiddingCount;
    _worldMarketPricePoint = worldMarketPricePoint;
  }
}