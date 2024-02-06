using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCashItemBuyCountBak", Schema = "PaOperationPrivate")]
public class TblCashItemBuyCountBak
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_isUserNo")]
  public bool IsUserNo { get; set; }

  [Column("_userCharacterNo")]
  public long UserCharacterNo { get; set; }

  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_count")]
  public int Count { get; set; }

  [Column("_resetTime")]
  public long ResetTime { get; set; }

  [Column("_type")]
  public bool? Type { get; set; }
}