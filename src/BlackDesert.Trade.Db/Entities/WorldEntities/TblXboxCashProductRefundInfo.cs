using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblXboxCashProductRefundInfo", Schema = "PaGamePrivate")]
public class TblXboxCashProductRefundInfo
{
  [Key]
  [Column("_refundNo")]
  public long RefundNo { get; set; }

  [Column("_accountNo")]
  [StringLength(30)]
  public string AccountNo { get; set; } = null!;

  [Column("_legacyProductId")]
  [StringLength(40)]
  public string LegacyProductId { get; set; } = null!;

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

  [Column("_beforeProductCount")]
  public long BeforeProductCount { get; set; }

  [Column("_afterProductCount")]
  public long AfterProductCount { get; set; }

  [Column("_isCheckProductCount")]
  public bool IsCheckProductCount { get; set; }
}