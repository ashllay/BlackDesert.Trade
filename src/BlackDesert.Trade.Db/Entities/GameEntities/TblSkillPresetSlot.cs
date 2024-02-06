using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterNo")]
[Table("TblSkillPresetSlot", Schema = "PaGamePrivate")]
public class TblSkillPresetSlot
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_slotCount")]
  public int SlotCount { get; set; }

  [Column("_cashSlotItemCount")]
  public int CashSlotItemCount { get; set; }
}