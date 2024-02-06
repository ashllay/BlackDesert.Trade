using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   캐릭터 요약정보
/// </summary>
[PrimaryKey("CharacterNo", "UserNo", "WorldNo")]
[Table("TblBriefCharacterInformation", Schema = "PaGamePrivate")]
public class TblBriefCharacterInformation
{
  /// <summary>
  ///   참인 경우에만 선택할 수 있는 캐릭터
  /// </summary>
  [Required]
  [Column("_isValid")]
  public bool? IsValid { get; set; }

  /// <summary>
  ///   유저 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   월드 번호
  /// </summary>
  [Key]
  [Column("_worldNo")]
  public short WorldNo { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   캐릭터 명
  /// </summary>
  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  /// <summary>
  ///   레벨
  /// </summary>
  [Column("_level")]
  public int? Level { get; set; }

  /// <summary>
  ///   생성일
  /// </summary>
  [Column("_createDate", TypeName = "datetime")]
  public DateTime? CreateDate { get; set; }

  /// <summary>
  ///   삭제일
  /// </summary>
  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  /// <summary>
  ///   최종 로그인
  /// </summary>
  [Column("_lastLoginTime", TypeName = "datetime")]
  public DateTime? LastLoginTime { get; set; }

  /// <summary>
  ///   최종 로그아웃
  /// </summary>
  [Column("_lastLogoutTime", TypeName = "datetime")]
  public DateTime? LastLogoutTime { get; set; }

  /// <summary>
  ///   총 플레이시간(분)
  /// </summary>
  [Column("_totalPlayTime")]
  public long? TotalPlayTime { get; set; }

  /// <summary>
  ///   메인 캐릭터여부
  /// </summary>
  [Column("_isMain")]
  public bool? IsMain { get; set; }

  /// <summary>
  ///   클래스
  /// </summary>
  [Column("_classType")]
  public byte? ClassType { get; set; }

  /// <summary>
  ///   소속영지
  /// </summary>
  [Column("_affiliatedTerritoryKey")]
  public long? AffiliatedTerritoryKey { get; set; }
}