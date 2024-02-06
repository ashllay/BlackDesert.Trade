namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultLoadWorldMarketInfo
{
  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _maxPrice { get; set; }

  public long _minPrice { get; set; }

  public int _mainCategory { get; set; }

  public int _subCategory { get; set; }

  public long _maxTradeCount { get; set; }
}