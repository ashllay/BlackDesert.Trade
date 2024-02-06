using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저캐릭기본정보
/// </summary>
[Table("TblCharacterInformation", Schema = "PaGamePrivate")]
public class TblCharacterInformation
{
  /// <summary>
  ///   캐릭터 생성일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   참인 경우에만 선택할 수 있는 캐릭임
  /// </summary>
  [Required]
  [Column("_isValid")]
  public bool? IsValid { get; set; }

  /// <summary>
  ///   캐릭을 소유한 사용자번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   생성된 슬롯번호
  /// </summary>
  [Column("_slotNo")]
  public byte SlotNo { get; set; }

  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   캐릭터명
  /// </summary>
  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  /// <summary>
  ///   삭제될 날짜(NULL이면 삭제시도없는것)
  /// </summary>
  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  /// <summary>
  ///   클래스타입 0 워리어 4 엘프레인저 8 위저드 12 자이언트
  /// </summary>
  [Column("_classType")]
  public byte ClassType { get; set; }

  /// <summary>
  ///   최근로그인시간
  /// </summary>
  [Column("_lastLoginTime", TypeName = "datetime")]
  public DateTime LastLoginTime { get; set; }

  /// <summary>
  ///   최근로그아웃시간
  /// </summary>
  [Column("_lastLogoutTime", TypeName = "datetime")]
  public DateTime LastLogoutTime { get; set; }

  /// <summary>
  ///   총 play시간(단위:분)
  /// </summary>
  [Column("_totalPlayTime")]
  public long TotalPlayTime { get; set; }

  /// <summary>
  ///   캐릭터 정보 갱신번호
  /// </summary>
  [Column("_pcBasicCacheSeqNo")]
  public int PcBasicCacheSeqNo { get; set; }

  [Column("_pcNonSavedCacheSeqNo")]
  public int PcNonSavedCacheSeqNo { get; set; }

  /// <summary>
  ///   TFieldNo
  /// </summary>
  [Column("_currentFieldNo")]
  public short CurrentFieldNo { get; set; }

  /// <summary>
  ///   TFieldIndex
  /// </summary>
  [Column("_currentFieldIndex")]
  public short CurrentFieldIndex { get; set; }

  /// <summary>
  ///   _currentPositionX
  /// </summary>
  [Column("_currentPositionX")]
  public long CurrentPositionX { get; set; }

  /// <summary>
  ///   _currentPositionY
  /// </summary>
  [Column("_currentPositionY")]
  public long CurrentPositionY { get; set; }

  /// <summary>
  ///   _currentPositionZ
  /// </summary>
  [Column("_currentPositionZ")]
  public long CurrentPositionZ { get; set; }

  /// <summary>
  ///   TFieldNo
  /// </summary>
  [Column("_returnFieldNo")]
  public short ReturnFieldNo { get; set; }

  /// <summary>
  ///   TFieldIndex
  /// </summary>
  [Column("_returnFieldIndex")]
  public short ReturnFieldIndex { get; set; }

  /// <summary>
  ///   _returnPositionX
  /// </summary>
  [Column("_returnPositionX")]
  public long ReturnPositionX { get; set; }

  /// <summary>
  ///   _returnPositionY
  /// </summary>
  [Column("_returnPositionY")]
  public long ReturnPositionY { get; set; }

  /// <summary>
  ///   _returnPositionZ
  /// </summary>
  [Column("_returnPositionZ")]
  public long ReturnPositionZ { get; set; }

  /// <summary>
  ///   레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   레벨경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }

  /// <summary>
  ///   스킬포인트레벨
  /// </summary>
  [Column("_skillPointLevel")]
  public int SkillPointLevel { get; set; }

  /// <summary>
  ///   스킬포인트경험치
  /// </summary>
  [Column("_skillPointExperience")]
  public int SkillPointExperience { get; set; }

  /// <summary>
  ///   남은 스킬포인트
  /// </summary>
  [Column("_remainedSkillPoint")]
  public int RemainedSkillPoint { get; set; }

  /// <summary>
  ///   총 획득한 스킬포인트
  /// </summary>
  [Column("_aquiredSkillPoint")]
  public int AquiredSkillPoint { get; set; }

  /// <summary>
  ///   스킬포인트경험치
  /// </summary>
  [Column("_productSkillPointExperience")]
  public int ProductSkillPointExperience { get; set; }

  /// <summary>
  ///   남은 스킬포인트
  /// </summary>
  [Column("_remainedProductSkillPoint")]
  public int RemainedProductSkillPoint { get; set; }

