using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   펄 획득, 사용량 누적내역
/// </summary>
[Table("TblPearlUsedAmount", Schema = "PaGamePrivate")]
public class TblPearlUsedAmount
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   일간 펄 획득량
  /// </summary>
  [Column("_pearlObtainedDaily")]
  public long PearlObtainedDaily { get; set; }

  /// <summary>
  ///   일간 펄 사용량
  /// </summary>
  [Column("_pearlUsedDaily")]
  public long PearlUsedDaily { get; set; }

  /// <summary>
  ///   일단위 펄 사용량 리셋 시간
  /// </summary>
  [Column("_dailyResetTime", TypeName = "datetime")]
  public DateTime DailyResetTime { get; set; }

  /// <summary>
  ///   주간 펄 획득량
  /// </summary>
  [Column("_pearlObtainedWeekly")]
  public long PearlObtainedWeekly { get; set; }

  /// <summary>
  ///   주간 펄 사용량
  /// </summary>
  [Column("_pearlUsedWeekly")]
  public long PearlUsedWeekly { get; set; }

  /// <summary>
  ///   주단위 펄 사용량 리셋 시간
  /// </summary>
  [Column("_weeklyResetTime", TypeName = "datetime")]
  public DateTime WeeklyResetTime { get; set; }

  /// <summary>
  ///   월간 펄 획득량
  /// </summary>
  [Column("_pearlObtainedMonthly")]
  public long PearlObtainedMonthly { get; set; }

  /// <summary>
  ///   월간 펄 사용량
  /// </summary>
  [Column("_pearlUsedMonthly")]
  public long PearlUsedMonthly { get; set; }

  /// <summary>
  ///   월단위 펄 사용량 리셋 시간
  /// </summary>
  [Column("_monthlyResetTime", TypeName = "datetime")]
  public DateTime MonthlyResetTime { get; set; }

  /// <summary>
  ///   총 누적 펄 획득량
  /// </summary>
  [Column("_pearlObtainedTotal")]
  public long PearlObtainedTotal { get; set; }

  /// <summary>
  ///   총 누적 펄 사용량
  /// </summary>
  [Column("_pearlUsedTotal")]
  public long PearlUsedTotal { get; set; }
}