using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TExplorationExpTable", Schema = "PaOperationPublic")]
public class TexplorationExpTable
{
  [Column("_level")]
  public int? Level { get; set; }

  [Column("_maxExp")]
  public long? MaxExp { get; set; }
}