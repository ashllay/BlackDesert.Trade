using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "TotalRewardKey")]
[Table("TblGrowthPassTotalReward", Schema = "PaGamePrivate")]
public class TblGrowthPassTotalReward
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_totalRewardKey")]
  public int TotalRewardKey { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}