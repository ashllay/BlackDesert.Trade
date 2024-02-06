using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblTrPerformance", Schema = "PaGamePrivate")]
public class TblTrPerformance
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_serverNo")]
  public long ServerNo { get; set; }

  [Column("_trId")]
  public int TrId { get; set; }

  [Column("_trName")]
  [StringLength(50)]
  public string? TrName { get; set; }

  [Column("_callCount")]
  public int CallCount { get; set; }

  [Column("_totalElapsedTime")]
  public long TotalElapsedTime { get; set; }

  [Column("_slowElapsedTime")]
  public long SlowElapsedTime { get; set; }

  [Column("_lastStartTime")]
  public long LastStartTime { get; set; }
}