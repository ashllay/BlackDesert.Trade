using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ItemKey", "EnchantLevel")]
[Table("TblWarningItemList", Schema = "PaOperationPrivate")]
public class TblWarningItemList
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Key]
  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }
}