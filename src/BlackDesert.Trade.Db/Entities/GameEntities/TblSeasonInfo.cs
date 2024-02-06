using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonInfo", Schema = "PaGamePrivate")]
public class TblSeasonInfo
{
  [Column("_season")]
  public int? Season { get; set; }

  [Column("_seasonName")]
  [StringLength(50)]
  public string? SeasonName { get; set; }

  [Column("_startDate", TypeName = "date")]
  public DateTime? StartDate { get; set; }

  [Column("_endDate", TypeName = "date")]
  public DateTime? EndDate { get; set; }
}