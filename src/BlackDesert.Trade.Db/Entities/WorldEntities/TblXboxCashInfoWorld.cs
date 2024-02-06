using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("AccountNo", "LegacyProductId")]
[Table("TblXboxCashInfoWorld", Schema = "PaGamePrivate")]
public class TblXboxCashInfoWorld
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_accountNo")]
  [StringLength(30)]
  public string AccountNo { get; set; } = null!;

  [Key]
  [Column("_legacyProductId")]
  [StringLength(40)]
  public string LegacyProductId { get; set; } = null!;

  [Column("_productCount")]
  public long ProductCount { get; set; }

  [Column("_consumeCount")]
  public long ConsumeCount { get; set; }

  [Column("_purchaseCountry")]
  [StringLength(10)]
  public string PurchaseCountry { get; set; } = null!;
}