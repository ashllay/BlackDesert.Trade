using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblXboxCashProductAndItemMapping", Schema = "PaGamePrivate")]
public class TblXboxCashProductAndItemMapping
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_legacyProductId")]
  [StringLength(40)]
  public string LegacyProductId { get; set; } = null!;

  [Column("_productId")]
  [StringLength(40)]
  public string ProductId { get; set; } = null!;

  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_nationType")]
  public byte NationType { get; set; }

  [Column("_description")]
  [StringLength(200)]
  public string? Description { get; set; }

  [Column("_isBundleProduct")]
  public bool IsBundleProduct { get; set; }

  [Column("_isSingularItem")]
  public bool IsSingularItem { get; set; }
}