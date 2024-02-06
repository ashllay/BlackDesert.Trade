using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_VariousNo", Schema = "PaOperationPublic")]
public class DimVariousNo1
{
  [Column("_variousNo")]
  public byte? VariousNo { get; set; }
}