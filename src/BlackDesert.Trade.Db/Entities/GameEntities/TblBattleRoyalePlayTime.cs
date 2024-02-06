using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBattleRoyalePlayTime", Schema = "PaGamePrivate")]
public class TblBattleRoyalePlayTime
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_totalPlayTime")]
  public long TotalPlayTime { get; set; }

  [Column("_gamePlayTime")]
  public long GamePlayTime { get; set; }

  [Column("_totalPlayTimePerDay")]
  public long TotalPlayTimePerDay { get; set; }

  [Column("_gamePlayTimePerDay")]
  public long GamePlayTimePerDay { get; set; }

  [Column("_lastAccumulateTime", TypeName = "datetime")]
  public DateTime LastAccumulateTime { get; set; }

  [Column("_lastSoloGameTime", TypeName = "datetime")]
  public DateTime LastSoloGameTime { get; set; }

  [Column("_lastTeamGameTime", TypeName = "datetime")]
  public DateTime LastTeamGameTime { get; set; }
}