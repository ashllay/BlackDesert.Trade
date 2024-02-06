using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblBattleRoyaleUserPlayTimeLog", Schema = "PaGamePrivate")]
public class TblBattleRoyaleUserPlayTimeLog
{
  [Column("_mDate")]
  public int? MDate { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_totalPlayTimePerDay")]
  public long? TotalPlayTimePerDay { get; set; }

  [Column("_gamePlayTimePerDay")]
  public long? GamePlayTimePerDay { get; set; }
}