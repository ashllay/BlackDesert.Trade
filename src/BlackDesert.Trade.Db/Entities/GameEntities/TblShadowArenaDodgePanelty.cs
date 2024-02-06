using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaDodgePanelty", Schema = "PaGamePrivate")]
public class TblShadowArenaDodgePanelty
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_todayCount")]
  public byte TodayCount { get; set; }

  [Column("_joinableTime", TypeName = "datetime")]
  public DateTime? JoinableTime { get; set; }

  [Column("_nextResetTime", TypeName = "datetime")]
  public DateTime NextResetTime { get; set; }
}