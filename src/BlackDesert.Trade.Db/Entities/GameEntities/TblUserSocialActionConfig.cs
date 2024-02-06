using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저를 위한 소셜액션 키워드 변경정보
/// </summary>
[PrimaryKey("UserNo", "SocialActionKey", "Type")]
[Table("TblUserSocialActionConfig", Schema = "PaGamePrivate")]
public class TblUserSocialActionConfig
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   소셜액션 키
  /// </summary>
  [Key]
  [Column("_socialActionKey")]
  public int SocialActionKey { get; set; }

  /// <summary>
  ///   타입(0:명령어,1:구문분석용)
  /// </summary>
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   저장된 데이터
  /// </summary>
  [Column("_data")]
  [StringLength(100)]
  public string Data { get; set; } = null!;
}