using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblWorldMarketNoticeItem", Schema = "PaGamePrivate")]
public class TblWorldMarketNoticeItem
{
  [Column("_registTimeStamp")]
  public long RegistTimeStamp { get; set; }

  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_price")]
  public long Price { get; set; }

  [Column("_noticeType")]
  public short NoticeType { get; set; }

  [Column("_changedValue")]
  public long ChangedValue { get; set; }
}