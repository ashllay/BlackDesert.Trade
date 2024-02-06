using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildPendingReward", Schema = "PaGamePrivate")]
public class TblGuildPendingReward
{
  [Key]
  [Column("_rewardNo")]
  public long RewardNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_expireDate", TypeName = "datetime")]
  public DateTime ExpireDate { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_itemString")]
  [StringLength(4000)]
  [Unicode(false)]
  public string ItemString { get; set; } = null!;
}