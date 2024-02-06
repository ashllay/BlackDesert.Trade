using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBlackMarble", Schema = "PaWebGamePrivate")]
public class TblBlackMarble
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_nowPosition")]
  public byte NowPosition { get; set; }

  [Column("_finishCount")]
  public int FinishCount { get; set; }

  [Column("_todayCount")]
  public byte TodayCount { get; set; }

  [Column("_lastPlayDate", TypeName = "datetime")]
  public DateTime? LastPlayDate { get; set; }
}