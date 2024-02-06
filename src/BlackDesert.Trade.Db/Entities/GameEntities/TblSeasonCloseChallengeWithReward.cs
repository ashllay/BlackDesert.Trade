using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseChallengeWithReward", Schema = "PaGamePrivate")]
public class TblSeasonCloseChallengeWithReward
{
  [Column("_challengeKey")]
  public int ChallengeKey { get; set; }

  [Column("_itemKey")]
  public int? ItemKey { get; set; }

  [Column("_itemEnchant")]
  public int? ItemEnchant { get; set; }

  [Column("_itemCount")]
  public int? ItemCount { get; set; }
}