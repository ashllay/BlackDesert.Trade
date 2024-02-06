using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CardKey")]
[Table("TblAutoChessDeck", Schema = "PaGamePrivate")]
public class TblAutoChessDeck
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_cardKey")]
  public long CardKey { get; set; }

  [Column("_grade")]
  public int Grade { get; set; }

  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  [Column("_level")]
  public int Level { get; set; }

  [Column("_hp")]
  public int Hp { get; set; }

  [Column("_experience")]
  public long Experience { get; set; }

  [Column("_offence")]
  public int Offence { get; set; }

  [Column("_defence")]
  public int Defence { get; set; }
}