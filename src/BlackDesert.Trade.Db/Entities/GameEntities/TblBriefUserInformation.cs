using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   게임서버를 위한 간단한 유저정보
/// </summary>
[Table("TblBriefUserInformation", Schema = "PaGamePrivate")]
public class TblBriefUserInformation
{
  /// <summary>
  ///   간단 유저정보 최초 등록일시
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   퍼블리셔에서 넘어온 유저번호
  /// </summary>
  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  /// <summary>
  ///   유저별명
  /// </summary>
  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  /// <summary>
  ///   최근 로그인시간
  /// </summary>
  [Column("_lastLoginTime", TypeName = "datetime")]
  public DateTime LastLoginTime { get; set; }

  /// <summary>
  ///   최근 로그아웃시간
  /// </summary>
  [Column("_lastLogoutTime", TypeName = "datetime")]
  public DateTime LastLogoutTime { get; set; }

  /// <summary>
  ///   총 플레이 시간
  /// </summary>
  [Column("_totalPlayTime")]
  public long TotalPlayTime { get; set; }

  /// <summary>
  ///   PC방 플레이 시간(초)
  /// </summary>
  [Column("_pcRoomPlayTimePerDay")]
  public long PcRoomPlayTimePerDay { get; set; }

  /// <summary>
  ///   PC방 리셋 시간
  /// </summary>
  [Column("_playResetTimePerDay", TypeName = "datetime")]
  public DateTime PlayResetTimePerDay { get; set; }

  /// <summary>
  ///   플레이 시간 (초)(하루 동안)
  /// </summary>
  [Column("_playTimePerDay")]
  public long PlayTimePerDay { get; set; }

  /// <summary>
  ///   PC방 누적 플레이 시간(초)
  /// </summary>
  [Column("_accumulatePcRoomPlayTime")]
  public long AccumulatePcRoomPlayTime { get; set; }

