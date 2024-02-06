using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblLimitedCashProduct", Schema = "PaGamePrivate")]
public class TblLimitedCashProduct
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_maxCount")]
  public int MaxCount { get; set; }

  [Column("_remainedCount")]
  public int RemainedCount { get; set; }

  [Column("_discountPrice")]
  public int DiscountPrice { get; set; }

  [Column("_salesStartPeriod", TypeName = "datetime")]
  public DateTime? SalesStartPeriod { get; set; }

  [Column("_salesEndPeriod", TypeName = "datetime")]
  public DateTime? SalesEndPeriod { get; set; }

  [Column("_isLimitedCount")]
  public bool IsLimitedCount { get; set; }
}