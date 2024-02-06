using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblFamilySkillPoint", Schema = "PaGamePrivate")]
public class TblFamilySkillPoint
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_experience")]
  public long Experience { get; set; }

  [Column("_totalskillPoint")]
  public int TotalskillPoint { get; set; }

  [Column("_remainedSkillPoint")]
  public int RemainedSkillPoint { get; set; }
}