using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaAttendanceOption", Schema = "PaGamePrivate")]
public class TblShadowArenaAttendanceOption
{
  [Key]
  [Column("_key")]
  public int Key { get; set; }

  [Column("_beginDate", TypeName = "datetime")]
  public DateTime BeginDate { get; set; }

  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }
}