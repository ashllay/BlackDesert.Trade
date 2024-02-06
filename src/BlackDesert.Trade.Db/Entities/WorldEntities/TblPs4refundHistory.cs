using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblPS4RefundHistory", Schema = "PaGamePrivate")]
public class TblPs4refundHistory
{
  [Column("_index")]
  public long Index { get; set; }

  [Column("_regDate", TypeName = "datetime")]
  public DateTime RegDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_entitlementId")]
  [StringLength(16)]
  public string EntitlementId { get; set; } = null!;

  [Column("_useLimit")]
  public long? UseLimit { get; set; }

  [Column("_useCount")]
  public long? UseCount { get; set; }

  [Column("_purchaseCountry")]
  [StringLength(10)]
  public string? PurchaseCountry { get; set; }
}