using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseChangeItem", Schema = "PaGamePrivate")]
public class TblSeasonCloseChangeItem
{
  [Column("_changeItemKey")]
  public int? ChangeItemKey { get; set; }

  [Column("_beforeItemKey")]
  public int? BeforeItemKey { get; set; }

  [Column("_alterItemKey")]
  public int? AlterItemKey { get; set; }
}