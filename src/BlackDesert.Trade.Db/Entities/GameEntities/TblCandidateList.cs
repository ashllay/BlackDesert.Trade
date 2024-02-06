using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   후보자 리스트 테이블
/// </summary>
[Keyless]
[Table("TblCandidateList", Schema = "PaGamePrivate")]
public class TblCandidateList
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   후보자 유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   후보자 캐릭터번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   클래스 타입
  /// </summary>
  [Column("_classType")]
  public byte ClassType { get; set; }

  /// <summary>
  ///   투표 수
  /// </summary>
  [Column("_voteCount")]
  public long VoteCount { get; set; }

  [Column("_resign")]
  public byte Resign { get; set; }
}