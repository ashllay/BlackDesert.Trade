using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Season")]
[Table("TblPersonalDuelRanking", Schema = "PaGamePrivate")]
public class TblPersonalDuelRanking
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_season")]
  public int Season { get; set; }

  [Column("_winCount")]
  public int WinCount { get; set; }

  [Column("_loseCount")]
  public int LoseCount { get; set; }

  [Column("_rankRating")]
  public int RankRating { get; set; }
}