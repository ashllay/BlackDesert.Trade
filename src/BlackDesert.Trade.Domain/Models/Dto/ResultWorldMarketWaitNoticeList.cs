namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketWaitNoticeList
{
  public long _waitNo { get; set; }

  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _chooseSubKey { get; set; }

  public long _leftCount { get; set; }

  public long _pricePerOne { get; set; }

  public long _resultMoneyCount { get; set; }

  public byte _usedType { get; set; }
}