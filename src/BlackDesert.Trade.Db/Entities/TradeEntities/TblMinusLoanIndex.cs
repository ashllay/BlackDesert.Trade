using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Keyless]
[Table("TblMinusLoanIndex", Schema = "PaOperationPublic")]
public class TblMinusLoanIndex
{
  [Column("_idx")]
  public long Idx { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_count")]
  public long? Count { get; set; }

  [Column("_result")]
  public bool? Result { get; set; }
}