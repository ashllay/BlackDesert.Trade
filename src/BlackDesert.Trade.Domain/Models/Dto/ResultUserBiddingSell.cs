namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultUserBiddingSell
{
  public long _sellNo { get; set; }

  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public int _chooseSubKey { get; set; }

  public long _leftCount { get; set; }

  public long _pricePerOne { get; set; }

  public long _soldCount { get; set; }

  public long _accumulateMoneyCount { get; set; }

  public bool _isSealed { get; set; }

  public bool _isRingBuff { get; set; }
}