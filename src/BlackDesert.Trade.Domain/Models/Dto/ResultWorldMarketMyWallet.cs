namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultWorldMarketMyWallet
{
  public int _nationCode { get; set; } = 0;

  public int _serverNo { get; set; } = 0;

  public long _userNo { get; set; }

  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public bool _isSealed { get; set; }

  public long _count { get; set; }
}