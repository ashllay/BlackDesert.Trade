using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저 프로파일
/// </summary>
[PrimaryKey("DateInitTerm", "UserNo")]
[Table("TblUserProfileInfo", Schema = "PaGamePrivate")]
public class TblUserProfileInfo
{
  /// <summary>
  ///   초기화 될 시간
  /// </summary>
  [Column("_nextInitDate", TypeName = "datetime")]
  public DateTime NextInitDate { get; set; }

  /// <summary>
  ///   업데이트 시간
  /// </summary>
  [Column("_updateDate", TypeName = "datetime")]
  public DateTime UpdateDate { get; set; }

  /// <summary>
  ///   프로파일 날짜 초기화 간격
  /// </summary>
  [Key]
  [Column("_dateInitTerm")]
  public int DateInitTerm { get; set; }

  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   몬스터 킬 수
  /// </summary>
  [Column("_value1")]
  public long Value1 { get; set; }

  /// <summary>
  ///   낚시 성공 횟수
  /// </summary>
  [Column("_value2")]
  public long Value2 { get; set; }

  /// <summary>
  ///   아이템 획득 횟수
  /// </summary>
  [Column("_value3")]
  public long Value3 { get; set; }

  /// <summary>
  ///   제작 성공 횟수
  /// </summary>
  [Column("_value4")]
  public long Value4 { get; set; }

  /// <summary>
  ///   몬스터 킬 수로 아이템 획득
  /// </summary>
  [Column("_isRewardGain1")]
  public bool IsRewardGain1 { get; set; }

  /// <summary>
  ///   낚시 성공으로 아이템 획득
  /// </summary>
  [Column("_isRewardGain2")]
  public bool IsRewardGain2 { get; set; }

  /// <summary>
  ///   아이템 획득으로 아이템 획득
  /// </summary>
  [Column("_isRewardGain3")]
  public bool IsRewardGain3 { get; set; }

  /// <summary>
  ///   제작 성공으로 아이템 획득
  /// </summary>
  [Column("_isRewardGain4")]
  public bool IsRewardGain4 { get; set; }
}