using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseDeleteItem", Schema = "PaGamePrivate")]
public class TblSeasonCloseDeleteItem
{
  [Column("_itemKey")]
  public int? ItemKey { get; set; }
}