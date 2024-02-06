using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblSupplyCount", Schema = "PaGamePrivate")]
public class TblSupplyCount
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_tradeCountForSilver")]
  public long TradeCountForSilver { get; set; }

  [Column("_tradeCountForShell")]
  public long TradeCountForShell { get; set; }

  [Column("_nextResetTime", TypeName = "datetime")]
  public DateTime NextResetTime { get; set; }
}