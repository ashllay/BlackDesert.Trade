using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   스킬 정보
/// </summary>
[PrimaryKey("CharacterNo", "IsPlayer", "SkillNo")]
[Table("TblSkill", Schema = "PaGamePrivate")]
public class TblSkill
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   스킬번호
  /// </summary>
  [Key]
  [Column("_skillNo")]
  public int SkillNo { get; set; }

  /// <summary>
  ///   스킬 배우는 방법 타입
  /// </summary>
  [Column("_skillLearningType")]
  public byte SkillLearningType { get; set; }

  /// <summary>
  ///   스킬 포인트타입(전투,생산)
  /// </summary>
  [Column("_skillPointType")]
  public byte SkillPointType { get; set; }

  /// <summary>
  ///   _skillLevel
  /// </summary>
  [Column("_skillLevel")]
  public int SkillLevel { get; set; }

  /// <summary>
  ///   _isPlayer
  /// </summary>
  [Key]
  [Column("_isPlayer")]
  public bool IsPlayer { get; set; }
}