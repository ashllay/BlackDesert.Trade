namespace BlackDesert.Trade.Domain.Models;

public class MarketWaitValue
{
  public MarketWaitValue() {
    _mainKey = 0;
    _subKey = 0;
    _pricePerOne = 0L;
    _waitEndTime = DateTime.MinValue;
  }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _pricePerOne { get; set; }

  public DateTime _waitEndTime { get; set; }
}