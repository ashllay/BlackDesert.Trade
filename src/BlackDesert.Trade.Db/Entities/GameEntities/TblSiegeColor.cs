using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblSiegeColor", Schema = "PaGamePrivate")]
public class TblSiegeColor
{
  [Key]
  [Column("_colorIndex")]
  public int ColorIndex { get; set; }

  [Column("_guildNo")]
  public long? GuildNo { get; set; }
}