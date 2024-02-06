using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   가문 생성시 추천 닉네임
/// </summary>
[Table("TblRecommandUserNickName", Schema = "PaGamePrivate")]
public class TblRecommandUserNickName
{
  /// <summary>
  ///   추천 닉네임 인덱스
  /// </summary>
  [Key]
  [Column("_recommandNickNameIndex")]
  public int RecommandNickNameIndex { get; set; }

  /// <summary>
  ///   추천 닉네임 스트링
  /// </summary>
  [Column("_recommandNickName")]
  [StringLength(26)]
  public string RecommandNickName { get; set; } = null!;

  /// <summary>
  ///   추천 닉네임 뒤에 붙을 고유 ID
  /// </summary>
  [Column("_recommandNickNameID")]
  public int RecommandNickNameId { get; set; }
}