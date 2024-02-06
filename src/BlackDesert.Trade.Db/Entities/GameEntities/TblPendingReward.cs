using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "ItemKey", "Type")]
[Table("TblPendingReward", Schema = "PaGamePrivate")]
public class TblPendingReward
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_itemCount")]
  public long? ItemCount { get; set; }

  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_rewardNo")]
  public long? RewardNo { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime UpdateDate { get; set; }
}