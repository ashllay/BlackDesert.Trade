using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblGuildSiegeLog_INMEM", Schema = "PaGamePrivate")]
public class TblGuildSiegeLogInmem
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_operationLogType")]
  public short OperationLogType { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string? UserIp { get; set; }

  [Column("_isUserGm")]
  public bool? IsUserGm { get; set; }

  [Column("_playMinuteOfUser")]
  public long? PlayMinuteOfUser { get; set; }

  [Column("_isPcRoom")]
  public bool IsPcRoom { get; set; }

  [Column("_isPcRoomPremium")]
  public bool IsPcRoomPremium { get; set; }

  [Column("_isPvP")]
  public bool? IsPvP { get; set; }

  [Column("_isGuestAccount")]
  public bool? IsGuestAccount { get; set; }

  [Column("_gameAgeGradeType")]
  public byte? GameAgeGradeType { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_characterLevel")]
  public int? CharacterLevel { get; set; }

  [Column("_characterExperience")]
  public long? CharacterExperience { get; set; }

  [Column("_characterTendency")]
  public int? CharacterTendency { get; set; }

  [Column("_remainedSkillPoint")]
  public int? RemainedSkillPoint { get; set; }

  [Column("_aquiredSkillPoint")]
  public int? AquiredSkillPoint { get; set; }

  [Column("_currentFieldNo")]
  public short? CurrentFieldNo { get; set; }

  [Column("_currentPositionX")]
  public long? CurrentPositionX { get; set; }

  [Column("_currentPositionY")]
  public long? CurrentPositionY { get; set; }

  [Column("_currentPositionZ")]
  public long? CurrentPositionZ { get; set; }

  [Column("_regionType")]
  public byte? RegionType { get; set; }

  [Column("_isDoingSiege")]
  public bool? IsDoingSiege { get; set; }

  [Column("_playMinuteOfCharacter")]
  public long? PlayMinuteOfCharacter { get; set; }

  [Column("_regionKey")]
  public int RegionKey { get; set; }

  [Column("_regionName")]
  [StringLength(30)]
  public string RegionName { get; set; } = null!;

  [Column("_guildNo")]
  public long? GuildNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string? GuildName { get; set; }

  [Column("_guildParam1")]
  public long? GuildParam1 { get; set; }

  [Column("_guildParam2")]
  public long? GuildParam2 { get; set; }

  [Column("_guildParam3")]
  public long? GuildParam3 { get; set; }

  [Column("_guildParam4")]
  public long? GuildParam4 { get; set; }

  [Column("_guildParam5")]
  public long? GuildParam5 { get; set; }

  [Column("_guildParam6")]
  public long? GuildParam6 { get; set; }

  [Column("_guildParam7")]
  public long? GuildParam7 { get; set; }

  [Column("_guildParam8")]
  public long? GuildParam8 { get; set; }

  [Column("_reason")]
  public short Reason { get; set; }
}