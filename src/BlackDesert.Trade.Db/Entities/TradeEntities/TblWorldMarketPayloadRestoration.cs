using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Table("TblWorldMarketPayloadRestoration", Schema = "PaGamePrivate")]
public class TblWorldMarketPayloadRestoration
{
  [Key]
  [Column("_payload")]
  public long Payload { get; set; }

  [Column("_type")]
  public short Type { get; set; }

  [Column("_gameState")]
  public short GameState { get; set; }

  [Column("_marketState")]
  public short MarketState { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_isSealed")]
  public bool IsSealed { get; set; }

  [Column("_param0")]
  public long Param0 { get; set; }

  [Column("_param1")]
  public long Param1 { get; set; }

  [Column("_param2")]
  public long Param2 { get; set; }

  [Column("_param3")]
  public long Param3 { get; set; }

  [Column("_param4")]
  public long Param4 { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_completeDate", TypeName = "datetime")]
  public DateTime CompleteDate { get; set; }

  [Column("_beforeTotalCount")]
  public long BeforeTotalCount { get; set; }

  [Column("_afterTotalCount")]
  public long AfterTotalCount { get; set; }
}