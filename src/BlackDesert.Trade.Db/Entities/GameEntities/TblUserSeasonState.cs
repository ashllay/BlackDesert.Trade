using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblUserSeasonState", Schema = "PaGamePrivate")]
public class TblUserSeasonState
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_totalCompleteSeasonCount")]
  public byte TotalCompleteSeasonCount { get; set; }

  [Column("_remainCompleteSeasonCount")]
  public byte RemainCompleteSeasonCount { get; set; }

  [Column("_lastCompletedSeasonNo")]
  public byte LastCompletedSeasonNo { get; set; }
}