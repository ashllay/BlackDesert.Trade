using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   펫
/// </summary>
[Table("TblPet", Schema = "PaGamePrivate")]
public class TblPet
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _petNo
  /// </summary>
  [Key]
  [Column("_petNo")]
  public long PetNo { get; set; }

  /// <summary>
  ///   _characterKey
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   소유 사용자번호
  /// </summary>
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  [Column("_name")]
  [StringLength(30)]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   펫의 레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   펫의 경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }

  /// <summary>
  ///   펫의 애정도
  /// </summary>
  [Column("_lovely")]
  public int Lovely { get; set; }

  /// <summary>
  ///   펫의 배고픔
  /// </summary>
  [Column("_hungry")]
  public int Hungry { get; set; }

  /// <summary>
  ///   펫의 외형
  /// </summary>
  [Column("_actionIndex")]
  public int ActionIndex { get; set; }

  /// <summary>
  ///   _learnedFlag
  /// </summary>
  [Column("_learnedFlag")]
  public long LearnedFlag { get; set; }

  /// <summary>
  ///   _learnedEquipSkillFlag
  /// </summary>
  [Column("_learnedEquipSkillFlag")]
  public long LearnedEquipSkillFlag { get; set; }

  /// <summary>
  ///   펫이 맡겨져있는지
  /// </summary>
  [Required]
  [Column("_isSealed")]
  public bool? IsSealed { get; set; }

  /// <summary>
  ///   맡겨진 상태 값
  /// </summary>
  [Column("_petState")]
  public byte PetState { get; set; }

  /// <summary>
  ///   _petLootingType
  /// </summary>
  [Column("_petLootingType")]
  public byte PetLootingType { get; set; }

  /// <summary>
  ///   _petType
  /// </summary>
  [Column("_petType")]
  public byte PetType { get; set; }

  /// <summary>
  ///   _upgradeStackCount
  /// </summary>
  [Column("_upgradeStackCount")]
  public byte UpgradeStackCount { get; set; }
}