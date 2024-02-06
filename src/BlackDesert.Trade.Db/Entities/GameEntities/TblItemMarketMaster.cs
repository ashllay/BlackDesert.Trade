using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아이템거래소 master
/// </summary>
[Table("TblItemMarketMaster", Schema = "PaGamePrivate")]
public class TblItemMarketMaster
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }

  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_minPrice")]
  public long MinPrice { get; set; }

  [Column("_maxPrice")]
  public long MaxPrice { get; set; }

  [Column("_tradedTotalPrice")]
  public long TradedTotalPrice { get; set; }

  [Column("_tradedTotalAmount")]
  public long TradedTotalAmount { get; set; }

  [Column("_accumulatedPrice")]
  public long AccumulatedPrice { get; set; }

  [Column("_accumulatedAmount")]
  public long AccumulatedAmount { get; set; }
}