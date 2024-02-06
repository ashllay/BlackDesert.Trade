using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("NationCode", "ServerNo", "UserNo")]
[Table("TblWorldMarketWalletInfo", Schema = "PaGamePrivate")]
public class TblWorldMarketWalletInfo
{
  [Key]
  [Column("_nationCode")]
  public int NationCode { get; set; } = 0;

  [Key]
  [Column("_serverNo")]
  public int ServerNo { get; set; } = 0;

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_userId")]
  [StringLength(60)]
  public string UserId { get; set; } = null!;

  [Column("_personalTradeBuyCount")]
  public long PersonalTradeBuyCount { get; set; }

  [Column("_personalTradeSellCount")]
  public long PersonalTradeSellCount { get; set; }

  [Column("_resetTime", TypeName = "datetime")]
  public DateTime ResetTime { get; set; }

  [Column("_weight")]
  public long Weight { get; set; }

  [Column("_addWeight")]
  public long AddWeight { get; set; }

  [Column("_packageExpiration", TypeName = "datetime")]
  public DateTime PackageExpiration { get; set; }

  [Column("_pearlItemLimitedresetTime", TypeName = "datetime")]
  public DateTime PearlItemLimitedresetTime { get; set; }

  [Column("_pearlItemLimitedCount")]
  public long PearlItemLimitedCount { get; set; }

  [Column("_addPearlItemLimitedCount")]
  public int AddPearlItemLimitedCount { get; set; }

  [Column("_maidCount")]
  public int MaidCount { get; set; }

  [Column("_isGameMaster")]
  public bool IsGameMaster { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_addTaxDiscountRate")]
  public double AddTaxDiscountRate { get; set; }

  [Column("_blackUserCheckTime", TypeName = "datetime")]
  public DateTime BlackUserCheckTime { get; set; }

  [Column("_blackUserCheckCount")]
  public int BlackUserCheckCount { get; set; }

  [Column("_familySkillAddTaxDiscountRate")]
  public int FamilySkillAddTaxDiscountRate { get; set; }

  [Column("_lastSecondPwdFailDate", TypeName = "datetime")]
  public DateTime? LastSecondPwdFailDate { get; set; }

  [Column("_secondPwdFailCount")]
  public byte SecondPwdFailCount { get; set; }

  [Column("_addWeightBuffExpiration", TypeName = "datetime")]
  public DateTime AddWeightBuffExpiration { get; set; }

  [Column("_addWeightByBuff")]
  public long AddWeightByBuff { get; set; }

  [Column("_lastConfirmOtpTime", TypeName = "datetime")]
  public DateTime? LastConfirmOtpTime { get; set; }
}