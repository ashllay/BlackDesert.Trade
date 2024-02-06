using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Table("TblWorldMarketTickCount", Schema = "PaGamePrivate")]
public class TblWorldMarketTickCount
{
  [Column("_serverIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string ServerIp { get; set; } = null!;

  [Key]
  [Column("_mainGroupNo")]
  public int MainGroupNo { get; set; }

  [Column("_currentTickCount")]
  public int CurrentTickCount { get; set; }

  [Column("_updateTickCount")]
  public int UpdateTickCount { get; set; }

  [Column("_allowIndex")]
  public int AllowIndex { get; set; }

  [Column("_LastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }

  [Column("_updateAccumulateCount")]
  public long UpdateAccumulateCount { get; set; }
}