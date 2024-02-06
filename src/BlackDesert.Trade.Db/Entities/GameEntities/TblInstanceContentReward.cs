using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblInstanceContentReward", Schema = "PaGamePrivate")]
public class TblInstanceContentReward
{
  [Key]
  [Column("_rewardNo")]
  public long RewardNo { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime UpdateDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_itemKey")]
  public long? ItemKey { get; set; }

  [Column("_itemCount")]
  public long? ItemCount { get; set; }

  [Column("_type")]
  public byte? Type { get; set; }
}