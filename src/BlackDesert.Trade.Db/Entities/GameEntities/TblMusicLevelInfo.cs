using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblMusicLevelInfo", Schema = "PaGamePrivate")]
public class TblMusicLevelInfo
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_level")]
  public int Level { get; set; }

  [Column("_experience")]
  public long Experience { get; set; }
}