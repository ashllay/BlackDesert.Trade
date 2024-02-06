using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 전쟁 정보
/// </summary>
[PrimaryKey("GuildNo", "TargetGuildNo")]
[Table("TblGuildWar", Schema = "PaGamePrivate")]
public class TblGuildWar
{
  /// <summary>
  ///   전쟁 시작 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   길드 번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   전쟁 선포한 길드 번호
  /// </summary>
  [Key]
  [Column("_targetGuildNo")]
  public long TargetGuildNo { get; set; }

  /// <summary>
  ///   킬수
  /// </summary>
  [Column("_kill")]
  public int Kill { get; set; }

  /// <summary>
  ///   사망수
  /// </summary>
  [Column("_death")]
  public int Death { get; set; }

  /// <summary>
  ///   전쟁 페널티 누적 수치
  /// </summary>
  [Column("_penaltyCount")]
  public int PenaltyCount { get; set; }

  /// <summary>
  ///   전쟁 페널티 마지막 갱신 시간
  /// </summary>
  [Column("_lastUpdatePenaltyDate", TypeName = "datetime")]
  public DateTime LastUpdatePenaltyDate { get; set; }
}