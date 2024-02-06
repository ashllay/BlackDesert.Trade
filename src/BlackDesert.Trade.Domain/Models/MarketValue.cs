namespace BlackDesert.Trade.Domain.Models;

public class MarketValue
{
  public MarketValue() {
    _count = 0L;
    _totalTradedCount = 0L;
    _pricePerOne = 0L;
    _minPrice = 0L;
    _maxPrice = 0L;
    _lastTradePrice = 0L;
    _lastTradeTime = DateTime.MinValue;
    _isDisplay = 0;
  }

  public long _count { get; set; }

  public long _totalTradedCount { get; set; }

  public long _pricePerOne { get; set; }

  public long _minPrice { get; set; }

  public long _maxPrice { get; set; }

  public long _lastTradePrice { get; set; }

  public DateTime _lastTradeTime { get; set; }

  public int _isDisplay { get; set; }
}