using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("Type", "GuildNo")]
[Table("TblGuildLifeRankingInfo", Schema = "PaWebGamePrivate")]
public class TblGuildLifeRankingInfo
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_levelSum")]
  public int? LevelSum { get; set; }
}