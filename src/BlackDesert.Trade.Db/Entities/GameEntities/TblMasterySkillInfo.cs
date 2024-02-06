using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMasterySkillInfo", Schema = "PaGamePrivate")]
public class TblMasterySkillInfo
{
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_skillNo")]
  public long SkillNo { get; set; }

  [Column("_isBattle")]
  public bool IsBattle { get; set; }
}