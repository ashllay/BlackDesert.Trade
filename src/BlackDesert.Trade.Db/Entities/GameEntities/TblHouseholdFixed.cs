using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   하우징 하우스홀드 고정집 테이블
/// </summary>
[Table("TblHouseholdFixed", Schema = "PaGamePrivate")]
public class TblHouseholdFixed
{
  /// <summary>
  ///   하우징홀드 번호
  /// </summary>
  [Key]
  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  /// <summary>
  ///   참이면 모든 사람에게 오픈됨
  /// </summary>
  [Column("_isOpenedForEverybody")]
  public bool IsOpenedForEverybody { get; set; }

  /// <summary>
  ///   참이면 가입길드원에게 오픈됨
  /// </summary>
  [Column("_isOpenedForGuild")]
  public bool IsOpenedForGuild { get; set; }

  /// <summary>
  ///   참이면 가입연합원에게 오픈됨
  /// </summary>
  [Column("_isOpenedForAlliance")]
  public bool IsOpenedForAlliance { get; set; }

  /// <summary>
  ///   설치물 점수 합산
  /// </summary>
  [Column("_interiorSensePoint")]
  public int InteriorSensePoint { get; set; }

  [Column("_interiorUpdateTime", TypeName = "datetime")]
  public DateTime? InteriorUpdateTime { get; set; }

  /// <summary>
  ///   길드하우스 일 경우 경매 낙찰 가격
  /// </summary>
  [Column("_successBidPrice")]
  public long SuccessBidPrice { get; set; }

  [Column("_characterKey")]
  public int CharacterKey { get; set; }
}