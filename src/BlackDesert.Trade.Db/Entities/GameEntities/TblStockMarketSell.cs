using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblStockMarketSell", Schema = "PaGamePrivate")]
public class TblStockMarketSell
{
  /// <summary>
  ///   거래순번
  /// </summary>
  [Key]
  [Column("_marketId")]
  public int MarketId { get; set; }

  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   지역번호
  /// </summary>
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  /// <summary>
  ///   판매자
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   아이템 고유번호
  /// </summary>
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   아이템 종류
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   판매가격
  /// </summary>
  [Column("_price")]
  public int Price { get; set; }

  /// <summary>
  ///   판매수량
  /// </summary>
  [Column("_count")]
  public int Count { get; set; }
}