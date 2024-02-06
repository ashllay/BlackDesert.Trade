using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Table("TblWorldMarketPersonalTrade", Schema = "PaGamePrivate")]
public class TblWorldMarketPersonalTrade
{
  [Key]
  [Column("_marketNo")]
  public long MarketNo { get; set; }

  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  [Column("_fromNationCode")]
  public int FromNationCode { get; set; }

  [Column("_fromServerNo")]
  public int FromServerNo { get; set; }

  [Column("_fromUserNo")]
  public long FromUserNo { get; set; }

  [Column("_toNationCode")]
  public int ToNationCode { get; set; }

  [Column("_toServerNo")]
  public int ToServerNo { get; set; }

  [Column("_toUserNo")]
  public long ToUserNo { get; set; }
}