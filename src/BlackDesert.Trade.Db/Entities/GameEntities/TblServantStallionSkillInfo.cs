using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("Tier", "SkillNo")]
[Table("TblServantStallionSkillInfo", Schema = "PaGamePrivate")]
public class TblServantStallionSkillInfo
{
  [Key]
  [Column("_tier")]
  public int Tier { get; set; }

  [Key]
  [Column("_skillNo")]
  public int SkillNo { get; set; }
}