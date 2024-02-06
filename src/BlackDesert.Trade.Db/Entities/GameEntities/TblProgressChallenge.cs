using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   진행중-도전과제 및 pc방 정액제
/// </summary>
[PrimaryKey("UserNo", "ChallengeKey")]
[Table("TblProgressChallenge", Schema = "PaGamePrivate")]
public class TblProgressChallenge
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
  ///   도전과제 키-DataSheet_Challenge$Challenge_Table
  /// </summary>
  [Key]
  [Column("_challengeKey")]
  public int ChallengeKey { get; set; }

  [Column("_paramNumber")]
  public int ParamNumber { get; set; }

  [Column("_paramTime")]
  public long ParamTime { get; set; }
}