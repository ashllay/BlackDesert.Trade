using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblCharacterName", Schema = "PaOperationPrivate")]
public class TblCharacterName
{
  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;
}