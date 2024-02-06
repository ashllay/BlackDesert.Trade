using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("Dim_itemKey_NeedContribute", Schema = "PaOperationPublic")]
public class DimItemKeyNeedContribute
{
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_itemName")]
  public string? ItemName { get; set; }

  [Column("_NeedContribute")]
  public int? NeedContribute { get; set; }
}