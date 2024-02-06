using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCustomizingReportLog", Schema = "PaWebGamePrivate")]
public class TblCustomizingReportLog
{
  [Column("_customizingCommentNo")]
  public long CustomizingCommentNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }

  [Column("_blindType")]
  public byte BlindType { get; set; }

  [Column("_reportDate", TypeName = "datetime")]
  public DateTime ReportDate { get; set; }
}