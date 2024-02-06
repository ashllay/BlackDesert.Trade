using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("RoomNo", "UserNo")]
[Table("TblMessengerInfo", Schema = "PaGamePrivate")]
public class TblMessengerInfo
{
  [Key]
  [Column("_roomNo")]
  public long RoomNo { get; set; }

  [Column("_roomType")]
  public byte RoomType { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_messageReadIndex")]
  public long MessageReadIndex { get; set; }

  [Required]
  [Column("_alarmIsOn")]
  public bool? AlarmIsOn { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}