using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblWorldBoss", Schema = "PaGamePrivate")]
public class TblWorldBoss
{
  [Key]
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  [Column("_currentHp")]
  public int CurrentHp { get; set; }

  [Column("_updateTime", TypeName = "datetime")]
  public DateTime UpdateTime { get; set; }
}