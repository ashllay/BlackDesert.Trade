using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   결전 랭크 정보
/// </summary>
[PrimaryKey("GuildNo", "Season")]
[Table("TblGuildBattleRanking", Schema = "PaGamePrivate")]
public class TblGuildBattleRanking
{
  /// <summary>
  ///   길드 넘버
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   시즌
  /// </summary>
  [Key]
  [Column("_season")]
  public int Season { get; set; }

  /// <summary>
  ///   승리
  /// </summary>
  [Column("_win")]
  public int Win { get; set; }

  /// <summary>
  ///   패배
  /// </summary>
  [Column("_lose")]
  public int Lose { get; set; }

  /// <summary>
  ///   길드 점수
  /// </summary>
  [Column("_guildBattleRating")]
  public long GuildBattleRating { get; set; }
}