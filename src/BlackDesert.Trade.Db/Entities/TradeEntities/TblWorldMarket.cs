using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("MainKey", "SubKey", "KeyType")]
[Table("TblWorldMarket", Schema = "PaGamePrivate")]
public class TblWorldMarket
{
  [Key]
  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainCategory")]
  public int MainCategory { get; set; }

  [Column("_subCategory")]
  public int SubCategory { get; set; }

  [Key]
  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Key]
  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_totalTradeCount")]
  public long TotalTradeCount { get; set; }

  [Column("_isDisplay")]
  public bool IsDisplay { get; set; }

  [Column("_priceGroupKey")]
  public long PriceGroupKey { get; set; }

  [Column("_maxTradeCount")]
  public long MaxTradeCount { get; set; }

  [Column("_maxPrice")]
  public long MaxPrice { get; set; }

  [Column("_minPrice")]
  public long MinPrice { get; set; }

  [Column("_realMaxPrice")]
  public long RealMaxPrice { get; set; }

  [Column("_realMinPrice")]
  public long RealMinPrice { get; set; }

  [Column("_sumTradeCount")]
  public long SumTradeCount { get; set; }

  [Column("_sumTradePrice")]
  public long SumTradePrice { get; set; }

  [Column("_sumTradeCountByStock")]
  public long SumTradeCountByStock { get; set; }

  [Column("_accumulateTickCount")]
  public long AccumulateTickCount { get; set; }

  [Column("_accumulateBiddingCount")]
  public long AccumulateBiddingCount { get; set; }

  [Column("_fluctuationType")]
  public byte FluctuationType { get; set; }

  [Column("_fluctuationPrice")]
  public long FluctuationPrice { get; set; }

  [Column("_currentTrend")]
  public byte CurrentTrend { get; set; }

  [Column("_trendKeepCount")]
  public byte TrendKeepCount { get; set; }

  [Column("_lastTradeTime", TypeName = "datetime")]
  public DateTime LastTradeTime { get; set; }

  [Column("_lastTradePrice")]
  public long LastTradePrice { get; set; }
}