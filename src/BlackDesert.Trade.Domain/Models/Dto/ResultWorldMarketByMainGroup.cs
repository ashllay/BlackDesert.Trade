namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketByMainGroup
{
  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _pricePerOne { get; set; }

  public long _count { get; set; }
}