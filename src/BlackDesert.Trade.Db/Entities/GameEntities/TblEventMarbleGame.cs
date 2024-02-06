using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblEventMarbleGame", Schema = "PaWebGamePrivate")]
public class TblEventMarbleGame
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_playMarbleKey")]
  public byte PlayMarbleKey { get; set; }

  [Column("_prePlayMarbleKey")]
  public byte PrePlayMarbleKey { get; set; }

  [Column("_completeCount")]
  public int CompleteCount { get; set; }

  [Column("_rewardCompleteCount")]
  public int RewardCompleteCount { get; set; }

  [Column("_todayPlayDiceCount")]
  public int TodayPlayDiceCount { get; set; }

  [Column("_dailyResetDate", TypeName = "datetime")]
  public DateTime DailyResetDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}