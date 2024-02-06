using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCharacterExpLoanLog", Schema = "PaGamePrivate")]
public class TblCharacterExpLoanLog
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_level")]
  public int Level { get; set; }

  [Column("_beforeExperience")]
  public long BeforeExperience { get; set; }

  [Column("_decreaseExperience")]
  public long DecreaseExperience { get; set; }
}