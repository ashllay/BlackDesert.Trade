using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaLastBattleResultInfo", Schema = "PaGamePrivate")]
public class TblShadowArenaLastBattleResultInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_changeTierPoint")]
  public short ChangeTierPoint { get; set; }

  [Column("_isReceiveReward")]
  public bool IsReceiveReward { get; set; }

  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_rewardMoney")]
  public long RewardMoney { get; set; }

  [Column("_kill")]
  public byte Kill { get; set; }

  [Column("_death")]
  public byte Death { get; set; }

  [Column("_assist")]
  public byte Assist { get; set; }

  [Column("_ranking")]
  public int Ranking { get; set; }
}