using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드기본정보
/// </summary>
[Table("TblGuild", Schema = "PaGamePrivate")]
public class TblGuild
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_lastActiveDate", TypeName = "datetime")]
  public DateTime LastActiveDate { get; set; }

  /// <summary>
  ///   길드번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   길드명
  /// </summary>
  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  /// <summary>
  ///   길드 기본 정보 캐쉬
  /// </summary>
  [Column("_guildBasicCacheSeqNo")]
  public int GuildBasicCacheSeqNo { get; set; }

  /// <summary>
  ///   길드마스터 사용자번호
  /// </summary>
  [Column("_masterUserNo")]
  public long MasterUserNo { get; set; }

  /// <summary>
  ///   길드마스터 가문명
  /// </summary>
  [Column("_masterUserNickname")]
  [StringLength(30)]
  public string? MasterUserNickname { get; set; }

  /// <summary>
  ///   _skillPointLevel
  /// </summary>
  [Column("_skillPointLevel")]
  public int SkillPointLevel { get; set; }

  /// <summary>
  ///   _remainedSkillPoint
  /// </summary>
  [Column("_remainedSkillPoint")]
  public int RemainedSkillPoint { get; set; }

  /// <summary>
  ///   _aquiredSkillPoint
  /// </summary>
  [Column("_aquiredSkillPoint")]
  public int AquiredSkillPoint { get; set; }

  /// <summary>
  ///   _skillExperience
  /// </summary>
  [Column("_skillExperience")]
  public long SkillExperience { get; set; }

  [Column("_guildMarkRegisterTime", TypeName = "datetime")]
  public DateTime? GuildMarkRegisterTime { get; set; }

  /// <summary>
  ///   _guildMarkSeqNo
  /// </summary>
  [Column("_guildMarkSeqNo")]
  public int GuildMarkSeqNo { get; set; }

  /// <summary>
  ///   길드마크
  /// </summary>
  [Column("_guildMark")]
  public byte[]? GuildMark { get; set; }

  /// <summary>
  ///   길드인원변화량
  /// </summary>
  [Column("_variedMemberCount")]
  public int VariedMemberCount { get; set; }

  /// <summary>
  ///   길드보호인원변화량
  /// </summary>
  [Column("_variedProtectMemberCount")]
  public int VariedProtectMemberCount { get; set; }

  /// <summary>
  ///   길드성향
  /// </summary>
  [Column("_tendency")]
  public int Tendency { get; set; }

  /// <summary>
  ///   길드등급
  /// </summary>
  [Column("_guildGrade")]
  public byte GuildGrade { get; set; }

  /// <summary>
  ///   법인세를 못 낸 경고 횟수(법인세 납부시 0으로 초기화됨)
  /// </summary>
  [Column("_taxWarningCount")]
  public byte TaxWarningCount { get; set; }

  /// <summary>
  ///   미납된 누적 법인세
  /// </summary>
  [Column("_accumulateTax")]
  public long AccumulateTax { get; set; }

  /// <summary>
  ///   인센티브 지급날짜
  /// </summary>
  [Column("_incentiveDate", TypeName = "datetime")]
  public DateTime? IncentiveDate { get; set; }

  /// <summary>
  ///   길드하우스유지비
  /// </summary>
  [Column("_accumulateHouseCost")]
  public long AccumulateHouseCost { get; set; }

  /// <summary>
  ///   일일 가능 길드 퀘스트
  /// </summary>
  [Column("_availableGuildQuestCount")]
  public byte AvailableGuildQuestCount { get; set; }

  /// <summary>
  ///   길드 공지사항
  /// </summary>
  [Column("_guildNotice")]
  [StringLength(300)]
  public string? GuildNotice { get; set; }

  [Column("_guildIntroduction")]
  [StringLength(200)]
  public string? GuildIntroduction { get; set; }

  /// <summary>
  ///   길드 복지자금 전달
  /// </summary>
  [Column("_guildWelfare")]
  public bool GuildWelfare { get; set; }

  /// <summary>
  ///   점령전 체력 감소 스택
  /// </summary>
  [Column("_siegeDecreaseHpStack")]
  [StringLength(1)]
  [Unicode(false)]
  public string SiegeDecreaseHpStack { get; set; } = null!;

  /// <summary>
  ///   지난 주 점령전 점령 여부
  /// </summary>
  [Column("_isOccupyLastWeek")]
  [StringLength(1)]
  [Unicode(false)]
  public string IsOccupyLastWeek { get; set; } = null!;

  [Column("_adviserUserNo")]
  public long? AdviserUserNo { get; set; }

  [Column("_guildMainServerGroupNo")]
  public short GuildMainServerGroupNo { get; set; }

  [Column("_guildMainServerRegisterDate", TypeName = "datetime")]
  public DateTime GuildMainServerRegisterDate { get; set; }
}