using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblMarbleGame", Schema = "PaWebGamePrivate")]
public class TblMarbleGame
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_playMarbleKey")]
  public byte PlayMarbleKey { get; set; }

  [Column("_todayPlayDiceCount")]
  public int TodayPlayDiceCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_todayFreeDiceCount")]
  public int TodayFreeDiceCount { get; set; }

  [Column("_nextFreeDiceDate", TypeName = "datetime")]
  public DateTime? NextFreeDiceDate { get; set; }

  [Column("_dailyResetDate", TypeName = "datetime")]
  public DateTime? DailyResetDate { get; set; }

  [Column("_nextPlayCardDate", TypeName = "datetime")]
  public DateTime? NextPlayCardDate { get; set; }

  [Column("_prePlayMarbleKey")]
  public byte PrePlayMarbleKey { get; set; }

  [Column("_completeCount")]
  public int CompleteCount { get; set; }

  [Column("_rewardCompleteCount")]
  public int RewardCompleteCount { get; set; }
}