namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketWait
{
  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _chooseSubKey { get; set; }

  public long _pricePerOne { get; set; }

  public DateTime? _waitEndTime { get; set; }
}