  /// <summary>
  ///   총 획득한 스킬포인트
  /// </summary>
  [Column("_aquiredProductSkillPoint")]
  public int AquiredProductSkillPoint { get; set; }

  /// <summary>
  ///   성향
  /// </summary>
  [Column("_tendency")]
  public int Tendency { get; set; }

  /// <summary>
  ///   현재hp
  /// </summary>
  [Column("_hp")]
  public int Hp { get; set; }

  /// <summary>
  ///   현재mp
  /// </summary>
  [Column("_mp")]
  public int Mp { get; set; }

  /// <summary>
  ///   현재sp
  /// </summary>
  [Column("_sp")]
  public int Sp { get; set; }

  /// <summary>
  ///   현재wp
  /// </summary>
  [Column("_wp")]
  public int Wp { get; set; }

  /// <summary>
  ///   증감되는 hp통
  /// </summary>
  [Column("_variedMaxHp")]
  public int VariedMaxHp { get; set; }

  /// <summary>
  ///   증감되는 mp통
  /// </summary>
  [Column("_variedMaxMp")]
  public int VariedMaxMp { get; set; }

  /// <summary>
  ///   증감되는 근거리Hit
  /// </summary>
  [Column("_variedDirectHit")]
  public int VariedDirectHit { get; set; }

  /// <summary>
  ///   증감되는 근거리Dv
  /// </summary>
  [Column("_variedDirectDv")]
  public int VariedDirectDv { get; set; }

  /// <summary>
  ///   증감되는 근거리Pv
  /// </summary>
  [Column("_variedDirectPv")]
  public int VariedDirectPv { get; set; }

  /// <summary>
  ///   증감되는 원거리Hit
  /// </summary>
  [Column("_variedRangeHit")]
  public int VariedRangeHit { get; set; }

  /// <summary>
  ///   증감되는 원거리Dv
  /// </summary>
  [Column("_variedRangeDv")]
  public int VariedRangeDv { get; set; }

  /// <summary>
  ///   증감되는 원거리Pv
  /// </summary>
  [Column("_variedRangePv")]
  public int VariedRangePv { get; set; }

  /// <summary>
  ///   증감되는 MagicalHit
  /// </summary>
  [Column("_variedMagicalHit")]
  public int VariedMagicalHit { get; set; }

  /// <summary>
  ///   증감되는 MagicalHit
  /// </summary>
  [Column("_variedMagicalDv")]
  public int VariedMagicalDv { get; set; }

  /// <summary>
  ///   증감되는 MagicalHit
  /// </summary>
  [Column("_variedMagicalPv")]
  public int VariedMagicalPv { get; set; }

  /// <summary>
  ///   퀘스트 보상 통합 포인트
  /// </summary>
  [Column("_rewardPoint")]
  public int RewardPoint { get; set; }

  /// <summary>
  ///   퀘스트 보상레벨에 따라 보상을 받아간 마지막 로그
  /// </summary>
  [Column("_questLevelLog")]
  public int QuestLevelLog { get; set; }

  /// <summary>
  ///   내게 도착한 새로운 멜 개수
  /// </summary>
  [Column("_newMail")]
  public byte NewMail { get; set; }

  /// <summary>
  ///   내가 친구를 요청한 것중 상대가 수락한게 개수
  /// </summary>
  [Column("_newFriend")]
  public byte NewFriend { get; set; }

  /// <summary>
  ///   나에게 친구를 요청한 개수
  /// </summary>
  [Column("_newRequestFriend")]
  public byte NewRequestFriend { get; set; }

  /// <summary>
  ///   계정내의 캐릭터 생성순서
  /// </summary>
  [Column("_creationIndex")]
  public int CreationIndex { get; set; }

  /// <summary>
  ///   추가 인벤 슬롯 숫자
  /// </summary>
  [Column("_inventorySlotCount")]
  public byte InventorySlotCount { get; set; }

  /// <summary>
  ///   배우려는 예약 스킬의 키값
  /// </summary>
  [Column("_reservedLearningSkillKey")]
  public int ReservedLearningSkillKey { get; set; }

  /// <summary>
  ///   내가 탑승(인터렉션을 통한) 중인 탈것의 타입
  /// </summary>
  [Column("_isRideTypeServant")]
  public bool IsRideTypeServant { get; set; }

  /// <summary>
  ///   내가 탑승(인터렉션을 통한) 중인 탈것의 고유 번호
  /// </summary>
  [Column("_rideVariousNo")]
  public long RideVariousNo { get; set; }

