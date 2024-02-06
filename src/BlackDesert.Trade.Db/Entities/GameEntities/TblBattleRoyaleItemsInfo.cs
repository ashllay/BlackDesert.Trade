using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "ItemKey")]
[Table("TblBattleRoyaleItemsInfo", Schema = "PaGamePrivate")]
public class TblBattleRoyaleItemsInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_count")]
  public long Count { get; set; }
}