using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Key", "Day")]
[Table("TblShadowArenaAttendance", Schema = "PaGamePrivate")]
public class TblShadowArenaAttendance
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_key")]
  public int Key { get; set; }

  [Key]
  [Column("_day")]
  public byte Day { get; set; }

  [Column("_receiveDate", TypeName = "datetime")]
  public DateTime? ReceiveDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}