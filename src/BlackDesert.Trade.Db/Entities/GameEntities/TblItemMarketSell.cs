using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아이템거래소 판매
/// </summary>
[Table("TblItemMarketSell", Schema = "PaGamePrivate")]
public class TblItemMarketSell
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_itemMarketNo")]
  public long ItemMarketNo { get; set; }

  [Column("_registerUserNo")]
  public long RegisterUserNo { get; set; }

  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_registerTerritory")]
  public long RegisterTerritory { get; set; }

  [Column("_onePrice")]
  public long OnePrice { get; set; }

  [Column("_totalCount")]
  public long TotalCount { get; set; }

  [Column("_leftCount")]
  public long LeftCount { get; set; }

  [Column("_displayedBeginDate", TypeName = "datetime")]
  public DateTime DisplayedBeginDate { get; set; }

  [Column("_displayedEndDate", TypeName = "datetime")]
  public DateTime DisplayedEndDate { get; set; }

  [Column("_tradedTotalPrice")]
  public long TradedTotalPrice { get; set; }

  [Column("_bidderUserNo")]
  public long BidderUserNo { get; set; }

  [Column("_bidderDicePercent")]
  public int BidderDicePercent { get; set; }

  [Column("_tradePassword")]
  public int? TradePassword { get; set; }
}