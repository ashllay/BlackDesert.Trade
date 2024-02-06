using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGreatSeaRepository", Schema = "PaGamePrivate")]
public class TblGreatSeaRepository
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_maxEmployeeCount")]
  public long MaxEmployeeCount { get; set; }

  [Column("_eventTime", TypeName = "datetime")]
  public DateTime EventTime { get; set; }

  [Column("_supriseEventTime", TypeName = "datetime")]
  public DateTime SupriseEventTime { get; set; }
}