using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   출석 테이블(매달 초기화됨)
/// </summary>
[PrimaryKey("UserNo", "AttendanceKey")]
[Table("TblAttendance", Schema = "PaGamePrivate")]
public class TblAttendance
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   출석키
  /// </summary>
  [Key]
  [Column("_attendanceKey")]
  public int AttendanceKey { get; set; }

  /// <summary>
  ///   출석일수(한달간)
  /// </summary>
  [Column("_attendanceCount")]
  public int AttendanceCount { get; set; }

  /// <summary>
  ///   출석 보상수령
  /// </summary>
  [Column("_receivedReward")]
  public int ReceivedReward { get; set; }

  /// <summary>
  ///   출석한 시간
  /// </summary>
  [Column("_onAttendanceTime", TypeName = "datetime")]
  public DateTime OnAttendanceTime { get; set; }

  /// <summary>
  ///   중복 출석 횟수
  /// </summary>
  [Column("_overlapCount")]
  public int OverlapCount { get; set; }
}