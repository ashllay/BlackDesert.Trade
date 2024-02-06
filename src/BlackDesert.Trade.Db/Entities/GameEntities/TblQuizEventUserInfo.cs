using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblQuizEventUserInfo", Schema = "PaGamePrivate")]
public class TblQuizEventUserInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_correctCount")]
  public short CorrectCount { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }
}