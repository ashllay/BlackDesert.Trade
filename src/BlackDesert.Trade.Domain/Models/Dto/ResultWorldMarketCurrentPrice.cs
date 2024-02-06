namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketCurrentPrice
{
  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _pricePerOne { get; set; }
}