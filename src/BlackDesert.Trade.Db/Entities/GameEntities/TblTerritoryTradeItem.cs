using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   영지 무역, 납품 아이템 테이블
/// </summary>
[Table("TblTerritoryTradeItem", Schema = "PaGamePrivate")]
public class TblTerritoryTradeItem
{
  /// <summary>
  ///   영지 번호
  /// </summary>
  [Key]
  [Column("_territoryKey")]
  public long TerritoryKey { get; set; }

  /// <summary>
  ///   영지 아이템 등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   영지 무역 gc::ItemMainGroupKey
  /// </summary>
  [Column("_tradeItemMainGroupKey")]
  public int? TradeItemMainGroupKey { get; set; }

  /// <summary>
  ///   영지 납품 gc::ItemMainGroupKey
  /// </summary>
  [Column("_supplyItemMainGroupKey")]
  public int? SupplyItemMainGroupKey { get; set; }
}