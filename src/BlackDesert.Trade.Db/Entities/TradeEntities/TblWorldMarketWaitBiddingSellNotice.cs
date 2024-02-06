using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Keyless]
[Table("TblWorldMarketWaitBiddingSellNotice", Schema = "PaGamePrivate")]
public class TblWorldMarketWaitBiddingSellNotice
{
  [Column("_waitNo")]
  public long WaitNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; } = 0;

  [Column("_serverNo")]
  public int ServerNo { get; set; } = 0;

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_usedType")]
  public byte UsedType { get; set; }

  [Column("_resultMoneyCount")]
  public long ResultMoneyCount { get; set; }

  [Column("_status")]
  public byte Status { get; set; }
}