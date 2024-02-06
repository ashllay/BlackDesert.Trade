using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   완료-도전과제 및 pc방 정액제
/// </summary>
[PrimaryKey("UserNo", "ChallengeKey")]
[Table("TblCompletedChallenge", Schema = "PaGamePrivate")]
public class TblCompletedChallenge
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   도전과제 키 -DataSheet_Challenge$Challenge_Table
  /// </summary>
  [Key]
  [Column("_challengeKey")]
  public int ChallengeKey { get; set; }

  /// <summary>
  ///   초기화 시간
  /// </summary>
  [Column("_resetTime", TypeName = "datetime")]
  public DateTime? ResetTime { get; set; }
}