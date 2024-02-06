using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   스킬 각성 정보 ( 리뉴얼 )
/// </summary>
[PrimaryKey("CharacterNo", "SkillNo")]
[Table("TblSkillAwakeningVersion2", Schema = "PaGamePrivate")]
public class TblSkillAwakeningVersion2
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
  ///   _awakeningBitFlag
  /// </summary>
  [Column("_awakeningBitFlag")]
  public int AwakeningBitFlag { get; set; }
}