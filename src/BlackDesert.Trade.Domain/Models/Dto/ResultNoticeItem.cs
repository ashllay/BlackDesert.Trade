namespace BlackDesert.Trade.Domain.Models.Db;

public class ResultNoticeItem
{
  public long _registTimeStamp { get; set; }

  public int _keyType { get; set; }

  public int _mainKey { get; set; }

  public int _subKey { get; set; }

  public long _price { get; set; }

  public long _changedValue { get; set; }

  public short _noticeType { get; set; }
}