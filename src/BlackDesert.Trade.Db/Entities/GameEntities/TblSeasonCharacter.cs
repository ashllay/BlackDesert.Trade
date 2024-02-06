using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCharacter", Schema = "PaGamePrivate")]
public class TblSeasonCharacter
{
  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_season")]
  public int? Season { get; set; }

  [Column("_isDeleted")]
  public bool IsDeleted { get; set; }
}