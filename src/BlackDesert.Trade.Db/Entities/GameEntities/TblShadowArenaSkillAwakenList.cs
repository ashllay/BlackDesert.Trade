using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "ClassType", "SkillNo")]
[Table("TblShadowArenaSkillAwakenList", Schema = "PaGamePrivate")]
public class TblShadowArenaSkillAwakenList
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_classType")]
  public byte ClassType { get; set; }

  [Key]
  [Column("_skillNo")]
  public int SkillNo { get; set; }

  [Column("_isSelect")]
  public bool IsSelect { get; set; }
}