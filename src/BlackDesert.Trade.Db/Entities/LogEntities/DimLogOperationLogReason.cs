using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Table("Dim_Log_OperationLogReason", Schema = "PaOperationPublic")]
public class DimLogOperationLogReason
{
  [Key]
  [Column("_logReasonNo")]
  public short LogReasonNo { get; set; }

  [Column("_logReasonName")]
  public string? LogReasonName { get; set; }
}