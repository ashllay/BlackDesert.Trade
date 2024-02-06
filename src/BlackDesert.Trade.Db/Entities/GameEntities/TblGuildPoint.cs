using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildPoint", Schema = "PaGamePrivate")]
public class TblGuildPoint
{
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildPoint")]
  public int GuildPoint { get; set; }

  [Column("_guildTotalPoint")]
  public int GuildTotalPoint { get; set; }

  [Key]
  [Column("_territoryKey")]
  public long TerritoryKey { get; set; }
}