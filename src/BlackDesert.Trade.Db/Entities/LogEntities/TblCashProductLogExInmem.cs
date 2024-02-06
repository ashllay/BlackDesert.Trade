using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblCashProductLogEx_INMEM", Schema = "PaGamePrivate")]
public class TblCashProductLogExInmem
{
  [Column("_logNo")]
  public long? LogNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_cashProductNo")]
  public int? CashProductNo { get; set; }

  [Column("_cashItemCount")]
  public long? CashItemCount { get; set; }

  [Column("_reason")]
  public long? Reason { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_originalPearlCount")]
  public long? OriginalPearlCount { get; set; }

  [Column("_realUsePearlCount")]
  public long? RealUsePearlCount { get; set; }

  [Column("_discountPercent")]
  public byte? DiscountPercent { get; set; }

  [Column("_useCouponKey")]
  public int? UseCouponKey { get; set; }

  [Column("_eventCartkey")]
  public int? EventCartkey { get; set; }
}