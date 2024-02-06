using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblStockMarketBuy", Schema = "PaGamePrivate")]
public class TblStockMarketBuy
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
  ///   구매자
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   아이템 종류
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   구매가격
  /// </summary>
  [Column("_price")]
  public int Price { get; set; }

  /// <summary>
  ///   구매수량
  /// </summary>
  [Column("_count")]
  public int Count { get; set; }
}