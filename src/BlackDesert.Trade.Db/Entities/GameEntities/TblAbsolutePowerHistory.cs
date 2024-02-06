using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   절대권력이력
/// </summary>
[Keyless]
[Table("TblAbsolutePowerHistory", Schema = "PaGamePrivate")]
public class TblAbsolutePowerHistory
{
  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerTime", TypeName = "datetime")]
  public DateTime RegisterTime { get; set; }

  /// <summary>
  ///   운영자 번호
  /// </summary>
  [Column("_operatorNo")]
  public long OperatorNo { get; set; }

  /// <summary>
  ///   대상 유저
  /// </summary>
  [Column("_targetUserNo")]
  public long TargetUserNo { get; set; }

  /// <summary>
  ///   저주 건 사유
  /// </summary>
  [Column("_comment")]
  public string? Comment { get; set; }

  /// <summary>
  ///   적용된 저주 들
  /// </summary>
  [Column("_curses")]
  public string Curses { get; set; } = null!;

  /// <summary>
  ///   저주 종료 시간
  /// </summary>
  [Column("_curseTime", TypeName = "datetime")]
  public DateTime CurseTime { get; set; }
}