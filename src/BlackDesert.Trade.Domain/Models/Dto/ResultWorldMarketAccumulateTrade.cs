namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketAccumulateTrade
{
  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _pricePerOne { get; set; }

  public long _sumTradeCount { get; set; }

  public long _sumTradePrice { get; set; }

  public long _maxPrice { get; set; }

  public long _minPrice { get; set; }

  public long _maxTradeCount { get; set; }

  public long _accumulateTickCount { get; set; }

  public long _accumulateBiddingCount { get; set; }

  public long _priceGroupKey { get; set; }
}