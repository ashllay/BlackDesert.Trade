using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

// [Keyless]
[Table("TblWorldMarketOption", Schema = "PaGamePrivate")]
public class TblWorldMarketOption
{
  [Required]
  [Column("_isMarketOpen")]
  [Key]
  public bool? IsMarketOpen { get; set; }

  [Column("_ringBuff")]
  public int RingBuff { get; set; }

  [Required]
  [Column("_isRingBuff")]
  public bool? IsRingBuff { get; set; }

  [Column("_waitPrice")]
  public long WaitPrice { get; set; }
}