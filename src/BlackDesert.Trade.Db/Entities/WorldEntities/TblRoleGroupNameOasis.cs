using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblRoleGroupNameOasis", Schema = "PaOperationPrivate")]
public class TblRoleGroupNameOasis
{
  [Key]
  [Column("_roleGroupNo")]
  public byte RoleGroupNo { get; set; }

  [Column("_roleGroupName")]
  [StringLength(30)]
  public string RoleGroupName { get; set; } = null!;

  [Column("_roleGroupMemo")]
  [StringLength(50)]
  public string RoleGroupMemo { get; set; } = null!;

  [Column("_roleGroupGrade")]
  public byte RoleGroupGrade { get; set; }
}