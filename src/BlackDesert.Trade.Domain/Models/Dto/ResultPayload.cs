namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultPayload
{
  public long? _payload { get; set; }

  public short? _state { get; set; }

  public int? _nationCode { get; set; }

  public int? _serverNo { get; set; }

  public long? _userNo { get; set; }

  public int? _keyType { get; set; }

  public int? _mainKey { get; set; }

  public int? _subKey { get; set; }

  public bool? _isSealed { get; set; }

  public long? _param0 { get; set; }

  public long? _param1 { get; set; }

  public long? _param2 { get; set; }

  public long? _param3 { get; set; }

  public long? _param4 { get; set; }

  public long? _count { get; set; }

  public bool? _isMovingTradeWeb { get; set; }

  public DateTime? _registerDate { get; set; }
}