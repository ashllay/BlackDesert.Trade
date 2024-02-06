using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_Node_NeedContribute", Schema = "PaOperationPublic")]
public class DimNodeNeedContribute
{
  [Column("_wayPointKey")]
  public double? WayPointKey { get; set; }

  [Column("_needExplorePoint")]
  public double? NeedExplorePoint { get; set; }

  [Column("_name")]
  [StringLength(255)]
  public string? Name { get; set; }

  [Column("_Type")]
  [StringLength(255)]
  public string? Type { get; set; }
}