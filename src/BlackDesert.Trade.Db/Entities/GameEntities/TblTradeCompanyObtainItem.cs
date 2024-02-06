using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("OwnerUserNo", "ObtainItemNo")]
[Table("TblTradeCompanyObtainItem", Schema = "PaGamePrivate")]
public class TblTradeCompanyObtainItem
{
  [Key]
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  [Key]
  [Column("_obtainItemNo")]
  public int ObtainItemNo { get; set; }

  [Column("_itemEnchantKey")]
  public int ItemEnchantKey { get; set; }

  [Column("_count")]
  public long Count { get; set; }
}