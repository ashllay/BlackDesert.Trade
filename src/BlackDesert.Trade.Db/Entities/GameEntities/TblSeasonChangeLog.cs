using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonChangeLog", Schema = "PaGamePrivate")]
public class TblSeasonChangeLog
{
  [Column("_season")]
  public int? Season { get; set; }

  [Column("_message")]
  [StringLength(50)]
  public string? Message { get; set; }

  [Column("_type")]
  public int? Type { get; set; }

  [Column("_isSuccess")]
  public bool? IsSuccess { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }
}