using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ItemKey", "CloseType")]
[Table("TblSeasonCloseItemInfo", Schema = "PaGamePrivate")]
public class TblSeasonCloseItemInfo
{
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Key]
  [Column("_closeType")]
  public int CloseType { get; set; }
}