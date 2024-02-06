using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSyncLifeExperience", Schema = "PaWebGamePrivate")]
public class TblSyncLifeExperience
{
  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_level")]
  public int Level { get; set; }
}