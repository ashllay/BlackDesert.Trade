using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Idx")]
[Table("TblCommonSkillNo", Schema = "PaGamePrivate")]
public class TblCommonSkillNo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_idx")]
  public byte Idx { get; set; }

  [Column("_skillNo")]
  public int SkillNo { get; set; }
}