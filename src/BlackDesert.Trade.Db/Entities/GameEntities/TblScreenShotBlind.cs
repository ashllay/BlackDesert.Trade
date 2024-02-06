using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblScreenShotBlind", Schema = "PaWebGamePrivate")]
public class TblScreenShotBlind
{
  [Column("_screenNo")]
  public long ScreenNo { get; set; }

  [Column("_blindUserNo")]
  public long BlindUserNo { get; set; }

  [Column("_blindDate", TypeName = "datetime")]
  public DateTime BlindDate { get; set; }
}