  /// <summary>
  ///   최근 IP
  /// </summary>
  [Column("_lastIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string LastIp { get; set; } = null!;

  /// <summary>
  ///   최근 (플레이)캐릭터 번호
  /// </summary>
  [Column("_lastCharacterNo")]
  public long LastCharacterNo { get; set; }

  /// <summary>
  ///   참이면 PC전환중임
  /// </summary>
  [Column("_isPcSwitching")]
  public bool IsPcSwitching { get; set; }

  /// <summary>
  ///   참이면 최초 접속자
  /// </summary>
  [Required]
  [Column("_isFirstLogin")]
  public bool? IsFirstLogin { get; set; }

  /// <summary>
  ///   누적 접속 횟수
  /// </summary>
  [Column("_accumulatedLoginCount")]
  public int AccumulatedLoginCount { get; set; }

  /// <summary>
  ///   현재 서버 No
  /// </summary>
  [Column("_enterServerNo")]
  public short EnterServerNo { get; set; }

  /// <summary>
  ///   탐험포인트
  /// </summary>
  [Column("_explorationPoint")]
  public int ExplorationPoint { get; set; }

  /// <summary>
  ///   캐릭터를 생성한 횟수
  /// </summary>
  [Column("_characterCreationCount")]
  public int CharacterCreationCount { get; set; }

  /// <summary>
  ///   PVP가능상태
  /// </summary>
  [Column("_isPvpAble")]
  public bool IsPvpAble { get; set; }

  /// <summary>
  ///   소속영지
  /// </summary>
  [Column("_affiliatedTerritoryKey")]
  public long AffiliatedTerritoryKey { get; set; }

  /// <summary>
  ///   유저정보 갱신번호
  /// </summary>
  [Column("_userBasicCacheSeqNo")]
  public int UserBasicCacheSeqNo { get; set; }

  /// <summary>
  ///   증가된 캐릭터 슬롯 갯수
  /// </summary>
  [Column("_variedCharacterSlotCount")]
  public short VariedCharacterSlotCount { get; set; }

  /// <summary>
  ///   스타터 패키지 버프 만료일시(널이거나 과거면 버프없음)
  /// </summary>
  [Column("_starterPackageBuffExpiration", TypeName = "datetime")]
  public DateTime? StarterPackageBuffExpiration { get; set; }

  /// <summary>
  ///   프리미엄패키지 버프 만료일시(널이거나 과거면 버프없음)
  /// </summary>
  [Column("_premiumPackageBuffExpiration", TypeName = "datetime")]
  public DateTime? PremiumPackageBuffExpiration { get; set; }

  /// <summary>
  ///   커스터마이징 패키지 버프 만료일시(널이거나 과거면 버프없음)
  /// </summary>
  [Column("_customizationPackageBuffExpiration", TypeName = "datetime")]
  public DateTime? CustomizationPackageBuffExpiration { get; set; }

  /// <summary>
  ///   펄버프 남은 분=&gt; TOdbcRemainTime 와 연결됨
  /// </summary>
  [Column("_pearlPackageBuffRemainMinute")]
  public int PearlPackageBuffRemainMinute { get; set; }

  /// <summary>
  ///   길드 가입 가능한 날짜.최초 길드 가입할때부터 설정됨,클랜은 해당안됨
  /// </summary>
  [Column("_guildJoinableTime", TypeName = "datetime")]
  public DateTime? GuildJoinableTime { get; set; }

  /// <summary>
  ///   새 친구 여부
  /// </summary>
  [Column("_newFriend")]
  public byte NewFriend { get; set; }

  /// <summary>
  ///   친구 요청 여부
  /// </summary>
  [Column("_newRequestFriend")]
  public byte NewRequestFriend { get; set; }

  /// <summary>
  ///   마지막으로 말 교환을 진행한 시간
  /// </summary>
  [Column("_lastServantMixTime", TypeName = "datetime")]
  public DateTime? LastServantMixTime { get; set; }

  /// <summary>
  ///   마지막으로 말 구매한 시간
  /// </summary>
  [Column("_lastServantBuyTime", TypeName = "datetime")]
  public DateTime? LastServantBuyTime { get; set; }

  /// <summary>
  ///   과거 길드 활동 점수
  /// </summary>
  [Column("_preGuildActivity")]
  public int PreGuildActivity { get; set; }

  [Column("_userIntroduction")]
  [StringLength(200)]
  public string? UserIntroduction { get; set; }

  /// <summary>
  ///   요리/연금 판매 가능 갯수
  /// </summary>
  [Column("_tradeSupplyCount")]
  public long TradeSupplyCount { get; set; }

  /// <summary>
  ///   캐시 아이템 거래소 판매 개수
  /// </summary>
  [Column("_cashItemSaleCount")]
  public short CashItemSaleCount { get; set; }

  /// <summary>
  ///   캐시 아이템 거래소 판매 개수 초기화 시간
  /// </summary>
  [Column("_cashItemSaleCountResetTime", TypeName = "datetime")]
  public DateTime? CashItemSaleCountResetTime { get; set; }

  /// <summary>
  ///   랜덤 상점 예약 아이템 남은 분
  /// </summary>
  [Column("_remainKeepTime", TypeName = "datetime")]
  public DateTime RemainKeepTime { get; set; }

  /// <summary>
  ///   랜덤 상점 예약 아이템
  /// </summary>
  [Column("_keepItemKey")]
  public int KeepItemKey { get; set; }

  /// <summary>
  ///   랜덤 상점 예약 아이템 가격배율
  /// </summary>
  [Column("_keepItemPriceRate")]
  public int KeepItemPriceRate { get; set; }

  /// <summary>
  ///   하룻동안 무역으로번 수익
  /// </summary>
  [Column("_accumulatedAdvantageofTrade")]
  public long AccumulatedAdvantageofTrade { get; set; }

  [Column("_adventureNo")]
  public int AdventureNo { get; set; }

  [Column("_adventureExpiration", TypeName = "datetime")]
  public DateTime AdventureExpiration { get; set; }

  [Column("_adventureTotalScore")]
  public int AdventureTotalScore { get; set; }

  [Column("_adventureEnd")]
  public short AdventureEnd { get; set; }

  /// <summary>
  ///   소속 영지(NULL 이면 소속 없음)
  /// </summary>
  [Column("_ddTerritoryKey")]
  public int? DdTerritoryKey { get; set; }

  /// <summary>
  ///   요정 부활(0이면 사용한적 없음)
  /// </summary>
  [Column("_lastFairyRespawnTime", TypeName = "datetime")]
  public DateTime LastFairyRespawnTime { get; set; }

  /// <summary>
  ///   약탈게임 투표가능 횟수
  /// </summary>
  [Column("_plunderGameVoteCount")]
  public short PlunderGameVoteCount { get; set; }

  [Column("_platformType")]
  public byte? PlatformType { get; set; }

  /// <summary>
  ///   토벌게임 재화
  /// </summary>
  [Column("_expeditionSupplyPoint")]
  public long ExpeditionSupplyPoint { get; set; }

  [Column("_isUpdatePremiumBuffBySystem")]
  public bool IsUpdatePremiumBuffBySystem { get; set; }

  [Column("_familyInventorySlotCount")]
  public byte FamilyInventorySlotCount { get; set; }

  /// <summary>
  ///   사생활 모드 로그인
  /// </summary>
  [Column("_isGhostMode")]
  [StringLength(1)]
  [Unicode(false)]
  public string IsGhostMode { get; set; } = null!;

  [Column("_seasonPass")]
  public byte SeasonPass { get; set; }

  [Column("_oceanTendency")]
  public int OceanTendency { get; set; }

  [Column("_dwellingCount")]
  public byte DwellingCount { get; set; }

  [Column("_maxWp")]
  public int MaxWp { get; set; }

  [Column("_familyInventoryWeight")]
  public int FamilyInventoryWeight { get; set; }
}