  /// <summary>
  ///   내가 탑승(인터렉션을 통한) 중인 탈것의 시트 번호
  /// </summary>
  [Column("_rideSeatIndex")]
  public byte RideSeatIndex { get; set; }

  /// <summary>
  ///   내가 올라가 있는 탈것의 타입
  /// </summary>
  [Column("_isOnTypeServant")]
  public bool IsOnTypeServant { get; set; }

  /// <summary>
  ///   내가 올라가 있는 탈것의 고유 번호
  /// </summary>
  [Column("_onVariousNo")]
  public long OnVariousNo { get; set; }

  /// <summary>
  ///   영구적으로 늘어난 무게
  /// </summary>
  [Column("_variedWeight")]
  public int VariedWeight { get; set; }

  /// <summary>
  ///   적용한 칭호키(0은 칭호 없음)
  /// </summary>
  [Column("_titleKey")]
  public int TitleKey { get; set; }

  /// <summary>
  ///   킬 보상(블랙스톤)
  /// </summary>
  [Column("_killRewardCount")]
  public int KillRewardCount { get; set; }

  /// <summary>
  ///   인챈트실패횟수
  /// </summary>
  [Column("_enchantFailCount")]
  public int EnchantFailCount { get; set; }

  /// <summary>
  ///   PC방 인챈트 카운트
  /// </summary>
  [Column("_enchantPcRoomCount")]
  public int EnchantPcRoomCount { get; set; }

  /// <summary>
  ///   강화실패시 장비 파괴 보호
  /// </summary>
  [Column("_enchantProtectBrokenCount")]
  public int EnchantProtectBrokenCount { get; set; }

  /// <summary>
  ///   이동될 지역 번호
  /// </summary>
  [Column("_arrivalRegionKey")]
  public int ArrivalRegionKey { get; set; }

  /// <summary>
  ///   도착 시간
  /// </summary>
  [Column("_arrivalTime", TypeName = "datetime")]
  public DateTime? ArrivalTime { get; set; }

  [Column("_enchantValuePackCount")]
  public int EnchantValuePackCount { get; set; }

  [Column("_rankPointPvp")]
  public int RankPointPvp { get; set; }

  [Column("_accumulatedKillCountByLocalWar")]
  public int AccumulatedKillCountByLocalWar { get; set; }

  [Column("_restoreExperience")]
  public long RestoreExperience { get; set; }

  [Column("_murdererStateEndTime")]
  public long MurdererStateEndTime { get; set; }

  [Column("_lastBiddingItemKey")]
  public int? LastBiddingItemKey { get; set; }

  [Column("_biddingFailCount")]
  public int BiddingFailCount { get; set; }

  /// <summary>
  ///   일반 스킬 각성한 횟수
  /// </summary>
  [Column("_skillAwakeningCount")]
  public int SkillAwakeningCount { get; set; }

  /// <summary>
  ///   각성무기 스킬 각성한 횟수
  /// </summary>
  [Column("_weaponSkillAwakeningCount")]
  public int WeaponSkillAwakeningCount { get; set; }

  /// <summary>
  ///   특별 케릭터인가
  /// </summary>
  [Column("_isSpecialCharacter")]
  public bool IsSpecialCharacter { get; set; }

  /// <summary>
  ///   캐릭터 공격력
  /// </summary>
  [Column("_offenceValue")]
  public int OffenceValue { get; set; }

  /// <summary>
  ///   캐릭터 방어력
  /// </summary>
  [Column("_defenceValue")]
  public int DefenceValue { get; set; }

  /// <summary>
  ///   캐릭터 각성공격력
  /// </summary>
  [Column("_awakenValue")]
  public int AwakenValue { get; set; }

  /// <summary>
  ///   듀얼캐릭터
  /// </summary>
  [Column("_duelCharacterNo")]
  public long DuelCharacterNo { get; set; }

  [Column("_duelRegionKey")]
  public int DuelRegionKey { get; set; }

  /// <summary>
  ///   강화 스택 경험치
  /// </summary>
  [Column("_enchantFailCountExp")]
  public long EnchantFailCountExp { get; set; }

  /// <summary>
  ///   전승 스킬 각성한 횟수
  /// </summary>
  [Column("_successionSkillAwakeningCount")]
  public int SuccessionSkillAwakeningCount { get; set; }

  [Column("_injuryHp")]
  public int InjuryHp { get; set; }

  [Column("_seasonType")]
  public byte SeasonType { get; set; }

  [Column("_isEventCharacter")]
  public bool IsEventCharacter { get; set; }

  [Column("_lastEnterServerNo")]
  public short LastEnterServerNo { get; set; }
}