using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblTradeCompanyLog", Schema = "PaGamePrivate")]
public class TblTradeCompanyLog
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  [Column("_tradeGroupIndex")]
  public int TradeGroupIndex { get; set; }

  [Column("_logType")]
  public byte LogType { get; set; }

  [Column("_param1")]
  public int Param1 { get; set; }

  [Column("_param2")]
  public int? Param2 { get; set; }

  [Column("_param3")]
  public int? Param3 { get; set; }

  [Column("_param4")]
  public int? Param4 { get; set; }
}