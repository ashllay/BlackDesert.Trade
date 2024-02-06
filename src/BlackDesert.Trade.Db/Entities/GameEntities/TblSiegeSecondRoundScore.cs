using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("SiegeScoreNo", "GuildNo", "RegionKey", "TerritoryKey")]
[Table("TblSiegeSecondRoundScore", Schema = "PaGamePrivate")]
public class TblSiegeSecondRoundScore
{
  [Key]
  [Column("_siegeScoreNo")]
  public int SiegeScoreNo { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime? UpdateDate { get; set; }

  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  [Column("_masterNickname")]
  [StringLength(30)]
  public string? MasterNickname { get; set; }

  [Key]
  [Column("_territoryKey")]
  public int TerritoryKey { get; set; }

  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  [Column("_hpScore")]
  public int HpScore { get; set; }

  [Column("_buildScore")]
  public int BuildScore { get; set; }

  [Column("_killScore")]
  public int KillScore { get; set; }

  [Column("_deathScore")]
  public int DeathScore { get; set; }

  [Column("_destroyTime")]
  public long DestroyTime { get; set; }
}