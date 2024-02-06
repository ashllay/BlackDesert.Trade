using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCharacterDetailInformation", Schema = "PaGamePrivate")]
public class TblCharacterDetailInformation
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_currentBlackSpiritForm")]
  public int? CurrentBlackSpiritForm { get; set; }
}