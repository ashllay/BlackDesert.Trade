namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketAccumulateTradeByStock
{
  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _maxTradeCount { get; set; }

  public long _sumTradeCountByStock { get; set; }
}