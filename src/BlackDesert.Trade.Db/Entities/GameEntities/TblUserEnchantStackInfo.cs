using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblUserEnchantStackInfo", Schema = "PaGamePrivate")]
public class TblUserEnchantStackInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_enableSlotCount")]
  public byte EnableSlotCount { get; set; }

  [Column("_enchantCoolTime", TypeName = "datetime")]
  public DateTime? EnchantCoolTime { get; set; }
}