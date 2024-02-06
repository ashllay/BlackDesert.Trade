using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblItemMarketSellByParty", Schema = "PaGamePrivate")]
public class TblItemMarketSellByParty
{
  [Column("_registerTime", TypeName = "datetime")]
  public DateTime RegisterTime { get; set; }

  [Key]
  [Column("_itemMarketNo")]
  public long ItemMarketNo { get; set; }

  [Column("_registerUserNo0")]
  public long RegisterUserNo0 { get; set; }

  [Column("_registerUserNo1")]
  public long? RegisterUserNo1 { get; set; }

  [Column("_registerUserNo2")]
  public long? RegisterUserNo2 { get; set; }

  [Column("_registerUserNo3")]
  public long? RegisterUserNo3 { get; set; }

  [Column("_registerUserNo4")]
  public long? RegisterUserNo4 { get; set; }

  [Column("_itemEnchantKey")]
  public int ItemEnchantKey { get; set; }

  [Column("_price")]
  public long Price { get; set; }
}