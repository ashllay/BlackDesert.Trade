using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("Dim_MentalCardList", Schema = "PaOperationPublic")]
public class DimMentalCardList
{
  [Column("_cardKey")]
  public int CardKey { get; set; }

  [Column("_level")]
  public int Level { get; set; }
}