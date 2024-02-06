using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("SummonerNo", "SpawnKey")]
[Table("TblBossSpawn", Schema = "PaGamePrivate")]
public class TblBossSpawn
{
  [Key]
  [Column("_summonerNo")]
  public long SummonerNo { get; set; }

  [Key]
  [Column("_spawnKey")]
  public int SpawnKey { get; set; }

  [Column("_spawnCost")]
  public int SpawnCost { get; set; }

  [Column("_spawnCount")]
  public int SpawnCount { get; set; }

  [Column("_resetDateTime", TypeName = "datetime")]
  public DateTime ResetDateTime { get; set; }
}