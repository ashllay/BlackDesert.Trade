using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblItemMarketSellByReservation", Schema = "PaGamePrivate")]
public class TblItemMarketSellByReservation
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_itemMarketNo")]
  public long ItemMarketNo { get; set; }

  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_itemEnchantKey")]
  public int ItemEnchantKey { get; set; }

  [Column("_registerUserNo")]
  public long RegisterUserNo { get; set; }

  [Column("_onePrice")]
  public long OnePrice { get; set; }

  [Column("_totalCount")]
  public long TotalCount { get; set; }

  [Column("_registerTerritory")]
  public long RegisterTerritory { get; set; }
}