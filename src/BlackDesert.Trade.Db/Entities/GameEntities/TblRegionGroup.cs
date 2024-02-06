using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   영역별 정보
/// </summary>
[Table("TblRegionGroup", Schema = "PaGamePrivate")]
public class TblRegionGroup
{
  /// <summary>
  ///   마지막 수정일시
  /// </summary>
  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }

  /// <summary>
  ///   _regionGroupKey
  /// </summary>
  [Key]
  [Column("_regionGroupKey")]
  public int RegionGroupKey { get; set; }

  /// <summary>
  ///   농산물 생산력
  /// </summary>
  [Column("_corpProductivity")]
  public int CorpProductivity { get; set; }

  /// <summary>
  ///   낚시 생산력
  /// </summary>
  [Column("_fishingProductivity")]
  public int FishingProductivity { get; set; }

  /// <summary>
  ///   충성도
  /// </summary>
  [Column("_loyalty")]
  public int Loyalty { get; set; }
}