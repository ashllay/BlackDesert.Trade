using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("IsUserNo", "UserCharacterNo", "ItemSubGroupKey", "ItemEnchantKey")]
[Table("TblNpcShopItemBuyCount", Schema = "PaGamePrivate")]
public class TblNpcShopItemBuyCount
{
  [Key]
  [Column("_isUserNo")]
  public bool IsUserNo { get; set; }

  [Key]
  [Column("_userCharacterNo")]
  public long UserCharacterNo { get; set; }

  [Key]
  [Column("_itemSubGroupKey")]
  public int ItemSubGroupKey { get; set; }

  [Key]
  [Column("_itemEnchantKey")]
  public int ItemEnchantKey { get; set; }

  [Column("_count")]
  public int Count { get; set; }

  [Column("_resetTime", TypeName = "datetime")]
  public DateTime ResetTime { get; set; }
}