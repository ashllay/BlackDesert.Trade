using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "EquipSlotNo")]
[Table("TblCaphrasBonusSlot", Schema = "PaGamePrivate")]
public class TblCaphrasBonusSlot
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_equipSlotNo")]
  public byte EquipSlotNo { get; set; }

  [Column("_value")]
  public byte Value { get; set; }
}