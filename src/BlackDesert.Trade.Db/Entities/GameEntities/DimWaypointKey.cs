using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_WaypointKey", Schema = "PaOperationPublic")]
public class DimWaypointKey
{
  [Column("_waypointKey")]
  public int WaypointKey { get; set; }

  [Column("_value")]
  public short? Value { get; set; }
}