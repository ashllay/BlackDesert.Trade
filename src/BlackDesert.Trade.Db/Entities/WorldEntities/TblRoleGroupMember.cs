using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblRoleGroupMember", Schema = "PaGamePrivate")]
public class TblRoleGroupMember
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_roleGroupNo")]
  public byte RoleGroupNo { get; set; }

  [Column("_macAddress")]
  [StringLength(32)]
  [Unicode(false)]
  public string MacAddress { get; set; } = null!;

  [Column("_ipAddress")]
  [StringLength(15)]
  [Unicode(false)]
  public string IpAddress { get; set; } = null!;

  [Column("_prevPassword1")]
  [StringLength(64)]
  [Unicode(false)]
  public string? PrevPassword1 { get; set; }

  [Column("_prevPassword2")]
  [StringLength(64)]
  [Unicode(false)]
  public string? PrevPassword2 { get; set; }

  [Column("_prevPassword3")]
  [StringLength(64)]
  [Unicode(false)]
  public string? PrevPassword3 { get; set; }

  [Column("_password")]
  [StringLength(64)]
  [Unicode(false)]
  public string? Password { get; set; }

  [Column("_passwordUpdateDate", TypeName = "datetime")]
  public DateTime? PasswordUpdateDate { get; set; }
}