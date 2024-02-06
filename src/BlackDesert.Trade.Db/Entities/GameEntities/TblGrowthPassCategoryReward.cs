using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CategoryKey", "RewardIndex")]
[Table("TblGrowthPassCategoryReward", Schema = "PaGamePrivate")]
public class TblGrowthPassCategoryReward
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_categoryKey")]
  public int CategoryKey { get; set; }

  [Key]
  [Column("_rewardIndex")]
  public int RewardIndex { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}