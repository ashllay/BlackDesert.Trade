using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblLeaveLog", Schema = "LeaveUser")]
public class TblLeaveLog
{
  [Column("_mDate", TypeName = "datetime")]
  public DateTime? MDate { get; set; }

  [Column("_step")]
  public int? Step { get; set; }

  [Column("_msg")]
  [StringLength(2000)]
  public string? Msg { get; set; }

  [Column("_rv")]
  public long? Rv { get; set; }

  [Column("_rowCount")]
  public long? RowCount { get; set; }
}