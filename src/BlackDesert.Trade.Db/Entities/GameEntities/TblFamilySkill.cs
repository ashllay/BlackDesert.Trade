using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "SkillNo")]
[Table("TblFamilySkills", Schema = "PaGamePrivate")]
public class TblFamilySkill
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_skillNo")]
  public int SkillNo { get; set; }
}