using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "SelectedItemKey")]
[Table("TblSeasonReward", Schema = "PaGamePrivate")]
public class TblSeasonReward
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_selectedItemKey")]
  public int SelectedItemKey { get; set; }

  [Column("_selectedItemEnchantLevel")]
  public byte SelectedItemEnchantLevel { get; set; }
}