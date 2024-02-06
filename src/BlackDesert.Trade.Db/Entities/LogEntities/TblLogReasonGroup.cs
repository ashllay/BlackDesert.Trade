using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[PrimaryKey("LogReasonGroupNo", "LogReasonNo")]
[Table("TblLogReasonGroup", Schema = "PaOperationPrivate")]
public class TblLogReasonGroup
{
  [Key]
  [Column("_logReasonGroupNo")]
  public short LogReasonGroupNo { get; set; }

  [Key]
  [Column("_logReasonNo")]
  public short LogReasonNo { get; set; }
}