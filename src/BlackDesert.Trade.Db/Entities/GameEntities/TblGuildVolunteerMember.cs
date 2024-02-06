using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 용병 리스트
/// </summary>
[Keyless]
[Table("TblGuildVolunteerMember", Schema = "PaGamePrivate")]
public class TblGuildVolunteerMember
{
  /// <summary>
  ///   등록일(길드연합장의 등록일)
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   용병 길드 넘버
  /// </summary>
  [Column("_volunteerGuilNo")]
  public long VolunteerGuilNo { get; set; }

  /// <summary>
  ///   용병 계약 금액
  /// </summary>
  [Column("_contractAmount")]
  public long ContractAmount { get; set; }

  /// <summary>
  ///   용병 계약 혜택
  /// </summary>
  [Column("_contractBenefit")]
  public long ContractBenefit { get; set; }

  /// <summary>
  ///   용병 거점전 참여
  /// </summary>
  [Column("_isSiegeParticipant")]
  public bool? IsSiegeParticipant { get; set; }

  /// <summary>
  ///   길드 자금 사용 한도
  /// </summary>
  [Column("_myPriceLimit")]
  public long MyPriceLimit { get; set; }

  /// <summary>
  ///   길드 자금 사용 한도 검사 유/무
  /// </summary>
  [Required]
  [Column("_isPriceLimit")]
  public bool? IsPriceLimit { get; set; }

  [Column("_siegeMercenaryCost")]
  public int SiegeMercenaryCost { get; set; }

  [Column("_userCharacterNoForCost")]
  public long UserCharacterNoForCost { get; set; }

  [Column("_siegeMedalCount")]
  public int SiegeMedalCount { get; set; }

  [Column("_siegeItemKey")]
  public int SiegeItemKey { get; set; }

  [Column("_lastSiegeRewardDate", TypeName = "datetime")]
  public DateTime? LastSiegeRewardDate { get; set; }
}