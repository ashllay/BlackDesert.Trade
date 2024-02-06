using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblWebAdminToolLog_v3", Schema = "PaOperationPrivate")]
public class TblWebAdminToolLogV3
{
  [Column("_registerDate")]
  public DateTime RegisterDate { get; set; }

  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_accountNo")]
  public long? AccountNo { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_userIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string UserIp { get; set; } = null!;

  [Column("_logType")]
  public int LogType { get; set; }

  [Column("_reason")]
  public int Reason { get; set; }

  [Column("_executeSpName")]
  [StringLength(100)]
  public string ExecuteSpName { get; set; } = null!;

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

  [Column("_stringParam1")]
  public string? StringParam1 { get; set; }

  [Column("_stringParam2")]
  public string? StringParam2 { get; set; }

  [Column("_stringParam3")]
  public string? StringParam3 { get; set; }

  [Column("_rv")]
  public int? Rv { get; set; }
}