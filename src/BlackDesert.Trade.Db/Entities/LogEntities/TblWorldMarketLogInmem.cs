using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblWorldMarketLog_INMEM", Schema = "PaWebGamePrivate")]
public class TblWorldMarketLogInmem
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_operationLogType")]
  public int OperationLogType { get; set; }

  [Column("_registerUtc", TypeName = "datetime")]
  public DateTime RegisterUtc { get; set; }

  [Column("_serverUtc", TypeName = "datetime")]
  public DateTime ServerUtc { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_keyType1")]
  public int? KeyType1 { get; set; }

  [Column("_mainKey1")]
  public int? MainKey1 { get; set; }

  [Column("_subKey1")]
  public int? SubKey1 { get; set; }

  [Column("_count1")]
  public long? Count1 { get; set; }

  [Column("_beforeCount1")]
  public long? BeforeCount1 { get; set; }

  [Column("_afterCount1")]
  public long? AfterCount1 { get; set; }

  [Column("_beforeCount2")]
  public long? BeforeCount2 { get; set; }

  [Column("_afterCount2")]
  public long? AfterCount2 { get; set; }

  [Column("_keyType2")]
  public int? KeyType2 { get; set; }

  [Column("_mainKey2")]
  public int? MainKey2 { get; set; }

  [Column("_subKey2")]
  public int? SubKey2 { get; set; }

  [Column("_count2")]
  public long? Count2 { get; set; }

  [Column("_param1")]
  public long? Param1 { get; set; }

  [Column("_param2")]
  public long? Param2 { get; set; }

  [Column("_param3")]
  public long? Param3 { get; set; }

  [Column("_param4")]
  public long? Param4 { get; set; }

  [Column("_param5")]
  public long? Param5 { get; set; }

  [Column("_param6")]
  public long? Param6 { get; set; }

  [Column("_param7")]
  public long? Param7 { get; set; }

  [Column("_param8")]
  public long? Param8 { get; set; }

  [Column("_param9")]
  public long? Param9 { get; set; }

  [Column("_param10")]
  public long? Param10 { get; set; }

  [Column("_param11")]
  public long? Param11 { get; set; }

  [Column("_param12")]
  public long? Param12 { get; set; }

  [Column("_textParam1")]
  [StringLength(30)]
  public string? TextParam1 { get; set; }

  [Column("_textParam2")]
  [StringLength(30)]
  public string? TextParam2 { get; set; }

  [Column("_reason")]
  public short? Reason { get; set; }
}