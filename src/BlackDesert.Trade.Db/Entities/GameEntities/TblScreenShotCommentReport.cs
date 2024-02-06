using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblScreenShotCommentReport", Schema = "PaWebGamePrivate")]
public class TblScreenShotCommentReport
{
  [Column("_screenCommentNo")]
  public long ScreenCommentNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }

  [Column("_blindType")]
  [StringLength(1)]
  [Unicode(false)]
  public string BlindType { get; set; } = null!;

  [Column("_reportDate", TypeName = "datetime")]
  public DateTime ReportDate { get; set; }
}