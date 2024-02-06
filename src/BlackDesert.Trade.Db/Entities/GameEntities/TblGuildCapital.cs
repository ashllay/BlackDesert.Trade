using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildCapital", Schema = "PaGamePrivate")]
public class TblGuildCapital
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_regionKey")]
  public int RegionKey { get; set; }
}