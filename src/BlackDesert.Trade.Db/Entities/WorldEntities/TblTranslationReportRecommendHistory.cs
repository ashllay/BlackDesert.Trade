using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("ReportNo", "UserNo")]
[Table("TblTranslationReportRecommendHistory", Schema = "PaGamePrivate")]
public class TblTranslationReportRecommendHistory
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_reportNo")]
  public long ReportNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }
}