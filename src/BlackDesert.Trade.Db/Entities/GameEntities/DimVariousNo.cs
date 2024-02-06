using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_VariousNo", Schema = "PaGamePrivate")]
public class DimVariousNo
{
  [Column("_variousNo")]
  public byte? VariousNo { get; set; }
}