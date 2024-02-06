using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드공성전적
/// </summary>
[PrimaryKey("SiegeScoreNo", "GuildNo", "UserNo", "RegionKey")]
[Table("TblSiegeScore", Schema = "PaGamePrivate")]
public class TblSiegeScore
{
  /// <summary>
  ///   공성 회차
  /// </summary>
  [Key]
  [Column("_siegeScoreNo")]
  public int SiegeScoreNo { get; set; }

  /// <summary>
  ///   공성 시작 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   공성 전적 업데이트 시간
  /// </summary>
  [Column("_updateDate", TypeName = "datetime")]
  public DateTime? UpdateDate { get; set; }

  /// <summary>
  ///   참여 길드 번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   참여 길드 이름
  /// </summary>
  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  /// <summary>
  ///   참여 유저 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   가문명
  /// </summary>
  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  /// <summary>
  ///   캐릭터명
  /// </summary>
  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  /// <summary>
  ///   해당 공성의 영지키
  /// </summary>
  [Column("_territoryKey")]
  public int TerritoryKey { get; set; }

  /// <summary>
  ///   해당 공성의 지역키
  /// </summary>
  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  /// <summary>
  ///   해당 공성의 종류
  /// </summary>
  [Column("_isVillageSiege")]
  public bool IsVillageSiege { get; set; }

  /// <summary>
  ///   사망 횟수
  /// </summary>
  [Column("_scoreType_0")]
  public int ScoreType0 { get; set; }

  /// <summary>
  ///   지휘소 파괴 횟수
  /// </summary>
  [Column("_scoreType_1")]
  public int ScoreType1 { get; set; }

  /// <summary>
  ///   성채 파괴 횟수
  /// </summary>
  [Column("_scoreType_2")]
  public int ScoreType2 { get; set; }

  /// <summary>
  ///   군주 (연합 길드장) 죽인 횟수
  /// </summary>
  [Column("_scoreType_3")]
  public int ScoreType3 { get; set; }

  /// <summary>
  ///   대장 처치 횟수
  /// </summary>
  [Column("_scoreType_4")]
  public int ScoreType4 { get; set; }

  /// <summary>
  ///   성문 파괴 횟수
  /// </summary>
  [Column("_scoreType_5")]
  public int ScoreType5 { get; set; }

  /// <summary>
  ///   부대장 처치 횟수
  /// </summary>
  [Column("_scoreType_6")]
  public int ScoreType6 { get; set; }

  /// <summary>
  ///   길드처치 횟수
  /// </summary>
  [Column("_scoreType_7")]
  public int ScoreType7 { get; set; }

  /// <summary>
  ///   도움 횟수
  /// </summary>
  [Column("_scoreType_8")]
  public int ScoreType8 { get; set; }

  /// <summary>
  ///   탑승물 처치 횟수
  /// </summary>
  [Column("_scoreType_9")]
  public int ScoreType9 { get; set; }

  /// <summary>
  ///   배치물 파괴 횟수
  /// </summary>
  [Column("_scoreType_10")]
  public int ScoreType10 { get; set; }

  /// <summary>
  ///   공성병기로 사람을 죽인 횟수
  /// </summary>
  [Column("_scoreType_11")]
  public int ScoreType11 { get; set; }
}