using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblTutorialCharacterInfo", Schema = "PaGamePrivate")]
public class TblTutorialCharacterInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }
}