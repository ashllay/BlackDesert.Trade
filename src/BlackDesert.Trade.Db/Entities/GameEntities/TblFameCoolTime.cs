using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("CharacterNo", "BadCharacterNo")]
[Table("TblFameCoolTime", Schema = "PaGamePrivate")]
public class TblFameCoolTime
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Key]
  [Column("_badCharacterNo")]
  public long BadCharacterNo { get; set; }

  [Column("_lastFameUpdateTime", TypeName = "datetime")]
  public DateTime LastFameUpdateTime { get; set; }
}