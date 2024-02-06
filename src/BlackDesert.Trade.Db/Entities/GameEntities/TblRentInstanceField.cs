using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "ServerNo", "UniqueIndex")]
[Table("TblRentInstanceField", Schema = "PaGamePrivate")]
public class TblRentInstanceField
{
  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Key]
  [Column("_uniqueIndex")]
  public int UniqueIndex { get; set; }

  [Column("_hostUserNo")]
  public long HostUserNo { get; set; }

  [Column("_hostUserNickName")]
  [StringLength(30)]
  public string HostUserNickName { get; set; } = null!;

  [Column("_instanceFieldMapKey")]
  public int InstanceFieldMapKey { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime ExpirationDate { get; set; }

  [Column("_reCount")]
  public int ReCount { get; set; }
}