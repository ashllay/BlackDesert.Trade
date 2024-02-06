using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("RoleGroupNo", "RoleNo")]
[Table("TblRoleGroupOasis", Schema = "PaOperationPrivate")]
public class TblRoleGroupOasis
{
  [Key]
  [Column("_roleGroupNo")]
  public byte RoleGroupNo { get; set; }

  [Key]
  [Column("_roleNo")]
  public byte RoleNo { get; set; }
}