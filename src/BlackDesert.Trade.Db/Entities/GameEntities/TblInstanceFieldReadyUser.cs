using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblInstanceFieldReadyUser", Schema = "PaGamePrivate")]
public class TblInstanceFieldReadyUser
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_uniqueIndex")]
  public int UniqueIndex { get; set; }

  [Column("_validTime", TypeName = "datetime")]
  public DateTime ValidTime { get; set; }

  [Column("_isEnterTheObserver")]
  public bool IsEnterTheObserver { get; set; }
}