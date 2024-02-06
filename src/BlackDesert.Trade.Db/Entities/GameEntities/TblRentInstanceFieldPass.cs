using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "ServerNo", "UniqueIndex", "UserNo")]
[Table("TblRentInstanceFieldPass", Schema = "PaGamePrivate")]
public class TblRentInstanceFieldPass
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

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;
}