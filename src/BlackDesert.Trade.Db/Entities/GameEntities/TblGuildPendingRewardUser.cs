using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "GuildNo", "RewardNo")]
[Table("TblGuildPendingRewardUser", Schema = "PaGamePrivate")]
public class TblGuildPendingRewardUser
{
  [Key]
  [Column("_rewardNo")]
  public long RewardNo { get; set; }

  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_isRecieve")]
  public bool IsRecieve { get; set; }
}