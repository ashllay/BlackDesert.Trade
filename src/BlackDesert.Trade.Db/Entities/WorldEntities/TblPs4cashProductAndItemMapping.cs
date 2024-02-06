using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblPS4CashProductAndItemMapping", Schema = "PaGamePrivate")]
public class TblPs4cashProductAndItemMapping
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_entitlementId")]
  [StringLength(16)]
  public string EntitlementId { get; set; } = null!;

  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_nationType")]
  public byte NationType { get; set; }

  [Column("_description")]
  [StringLength(200)]
  public string? Description { get; set; }

  [Column("_isBundleProduct")]
  public bool IsBundleProduct { get; set; }
}