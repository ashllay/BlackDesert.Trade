using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblPearlInventoryDeletedItemRestoreLog", Schema = "PaOperationPublic")]
public class TblPearlInventoryDeletedItemRestoreLog
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_itemNo")]
  public long? ItemNo { get; set; }

  [Column("_newItemNo")]
  public long? NewItemNo { get; set; }

  [Column("_ownerNo")]
  public long? OwnerNo { get; set; }

  [Column("_itemKey")]
  public long? ItemKey { get; set; }

  [Column("_symNo")]
  [StringLength(50)]
  public string? SymNo { get; set; }
}