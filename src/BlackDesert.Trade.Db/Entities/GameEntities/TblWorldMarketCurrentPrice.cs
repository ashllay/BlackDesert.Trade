using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("MainKey", "SubKey")]
[Table("TblWorldMarketCurrentPrice", Schema = "PaGamePrivate")]
public class TblWorldMarketCurrentPrice
{
  [Key]
  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Key]
  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }
}