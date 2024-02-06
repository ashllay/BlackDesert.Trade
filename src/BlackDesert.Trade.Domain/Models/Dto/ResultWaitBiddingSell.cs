namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWaitBiddingSell
{
  public long _waitNo { get; set; }

  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public bool _isSealed { get; set; }

  public int _chooseSubKey { get; set; }

  public long _leftCount { get; set; }

  public long _pricePerOne { get; set; }

  public bool _isRingBuff { get; set; }

  public int _nationCode { get; set; }

  public int _serverNo { get; set; }

  public long _userNo { get; set; }
}