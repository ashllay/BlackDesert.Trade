using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblMiscLog_INMEM", Schema = "PaGamePrivate")]
public class TblMiscLogInmem
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

  [Column("_reason")]
  public short? Reason { get; set; }

  [Column("_miscParam1")]
  public long? MiscParam1 { get; set; }

  [Column("_miscParam2")]
  public long? MiscParam2 { get; set; }

  [Column("_miscParam3")]
  public long? MiscParam3 { get; set; }

  [Column("_miscParam4")]
  public long? MiscParam4 { get; set; }

  [Column("_miscParam5")]
  public long? MiscParam5 { get; set; }

  [Column("_miscParam6")]
  public long? MiscParam6 { get; set; }

  [Column("_miscParam7")]
  public long? MiscParam7 { get; set; }

  [Column("_textParam1")]
  [StringLength(200)]
  public string? TextParam1 { get; set; }

  [Column("_textParam2")]
  [StringLength(200)]
  public string? TextParam2 { get; set; }
}