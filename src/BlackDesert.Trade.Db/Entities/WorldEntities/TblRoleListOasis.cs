using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblRoleListOasis", Schema = "PaOperationPrivate")]
public class TblRoleListOasis
{
  [Key]
  [Column("_roleNo")]
  public byte RoleNo { get; set; }

  [Column("_roleName")]
  [StringLength(30)]
  public string RoleName { get; set; } = null!;
}