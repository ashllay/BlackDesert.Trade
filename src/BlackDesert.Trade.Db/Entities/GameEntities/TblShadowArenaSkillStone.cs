using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaSkillStone", Schema = "PaGamePrivate")]
public class TblShadowArenaSkillStone
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_skillStonesCount")]
  public int SkillStonesCount { get; set; }
}