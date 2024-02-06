using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaBriefUserInformation", Schema = "PaGamePrivate")]
public class TblShadowArenaBriefUserInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_accountLevel")]
  public int AccountLevel { get; set; }

  [Column("_accountExp")]
  public long AccountExp { get; set; }

  [Column("_isOnline")]
  public bool IsOnline { get; set; }

  [Column("_isEnterBattle")]
  public bool IsEnterBattle { get; set; }

  [Column("_expBoostEndTime", TypeName = "datetime")]
  public DateTime ExpBoostEndTime { get; set; }

  [Column("_moneyBoostEndTime", TypeName = "datetime")]
  public DateTime MoneyBoostEndTime { get; set; }

  [Column("_skinSetting")]
  [StringLength(2000)]
  public string? SkinSetting { get; set; }

  [Column("_isNewMail")]
  public bool IsNewMail { get; set; }

  [Column("_allCharacterBoostEndTime", TypeName = "datetime")]
  public DateTime AllCharacterBoostEndTime { get; set; }

  [Column("_preliminaryMatchTicket")]
  public int PreliminaryMatchTicket { get; set; }

  [Column("_mainMatchTicket")]
  public int MainMatchTicket { get; set; }

  [Column("_specialMatchTicket")]
  public int SpecialMatchTicket { get; set; }

  [Column("_lastClassType")]
  public byte? LastClassType { get; set; }

  [Required]
  [Column("_isTutorialComplete")]
  public bool? IsTutorialComplete { get; set; }

  [Column("_weaponSkinSetting")]
  [StringLength(2000)]
  public string? WeaponSkinSetting { get; set; }

  [Column("_currentAccountRewardLevel")]
  public int CurrentAccountRewardLevel { get; set; }

  [Column("_selectedProfileIconKey")]
  public short SelectedProfileIconKey { get; set; }

  [Column("_selectedProfileFrameKey")]
  public short? SelectedProfileFrameKey { get; set; }

  [Column("_selectedProfileEffectKey")]
  public short? SelectedProfileEffectKey { get; set; }

  [Column("_lastTutorialFlowType")]
  public byte? LastTutorialFlowType { get; set; }

  [Column("_authorityIndex")]
  public byte AuthorityIndex { get; set; }
}