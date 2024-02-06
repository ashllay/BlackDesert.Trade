namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarket
{
  public int _mainKey { get; set; }

  public long? _sumCount { get; set; }

  public long? _totalSumCount { get; set; }

  public long? _minPrice { get; set; }

  public int _isDisplay { get; set; } = 1;
}