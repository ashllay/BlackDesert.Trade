using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 용병 리스트
/// </summary>
[Keyless]
[Table("TblRecordGuildVolunteerScore", Schema = "PaGamePrivate")]
public class TblRecordGuildVolunteerScore
{
  /// <summary>
  ///   용병 길드 넘버
  /// </summary>
  [Column("_volunteerGuilNo")]
  public long VolunteerGuilNo { get; set; }

  /// <summary>
  ///   용병 길드 이름
  /// </summary>
  [Column("_volunteerguildName")]
  [StringLength(30)]
  public string VolunteerguildName { get; set; } = null!;

  /// <summary>
  ///   원래 길드 넘버
  /// </summary>
  [Column("_originalGuilNo")]
  public long? OriginalGuilNo { get; set; }

  /// <summary>
  ///   원래 길드 이름
  /// </summary>
  [Column("_originalGuildName")]
  [StringLength(30)]
  public string? OriginalGuildName { get; set; }

  /// <summary>
  ///   유저 넘버
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   유저 가문명
  /// </summary>
  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  /// <summary>
  ///   캐릭터 넘버
  /// </summary>
  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  /// <summary>
  ///   캐릭터 넘버
  /// </summary>
  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   거점/점령전 요일
  /// </summary>
  [Column("_siegeScoreNo")]
  public int? SiegeScoreNo { get; set; }

  /// <summary>
  ///   거점 리전 키
  /// </summary>
  [Column("_regionKey")]
  public int? RegionKey { get; set; }

  /// <summary>
  ///   거점전 인지
  /// </summary>
  [Column("_isVillageSiege")]
  public bool? IsVillageSiege { get; set; }

  /// <summary>
  ///   용병 성공 했는지
  /// </summary>
  [Column("_missionComplete")]
  public bool MissionComplete { get; set; }

  /// <summary>
  ///   죽인 횟수
  /// </summary>
  [Column("_killCount")]
  public int KillCount { get; set; }

  /// <summary>
  ///   사망 횟수
  /// </summary>
  [Column("_deathCount")]
  public int DeathCount { get; set; }
}