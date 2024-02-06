using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 결전 정보
/// </summary>
[Table("TblCompletedGuildDuel", Schema = "PaGamePrivate")]
public class TblCompletedGuildDuel
{
  /// <summary>
  ///   길드 결전 번호
  /// </summary>
  [Key]
  [Column("_duelNo")]
  public long DuelNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   결전 선포한 길드 번호
  /// </summary>
  [Column("_declareGuildNo")]
  public long DeclareGuildNo { get; set; }

  /// <summary>
  ///   결전 수락한 길드 번호
  /// </summary>
  [Column("_acceptGuildNo")]
  public long AcceptGuildNo { get; set; }

  /// <summary>
  ///   목표 킬수
  /// </summary>
  [Column("_targetKill")]
  public int TargetKill { get; set; }

  /// <summary>
  ///   상금
  /// </summary>
  [Column("_prize")]
  public long Prize { get; set; }

  /// <summary>
  ///   선포한 길드가 죽인 횟수
  /// </summary>
  [Column("_declareGuildKill")]
  public int DeclareGuildKill { get; set; }

  /// <summary>
  ///   마감 시간
  /// </summary>
  [Column("_deadline", TypeName = "datetime")]
  public DateTime Deadline { get; set; }

  /// <summary>
  ///   종료 시간
  /// </summary>
  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }

  /// <summary>
  ///   수락한 길드가 죽인 횟수
  /// </summary>
  [Column("_acceptGuildKill")]
  public int AcceptGuildKill { get; set; }
}