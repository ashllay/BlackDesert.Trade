using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblScreenShotLikeLog", Schema = "PaWebGamePrivate")]
public class TblScreenShotLikeLog
{
  [Column("_screenNo")]
  public long ScreenNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_LikeDate", TypeName = "datetime")]
  public DateTime LikeDate { get; set; }
}