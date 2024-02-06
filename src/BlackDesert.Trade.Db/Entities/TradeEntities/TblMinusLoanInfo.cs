using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("Idx", "UserId")]
[Table("TblMinusLoanInfo", Schema = "PaOperationPublic")]
public class TblMinusLoanInfo
{
  [Key]
  [Column("_idx")]
  public long Idx { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Key]
  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_minusMoney")]
  public long? MinusMoney { get; set; }
}