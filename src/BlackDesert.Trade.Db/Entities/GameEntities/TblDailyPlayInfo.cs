using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "InstanceFieldKey")]
[Table("TblDailyPlayInfo", Schema = "PaGamePrivate")]
public class TblDailyPlayInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_playCount")]
  public byte PlayCount { get; set; }

  [Column("_nextResetTime", TypeName = "datetime")]
  public DateTime NextResetTime { get; set; }
}