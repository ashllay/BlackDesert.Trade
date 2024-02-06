using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblBattleHeroRanking", Schema = "PaWebGamePrivate")]
public class TblBattleHeroRanking
{
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_score")]
  public long Score { get; set; }

  [Column("_joinCountSeize")]
  public int JoinCountSeize { get; set; }

  [Column("_winCountSeize")]
  public int WinCountSeize { get; set; }

  [Column("_killCountSeize")]
  public int KillCountSeize { get; set; }

  [Column("_joinCountBase")]
  public int JoinCountBase { get; set; }

  [Column("_winCountBase")]
  public int WinCountBase { get; set; }

  [Column("_killCountBase")]
  public int KillCountBase { get; set; }

  [Column("_rankingRowNum")]
  public long RankingRowNum { get; set; }

  [Column("_beforeRankingRowNum")]
  public long? BeforeRankingRowNum { get; set; }
}