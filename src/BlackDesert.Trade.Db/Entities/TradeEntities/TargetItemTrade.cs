using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Table("TargetItemTrade", Schema = "PaOperationPrivate")]
public class TargetItemTrade
{
  [Key]
  [Column("_itemKey")]
  public long ItemKey { get; set; }
}