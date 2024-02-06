using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblPS4CashProductRefundInfo", Schema = "PaGamePrivate")]
public class TblPs4cashProductRefundInfo
{
  [Key]
  [Column("_refundNo")]
  public long RefundNo { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_entitlementId")]
  [StringLength(16)]
  public string EntitlementId { get; set; } = null!;

  [Column("_ProductId")]
  [StringLength(40)]
  public string ProductId { get; set; } = null!;

  [Column("_refundCount")]
  public long RefundCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_completeDate", TypeName = "datetime")]
  public DateTime? CompleteDate { get; set; }

  [Column("_cancelDate", TypeName = "datetime")]
  public DateTime? CancelDate { get; set; }

  [Column("_refundState")]
  public byte RefundState { get; set; }

  [Column("_beforeConsumeCount")]
  public long BeforeConsumeCount { get; set; }

  [Column("_afterConsumeCount")]
  public long AfterConsumeCount { get; set; }

  [Column("_beforeUseCount")]
  public long BeforeUseCount { get; set; }

  [Column("_afterUseCount")]
  public long AfterUseCount { get; set; }

  [Column("_isCheckProductCount")]
  public bool IsCheckProductCount { get; set; }
}