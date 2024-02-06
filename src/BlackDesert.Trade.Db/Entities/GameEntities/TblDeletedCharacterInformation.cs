using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblDeletedCharacterInformation", Schema = "PaGamePrivate")]
public class TblDeletedCharacterInformation
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_isValid")]
  public bool? IsValid { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_slotNo")]
  public byte? SlotNo { get; set; }

  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_classType")]
  public byte? ClassType { get; set; }

  [Column("_lastLoginTime", TypeName = "datetime")]
  public DateTime? LastLoginTime { get; set; }

  [Column("_lastLogoutTime", TypeName = "datetime")]
  public DateTime? LastLogoutTime { get; set; }

  [Column("_totalPlayTime")]
  public long? TotalPlayTime { get; set; }

  [Column("_pcBasicCacheSeqNo")]
  public int? PcBasicCacheSeqNo { get; set; }

  [Column("_pcNonSavedCacheSeqNo")]
  public int? PcNonSavedCacheSeqNo { get; set; }

  [Column("_currentFieldNo")]
  public short? CurrentFieldNo { get; set; }

  [Column("_currentFieldIndex")]
  public short? CurrentFieldIndex { get; set; }

  [Column("_currentPositionX")]
  public long? CurrentPositionX { get; set; }

  [Column("_currentPositionY")]
  public long? CurrentPositionY { get; set; }

  [Column("_currentPositionZ")]
  public long? CurrentPositionZ { get; set; }

  [Column("_returnFieldNo")]
  public short? ReturnFieldNo { get; set; }

  [Column("_returnFieldIndex")]
  public short? ReturnFieldIndex { get; set; }

  [Column("_returnPositionX")]
  public long? ReturnPositionX { get; set; }

  [Column("_returnPositionY")]
  public long? ReturnPositionY { get; set; }

  [Column("_returnPositionZ")]
  public long? ReturnPositionZ { get; set; }

  [Column("_level")]
  public int? Level { get; set; }

  [Column("_experience")]
  public long? Experience { get; set; }

  [Column("_skillPointLevel")]
  public int? SkillPointLevel { get; set; }

  [Column("_skillPointExperience")]
  public int? SkillPointExperience { get; set; }

  [Column("_remainedSkillPoint")]
  public int? RemainedSkillPoint { get; set; }

  [Column("_aquiredSkillPoint")]
  public int? AquiredSkillPoint { get; set; }

  [Column("_productSkillPointExperience")]
  public int? ProductSkillPointExperience { get; set; }

  [Column("_remainedProductSkillPoint")]
  public int? RemainedProductSkillPoint { get; set; }

  [Column("_aquiredProductSkillPoint")]
  public int? AquiredProductSkillPoint { get; set; }

  [Column("_tendency")]
  public int? Tendency { get; set; }

  [Column("_hp")]
  public int? Hp { get; set; }

  [Column("_mp")]
  public int? Mp { get; set; }

  [Column("_sp")]
  public int? Sp { get; set; }

  [Column("_wp")]
  public int? Wp { get; set; }

  [Column("_variedMaxHp")]
  public int? VariedMaxHp { get; set; }

  [Column("_variedMaxMp")]
  public int? VariedMaxMp { get; set; }

  [Column("_variedDirectHit")]
  public int? VariedDirectHit { get; set; }

  [Column("_variedDirectDv")]
  public int? VariedDirectDv { get; set; }

  [Column("_variedDirectPv")]
  public int? VariedDirectPv { get; set; }

  [Column("_variedRangeHit")]
  public int? VariedRangeHit { get; set; }

  [Column("_variedRangeDv")]
  public int? VariedRangeDv { get; set; }

  [Column("_variedRangePv")]
  public int? VariedRangePv { get; set; }

  [Column("_variedMagicalHit")]
  public int? VariedMagicalHit { get; set; }

  [Column("_variedMagicalDv")]
  public int? VariedMagicalDv { get; set; }

  [Column("_variedMagicalPv")]
  public int? VariedMagicalPv { get; set; }

  [Column("_rewardPoint")]
  public int? RewardPoint { get; set; }

  [Column("_questLevelLog")]
  public int? QuestLevelLog { get; set; }

  [Column("_newMail")]
  public byte? NewMail { get; set; }

  [Column("_newFriend")]
  public byte? NewFriend { get; set; }

  [Column("_newRequestFriend")]
  public byte? NewRequestFriend { get; set; }

  [Column("_creationIndex")]
  public int? CreationIndex { get; set; }

  [Column("_inventorySlotCount")]
  public byte? InventorySlotCount { get; set; }

  [Column("_reservedLearningSkillKey")]
  public int? ReservedLearningSkillKey { get; set; }

  [Column("_isRideTypeServant")]
  public bool? IsRideTypeServant { get; set; }

  [Column("_rideVariousNo")]
  public long? RideVariousNo { get; set; }

  [Column("_rideSeatIndex")]
  public byte? RideSeatIndex { get; set; }

  [Column("_isOnTypeServant")]
  public bool? IsOnTypeServant { get; set; }

  [Column("_onVariousNo")]
  public long? OnVariousNo { get; set; }

  [Column("_variedWeight")]
  public int? VariedWeight { get; set; }

  [Column("_titleKey")]
  public int? TitleKey { get; set; }

  [Column("_killRewardCount")]
  public int? KillRewardCount { get; set; }

  [Column("_enchantFailCount")]
  public int? EnchantFailCount { get; set; }

  [Column("_enchantPcRoomCount")]
  public int? EnchantPcRoomCount { get; set; }

  [Column("_enchantProtectBrokenCount")]
  public int? EnchantProtectBrokenCount { get; set; }

  [Column("_arrivalRegionKey")]
  public int? ArrivalRegionKey { get; set; }

  [Column("_arrivalTime", TypeName = "datetime")]
  public DateTime? ArrivalTime { get; set; }

  [Column("_enchantValuePackCount")]
  public int? EnchantValuePackCount { get; set; }

  [Column("_rankPointPvp")]
  public int? RankPointPvp { get; set; }

  [Column("_accumulatedKillCountByLocalWar")]
  public int? AccumulatedKillCountByLocalWar { get; set; }

  [Column("_restoreExperience")]
  public long? RestoreExperience { get; set; }

  [Column("_murdererStateEndTime")]
  public long? MurdererStateEndTime { get; set; }

  [Column("_lastBiddingItemKey")]
  public int? LastBiddingItemKey { get; set; }

  [Column("_biddingFailCount")]
  public int? BiddingFailCount { get; set; }

  [Column("_skillAwakeningCount")]
  public int? SkillAwakeningCount { get; set; }

  [Column("_weaponSkillAwakeningCount")]
  public int? WeaponSkillAwakeningCount { get; set; }

  [Column("_isSpecialCharacter")]
  public bool? IsSpecialCharacter { get; set; }

  [Column("_seasonType")]
  public byte? SeasonType { get; set; }

  [Column("_successionSkillAwakeningCount")]
  public int? SuccessionSkillAwakeningCount { get; set; }
}