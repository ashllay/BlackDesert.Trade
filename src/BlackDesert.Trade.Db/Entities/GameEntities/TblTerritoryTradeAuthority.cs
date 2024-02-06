using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   영지 무역(황실무역) 권한 테이블
/// </summary>
[PrimaryKey("UserNo", "TerritoryKey")]
[Table("TblTerritoryTradeAuthority", Schema = "PaGamePrivate")]
public class TblTerritoryTradeAuthority
{
  /// <summary>
  ///   유져 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   영지 번호
  /// </summary>
  [Key]
  [Column("_territoryKey")]
  public long TerritoryKey { get; set; }
}