using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Table("TblLogReasonGroupName", Schema = "PaOperationPrivate")]
public class TblLogReasonGroupName
{
  [Key]
  [Column("_logReasonGroupNo")]
  public short LogReasonGroupNo { get; set; }

  [Column("_logReasonGroupName")]
  [StringLength(30)]
  public string LogReasonGroupName { get; set; } = null!;

  [Column("_logReasonGroupMemo")]
  [StringLength(50)]
  public string LogReasonGroupMemo { get; set; } = null!;
}