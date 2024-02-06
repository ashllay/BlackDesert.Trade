using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("Idx", "UserId")]
[Table("TblMinusLoanResultInfo", Schema = "PaOperationPublic")]
public class TblMinusLoanResultInfo
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

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string? UserNickname { get; set; }

  [Column("_minusMoney")]
  public long? MinusMoney { get; set; }

  [Column("_beforeMoney")]
  public long? BeforeMoney { get; set; }

  [Column("_afterMoney")]
  public long? AfterMoney { get; set; }
}