using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   결전 종료 정보
/// </summary>
[Table("TblCompletedPersonalBattle", Schema = "PaGamePrivate")]
public class TblCompletedPersonalBattle
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
  ///   이긴 팀 번호
  /// </summary>
  [Column("_winTeamNo")]
  public byte WinTeamNo { get; set; }

  /// <summary>
  ///   패배 팀 번호
  /// </summary>
  [Column("_loseTeamNo")]
  public byte LoseTeamNo { get; set; }

  /// <summary>
  ///   결전 결과
  /// </summary>
  [Column("_state")]
  public short State { get; set; }
}