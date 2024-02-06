using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TargetItem", Schema = "PaOperationPrivate")]
public class TargetItem
{
  [Key]
  [Column("_itemKey")]
  public long ItemKey { get; set; }
}