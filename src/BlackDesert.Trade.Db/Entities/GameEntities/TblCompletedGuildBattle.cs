using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   결전 종료 정보
/// </summary>
[Table("TblCompletedGuildBattle", Schema = "PaGamePrivate")]
public class TblCompletedGuildBattle
{
  /// <summary>
  ///   종료 시간
  /// </summary>
  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }

  /// <summary>
  ///   시즌
  /// </summary>
  [Column("_season")]
  public int Season { get; set; }

  /// <summary>
  ///   결전 고유 번호
  /// </summary>
  [Key]
  [Column("_battleNo")]
  public long BattleNo { get; set; }

  /// <summary>
  ///   이긴 길드 번호
  /// </summary>
  [Column("_winGuildNo")]
  public long WinGuildNo { get; set; }

  /// <summary>
  ///   패배 길드 번호
  /// </summary>
  [Column("_loseGuildNo")]
  public long LoseGuildNo { get; set; }

  /// <summary>
  ///   해당 결전 상금
  /// </summary>
  [Column("_state")]
  public long State { get; set; }
}