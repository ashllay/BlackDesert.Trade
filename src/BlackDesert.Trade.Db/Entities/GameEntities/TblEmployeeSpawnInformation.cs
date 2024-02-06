using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "PositionIndex")]
[Table("TblEmployeeSpawnInformation", Schema = "PaGamePrivate")]
public class TblEmployeeSpawnInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_status")]
  public byte Status { get; set; }

  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  [Key]
  [Column("_positionIndex")]
  public int PositionIndex { get; set; }

  [Column("_spawnTime", TypeName = "datetime")]
  public DateTime SpawnTime { get; set; }

  [Column("_nextSpawnTime", TypeName = "datetime")]
  public DateTime NextSpawnTime { get; set; }
}