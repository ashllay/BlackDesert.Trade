using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "UserNo")]
[Table("TblPenaltyEscape", Schema = "PaGamePrivate")]
public class TblPenaltyEscape
{
  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_stackCount")]
  public int StackCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}