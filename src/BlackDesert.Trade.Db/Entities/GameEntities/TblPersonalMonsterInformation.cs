using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterKey")]
[Table("TblPersonalMonsterInformation", Schema = "PaGamePrivate")]
public class TblPersonalMonsterInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  [Column("_spawnTime", TypeName = "datetime")]
  public DateTime SpawnTime { get; set; }

  [Column("_positionIndex")]
  public int PositionIndex { get; set; }

  [Column("_remainHp")]
  public int RemainHp { get; set; }

  [Column("_option")]
  public byte Option { get; set; }

  [Column("_level")]
  public byte Level { get; set; }

  [Column("_levelupTime", TypeName = "datetime")]
  public DateTime LevelupTime { get; set; }
}