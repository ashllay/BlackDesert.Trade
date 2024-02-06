using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   도전과제 및 pc방 정액제
/// </summary>
[Keyless]
[Table("TblChallengeReward", Schema = "PaGamePrivate")]
public class TblChallengeReward
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   도전과제 키 -DataSheet_Challenge$Challenge_Table
  /// </summary>
  [Column("_challengeKey")]
  public int ChallengeKey { get; set; }

  /// <summary>
  ///   횟수
  /// </summary>
  [Column("_count")]
  public int Count { get; set; }

  /// <summary>
  ///   보상을 중복해서 줄수 있는가 여부
  /// </summary>
  [Column("_isOverlapable")]
  public bool IsOverlapable { get; set; }
}