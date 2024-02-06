using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드멤버정보
/// </summary>
[Table("TblGuildMember", Schema = "PaGamePrivate")]
public class TblGuildMember
{
  /// <summary>
  ///   길드가입일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   길드번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   사용자 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   길드원 등급
  /// </summary>
  [Column("_grade")]
  public byte Grade { get; set; }

  /// <summary>
  ///   멤버가 기여한 길드 성향치
  /// </summary>
  [Column("_contributedTendency")]
  public int ContributedTendency { get; set; }

  /// <summary>
  ///   다음 계약이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)
  /// </summary>
  [Column("_contractableDate", TypeName = "datetime")]
  public DateTime? ContractableDate { get; set; }

  /// <summary>
  ///   계약기간 만료(길드가 동아리 등급이면 NULL일 수 있다.)
  /// </summary>
  [Column("_contractedExpiration", TypeName = "datetime")]
  public DateTime? ContractedExpiration { get; set; }

  /// <summary>
  ///   수당(실버)	( 길드가 동아리 등급이면 NULL일 수 있다.)
  /// </summary>
  [Column("_benefit")]
  public long? Benefit { get; set; }

  /// <summary>
  ///   위약금		(길드가 동아리 등급이면 NULL일 수 있다.)
  /// </summary>
  [Column("_penalty")]
  public long? Penalty { get; set; }

  /// <summary>
  ///   수당(일당) 수금이 가능한지? 1이면 가능, NULL 이거나, 0이면 안됨
  /// </summary>
  [Column("_isCollectable")]
  public bool? IsCollectable { get; set; }

  /// <summary>
  ///   총 활동 점수
  /// </summary>
  [Column("_totalActivity")]
  public int TotalActivity { get; set; }

  /// <summary>
  ///   사용 가능한 활동 점수(고용계약시 수당 갱신에 사용)
  /// </summary>
  [Column("_usableActivity")]
  public int UsableActivity { get; set; }

  /// <summary>
  ///   계약한 일 수
  /// </summary>
  [Column("_contractedDay")]
  public int? ContractedDay { get; set; }

  /// <summary>
  ///   보호 여부? 1이면 보호, NULL 이거나, 0이면 비보호
  /// </summary>
  [Column("_isProtectable")]
  public bool? IsProtectable { get; set; }

  /// <summary>
  ///   다음 보호 여부 변경이 가능한 날짜(길드가 동아리 등급이면 NULL일 수 있다.)
  /// </summary>
  [Column("_protectableDate", TypeName = "datetime")]
  public DateTime? ProtectableDate { get; set; }

  /// <summary>
  ///   음성 채팅 말하기 on/off
  /// </summary>
  [Column("_isVoiceChatSpeak")]
  public bool IsVoiceChatSpeak { get; set; }

  /// <summary>
  ///   음성 채팅 듣기 on/off
  /// </summary>
  [Column("_isVoiceChatListen")]
  public bool IsVoiceChatListen { get; set; }

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

  /// <summary>
  ///   최근 길드인센티브 지급등급
  /// </summary>
  [Column("_incentiveGrade")]
  public int IncentiveGrade { get; set; }

  /// <summary>
  ///   공성전에 참여 가능한 전투원
  /// </summary>
  [Column("_siegeCombatant")]
  public byte SiegeCombatant { get; set; }

  /// <summary>
  ///   공성전에 참여 가능한 전투원
  /// </summary>
  [Column("_isSiegeParticipant")]
  public bool IsSiegeParticipant { get; set; }

  /// <summary>
  ///   길드 상여금
  /// </summary>
  [Column("_bonus")]
  public long Bonus { get; set; }

  /// <summary>
  ///   휴가중인지
  /// </summary>
  [Column("_isVacation")]
  public bool IsVacation { get; set; }

  /// <summary>
  ///   공성전 훈장 보상.
  /// </summary>
  [Column("_siegeMedalCount")]
  public int SiegeMedalCount { get; set; }

  /// <summary>
  ///   공성전 1등 보상.
  /// </summary>
  [Column("_siegeTopItemKey")]
  public int SiegeTopItemKey { get; set; }

  [Column("_siegeMercenaryCost")]
  public double SiegeMercenaryCost { get; set; }

  [Column("_userCharacterNoForCost")]
  public long UserCharacterNoForCost { get; set; }

  /// <summary>
  ///   공성전 보상 지급 시간.
  /// </summary>
  [Column("_lastSiegeRewardDate", TypeName = "datetime")]
  public DateTime? LastSiegeRewardDate { get; set; }

  [Column("_siegeItemKey")]
  public int SiegeItemKey { get; set; }

  [Column("_top5PercentsiegeItemCount")]
  public int Top5PercentsiegeItemCount { get; set; }

  [Column("_top5PercentsiegeItemKey")]
  public int Top5PercentsiegeItemKey { get; set; }
}