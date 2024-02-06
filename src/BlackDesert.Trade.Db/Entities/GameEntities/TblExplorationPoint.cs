using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   탐험 포인트(지역별 공헌도)
/// </summary>
[PrimaryKey("UserNo", "TerritoryKey")]
[Table("TblExplorationPoint", Schema = "PaGamePrivate")]
public class TblExplorationPoint
{
  /// <summary>
  ///   유저 고유번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   지역번호
  /// </summary>
  [Key]
  [Column("_territoryKey")]
  public long TerritoryKey { get; set; }

  /// <summary>
  ///   남은 포인트
  /// </summary>
  [Column("_remainedPoint")]
  public int RemainedPoint { get; set; }

  /// <summary>
  ///   총 획득 포인트
  /// </summary>
  [Column("_aquiredPoint")]
  public int AquiredPoint { get; set; }

  /// <summary>
  ///   경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }
}