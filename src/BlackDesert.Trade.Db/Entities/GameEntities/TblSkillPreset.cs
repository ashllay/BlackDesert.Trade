using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("CharacterNo", "SlotNo")]
[Table("TblSkillPreset", Schema = "PaGamePrivate")]
public class TblSkillPreset
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Key]
  [Column("_slotNo")]
  public int SlotNo { get; set; }

  [Column("_skillList")]
  [StringLength(4000)]
  [Unicode(false)]
  public string SkillList { get; set; } = null!;

  [Column("_isApply")]
  public bool IsApply { get; set; }

  [Column("_skillAwakeningCount")]
  public int SkillAwakeningCount { get; set; }

  [Column("_weaponSkillAwakeningCount")]
  public int WeaponSkillAwakeningCount { get; set; }

  [Column("_successionSkillAwakeningCount")]
  public int SuccessionSkillAwakeningCount { get; set; }

  [Column("_skillPoint")]
  public int SkillPoint { get; set; }

  [Column("_coolTimeList")]
  [StringLength(2000)]
  [Unicode(false)]
  public string CoolTimeList { get; set; } = null!;

  [Column("_quickSlotList")]
  [StringLength(2000)]
  [Unicode(false)]
  public string QuickSlotList { get; set; } = null!;

  [Column("_commandLockList")]
  [StringLength(2000)]
  [Unicode(false)]
  public string CommandLockList { get; set; } = null!;

  [Column("_spiritLockList")]
  [StringLength(2000)]
  [Unicode(false)]
  public string SpiritLockList { get; set; } = null!;

  [Column("_ringMenuList")]
  [StringLength(2000)]
  [Unicode(false)]
  public string RingMenuList { get; set; } = null!;
}