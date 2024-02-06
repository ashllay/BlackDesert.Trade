using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "MonsterKey", "SpawnDate", "Status")]
[Table("TblBlackSpiritAdventureMonster", Schema = "PaWebGamePrivate")]
public class TblBlackSpiritAdventureMonster
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_monsterKey")]
  public int MonsterKey { get; set; }

  [Column("_monsterType")]
  public byte MonsterType { get; set; }

  [Column("_regionKey")]
  public int RegionKey { get; set; }

  [Key]
  [Column("_status")]
  public bool Status { get; set; }

  [Key]
  [Column("_spawnDate", TypeName = "datetime")]
  public DateTime SpawnDate { get; set; }

  [Column("_killDate", TypeName = "datetime")]
  public DateTime? KillDate { get; set; }
}