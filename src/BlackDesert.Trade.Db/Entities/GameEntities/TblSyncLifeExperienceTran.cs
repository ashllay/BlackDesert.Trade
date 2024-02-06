using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSyncLifeExperience_Tran", Schema = "PaWebGamePrivate")]
public class TblSyncLifeExperienceTran
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

  [Column("_isChange")]
  public int IsChange { get; set; }
}