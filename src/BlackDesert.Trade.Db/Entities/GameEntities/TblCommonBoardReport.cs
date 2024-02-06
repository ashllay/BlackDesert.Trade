using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("BoardType", "BoardNo", "UserNo")]
[Table("TblCommonBoardReport", Schema = "PaWebGamePrivate")]
public class TblCommonBoardReport
{
  [Key]
  [Column("_boardType")]
  public byte BoardType { get; set; }

  [Key]
  [Column("_boardNo")]
  public long BoardNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }

  [Column("_blindType")]
  public byte BlindType { get; set; }

  [Column("_regDate", TypeName = "datetime")]
  public DateTime RegDate { get; set; }

  [Column("_reportType")]
  public byte ReportType { get; set; }
}