using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   투표 테이블
/// </summary>
[Table("TblVote", Schema = "PaGamePrivate")]
public class TblVote
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   투표한 자신
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   후보자 캐릭터번호
  /// </summary>
  [Column("_toCharacterNo")]
  public long ToCharacterNo { get; set; }
}