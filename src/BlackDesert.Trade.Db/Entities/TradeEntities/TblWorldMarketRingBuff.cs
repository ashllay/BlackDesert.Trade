using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("NationCode", "ServerNo", "UserNo")]
[Table("TblWorldMarketRingBuff", Schema = "PaGamePrivate")]
public class TblWorldMarketRingBuff
{
  [Key]
  [Column("_nationCode")]
  public int NationCode { get; set; } = 0;

  [Key]
  [Column("_serverNo")]
  public int ServerNo { get; set; } = 0;

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_usingCount")]
  public int UsingCount { get; set; }

  [Column("_maxCount")]
  public int MaxCount { get; set; }
}