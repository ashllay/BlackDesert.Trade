using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_InstancefieldKey", Schema = "PaOperationPublic")]
public class DimInstancefieldKey
{
  [Column("_type")]
  public int? Type { get; set; }

  [Column("_typeHex")]
  [StringLength(10)]
  public string? TypeHex { get; set; }

  [Column("_name")]
  [StringLength(30)]
  public string? Name { get; set; }
}