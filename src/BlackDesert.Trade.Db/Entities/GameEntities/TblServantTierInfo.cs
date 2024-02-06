using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   tier 정보
/// </summary>
[Table("TblServantTierInfo", Schema = "PaGamePrivate")]
public class TblServantTierInfo
{
  /// <summary>
  ///   탑승물 characterKey
  /// </summary>
  [Key]
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   탑승물 tier
  /// </summary>
  [Column("_tier")]
  public int Tier { get; set; }

  /// <summary>
  ///   탑승물 성별 (0: 수컷, 1: 암컷)
  /// </summary>
  [Column("_sexType")]
  public bool SexType { get; set; }
}