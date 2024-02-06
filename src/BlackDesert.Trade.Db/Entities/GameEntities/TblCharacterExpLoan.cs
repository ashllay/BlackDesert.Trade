using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterNo")]
[Table("TblCharacterExpLoan", Schema = "PaGamePrivate")]
public class TblCharacterExpLoan
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_totalExperience")]
  public long TotalExperience { get; set; }

  [Column("_leftExperience")]
  public long LeftExperience { get; set; }
}