using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblWindDirection", Schema = "PaGamePrivate")]
public class TblWindDirection
{
  [Column("_seed")]
  public long Seed { get; set; }

  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }
}