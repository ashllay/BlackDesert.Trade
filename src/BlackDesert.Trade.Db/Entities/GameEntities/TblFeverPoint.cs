using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblFeverPoint", Schema = "PaGamePrivate")]
public class TblFeverPoint
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_feverPoint")]
  public int FeverPoint { get; set; }

  [Column("_maxFeverPoint")]
  public int MaxFeverPoint { get; set; }

  [Column("_addFeverPoint")]
  public int AddFeverPoint { get; set; }

  [Column("_lastAddPointTime", TypeName = "datetime")]
  public DateTime LastAddPointTime { get; set; }

  [Column("_useFeverSkillIndex")]
  public short UseFeverSkillIndex { get; set; }

  [Required]
  [Column("_isUseFeverSkill")]
  public bool? IsUseFeverSkill { get; set; }
}