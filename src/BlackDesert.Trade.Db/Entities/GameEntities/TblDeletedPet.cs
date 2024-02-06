using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblDeletedPet", Schema = "PaGamePrivate")]
public class TblDeletedPet
{
  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_petNo")]
  public long? PetNo { get; set; }

  [Column("_characterKey")]
  public int? CharacterKey { get; set; }

  [Column("_ownerUserNo")]
  public long? OwnerUserNo { get; set; }

  [Column("_name")]
  [StringLength(30)]
  public string? Name { get; set; }

  [Column("_level")]
  public int? Level { get; set; }

  [Column("_experience")]
  public long? Experience { get; set; }

  [Column("_lovely")]
  public int? Lovely { get; set; }

  [Column("_hungry")]
  public int? Hungry { get; set; }

  [Column("_actionIndex")]
  public int? ActionIndex { get; set; }

  [Column("_learnedFlag")]
  public long? LearnedFlag { get; set; }

  [Column("_learnedEquipSkillFlag")]
  public long? LearnedEquipSkillFlag { get; set; }

  [Column("_isSealed")]
  public bool? IsSealed { get; set; }

  [Column("_petState")]
  public byte? PetState { get; set; }

  [Column("_petLootingType")]
  public byte? PetLootingType { get; set; }

  [Column("_petType")]
  public byte? PetType { get; set; }

  [Column("_upgradeStackCount")]
  public byte? UpgradeStackCount { get; set; }
}