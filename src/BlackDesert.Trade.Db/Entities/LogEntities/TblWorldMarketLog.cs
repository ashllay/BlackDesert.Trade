using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Table("TblWorldMarketLog", Schema = "PaWebGamePrivate")]
public class TblWorldMarketLog
{
  [Key]
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_operationLogType")]
  public int? OperationLogType { get; set; }

  [Column("_registerUtc", TypeName = "datetime")]
  public DateTime? RegisterUtc { get; set; }

  [Column("_serverUtc", TypeName = "datetime")]
  public DateTime? ServerUtc { get; set; }

  [Column("_nationCode")]
  public int? NationCode { get; set; }

  [Column("_serverNo")]
  public int? ServerNo { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

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
  public int? Param1 { get; set; }

  [Column("_param2")]
  public int? Param2 { get; set; }

  [Column("_param3")]
  public int? Param3 { get; set; }

  [Column("_param4")]
  public int? Param4 { get; set; }

  [Column("_param5")]
  public int? Param5 { get; set; }

  [Column("_param6")]
  public int? Param6 { get; set; }

  [Column("_param7")]
  public int? Param7 { get; set; }

  [Column("_param8")]
  public int? Param8 { get; set; }

  [Column("_param9")]
  public int? Param9 { get; set; }

  [Column("_param10")]
  public int? Param10 { get; set; }

  [Column("_param11")]
  public int? Param11 { get; set; }

  [Column("_param12")]
  public int? Param12 { get; set; }

  [Column("_textParam1")]
  [StringLength(255)]
  [Unicode(false)]
  public string? TextParam1 { get; set; }

  [Column("_textParam2")]
  [StringLength(255)]
  [Unicode(false)]
  public string? TextParam2 { get; set; }

  [Column("_reason")]
  [StringLength(255)]
  [Unicode(false)]
  public string? Reason { get; set; }
}