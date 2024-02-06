using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "ClassType")]
[Table("TblShadowArenaCharacter", Schema = "PaGamePrivate")]
public class TblShadowArenaCharacter
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_level")]
  public int Level { get; set; }

  [Column("_experience")]
  public long Experience { get; set; }
}