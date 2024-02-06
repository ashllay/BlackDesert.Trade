using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonParam", Schema = "PaGamePrivate")]
public class TblSeasonParam
{
  [Column("_season")]
  public int? Season { get; set; }

  [Column("_type")]
  public int? Type { get; set; }

  [Column("_infoNo")]
  public int? InfoNo { get; set; }

  [Column("_info")]
  [StringLength(50)]
  public string? Info { get; set; }

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
}