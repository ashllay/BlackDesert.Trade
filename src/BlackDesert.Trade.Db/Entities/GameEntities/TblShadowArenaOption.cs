using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblShadowArenaOption", Schema = "PaGamePrivate")]
public class TblShadowArenaOption
{
  [Column("_season")]
  public int Season { get; set; }
}