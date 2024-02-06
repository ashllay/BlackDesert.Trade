using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBattleRoyaleUserInfo", Schema = "PaGamePrivate")]
public class TblBattleRoyaleUserInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_skinKey")]
  public int SkinKey { get; set; }

  [Column("_weaponSkinKey")]
  public int WeaponSkinKey { get; set; }

  [Column("_isNormalMode")]
  public bool IsNormalMode { get; set; }

  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_totalUserCount")]
  public int TotalUserCount { get; set; }

  [Column("_origOnlineRanking")]
  public int OrigOnlineRanking { get; set; }

  [Column("_afterOnlineRanking")]
  public int AfterOnlineRanking { get; set; }

  [Column("_partyBotClassSetting")]
  [StringLength(2000)]
  [Unicode(false)]
  public string? PartyBotClassSetting { get; set; }

  [Column("_autoMatchingType")]
  public byte AutoMatchingType { get; set; }
}