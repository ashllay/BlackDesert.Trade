using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   나의 일지 시스템
/// </summary>
[Keyless]
[Table("TblGuildJournal", Schema = "PaGamePrivate")]
public class TblGuildJournal
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   날짜키
  /// </summary>
  [Column("_dateKey")]
  public long DateKey { get; set; }

  /// <summary>
  ///   소유자타입(0 캐릭터,1길드)
  /// </summary>
  [Column("_ownerType")]
  public short OwnerType { get; set; }

  /// <summary>
  ///   길드 번호
  /// </summary>
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   길드 이름
  /// </summary>
  [Column("_guildName")]
  [StringLength(30)]
  public string? GuildName { get; set; }

  /// <summary>
  ///   owner의 GuildMemberGrade
  /// </summary>
  [Column("_ownerMemberGrade")]
  public byte? OwnerMemberGrade { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Column("_ownerCharacterNo")]
  public long? OwnerCharacterNo { get; set; }

  /// <summary>
  ///   캐릭터 이름
  /// </summary>
  [Column("_ownerName")]
  [StringLength(30)]
  public string? OwnerName { get; set; }

  /// <summary>
  ///   UserNo
  /// </summary>
  [Column("_ownerUserNo")]
  public long? OwnerUserNo { get; set; }

  /// <summary>
  ///   가문명
  /// </summary>
  [Column("_ownerNickname")]
  [StringLength(30)]
  public string? OwnerNickname { get; set; }

  /// <summary>
  ///   길마 유저번호
  /// </summary>
  [Column("_ownerMasterUserNo")]
  public long? OwnerMasterUserNo { get; set; }

  /// <summary>
  ///   길마 가문명
  /// </summary>
  [Column("_ownerMasterUserNickname")]
  [StringLength(30)]
  public string? OwnerMasterUserNickname { get; set; }

  /// <summary>
  ///   target의 길드 번호
  /// </summary>
  [Column("_targetGuildNo")]
  public long? TargetGuildNo { get; set; }

  /// <summary>
  ///   target의 길드 이름
  /// </summary>
  [Column("_targetGuildName")]
  [StringLength(30)]
  public string? TargetGuildName { get; set; }

  /// <summary>
  ///   target의 GuildMemberGrade
  /// </summary>
  [Column("_targetMemberGrade")]
  public byte? TargetMemberGrade { get; set; }

  /// <summary>
  ///   target의 캐릭터 번호
  /// </summary>
  [Column("_targetCharacterNo")]
  public long? TargetCharacterNo { get; set; }

  /// <summary>
  ///   target의 캐릭터 이름
  /// </summary>
  [Column("_targetCharacterName")]
  [StringLength(30)]
  public string? TargetCharacterName { get; set; }

  /// <summary>
  ///   targer의 UserNo
  /// </summary>
  [Column("_targetUserNo")]
  public long? TargetUserNo { get; set; }

  /// <summary>
  ///   targer의 가문명
  /// </summary>
  [Column("_targetUserNickname")]
  [StringLength(30)]
  public string? TargetUserNickname { get; set; }

  /// <summary>
  ///   길마 유저번호
  /// </summary>
  [Column("_targetMasterUserNo")]
  public long? TargetMasterUserNo { get; set; }

  /// <summary>
  ///   길마 가문명
  /// </summary>
  [Column("_targetMasterUserNickname")]
  [StringLength(30)]
  public string? TargetMasterUserNickname { get; set; }

  /// <summary>
  ///   일지타입(JournalType-0칭호획득, 1 강화성공...)
  /// </summary>
  [Column("_journalType")]
  public short JournalType { get; set; }

  /// <summary>
  ///   위치값
  /// </summary>
  [Column("_positionX")]
  public long? PositionX { get; set; }

  /// <summary>
  ///   위치값
  /// </summary>
  [Column("_positionY")]
  public long? PositionY { get; set; }

  /// <summary>
  ///   위치값
  /// </summary>
  [Column("_positionZ")]
  public long? PositionZ { get; set; }

  /// <summary>
  ///   인자1
  /// </summary>
  [Column("_parameterNo_1")]
  public long ParameterNo1 { get; set; }

  /// <summary>
  ///   인자2
  /// </summary>
  [Column("_parameterNo_2")]
  public int ParameterNo2 { get; set; }

  /// <summary>
  ///   문자열
  /// </summary>
  [Column("_parameterString")]
  [StringLength(50)]
  public string? ParameterString { get; set; }

  /// <summary>
  ///   서버 번호
  /// </summary>
  [Column("_serverNo")]
  public short? ServerNo { get; set; }
}