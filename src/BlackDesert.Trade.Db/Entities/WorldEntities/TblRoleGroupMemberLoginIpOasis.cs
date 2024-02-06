using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("WhereType", "WhereNo", "IpAddress")]
[Table("TblRoleGroupMemberLoginIpOasis", Schema = "PaOperationPrivate")]
public class TblRoleGroupMemberLoginIpOasis
{
  [Key]
  [Column("_whereType")]
  public byte WhereType { get; set; }

  [Key]
  [Column("_whereNo")]
  public long WhereNo { get; set; }

  [Key]
  [Column("_ipAddress")]
  [StringLength(15)]
  [Unicode(false)]
  public string IpAddress { get; set; } = null!;
}