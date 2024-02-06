using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "SlotNo")]
[Table("TblUserEnchantStackSlot", Schema = "PaGamePrivate")]
public class TblUserEnchantStackSlot
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_slotNo")]
  public byte SlotNo { get; set; }

  [Column("_enchantStack")]
  public int EnchantStack { get; set; }

  [Column("_enchantStackExp")]
  public long EnchantStackExp { get; set; }

  [Column("_enchantAddedStack")]
  public int EnchantAddedStack { get; set; }
}