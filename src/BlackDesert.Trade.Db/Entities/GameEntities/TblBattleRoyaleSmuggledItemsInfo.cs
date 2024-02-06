using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "ItemNo")]
[Table("TblBattleRoyaleSmuggledItemsInfo", Schema = "PaGamePrivate")]
public class TblBattleRoyaleSmuggledItemsInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }
}