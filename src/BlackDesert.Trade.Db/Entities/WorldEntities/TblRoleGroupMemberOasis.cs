using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("WhereType", "WhereNo")]
[Table("TblRoleGroupMemberOasis", Schema = "PaOperationPrivate")]
public class TblRoleGroupMemberOasis
{
  [Key]
  [Column("_whereType")]
  public byte WhereType { get; set; }

  [Key]
  [Column("_whereNo")]
  public long WhereNo { get; set; }

  [Column("_roleGroupNo")]
  public byte RoleGroupNo { get; set; }

  [Column("_password")]
  [StringLength(64)]
  [Unicode(false)]
  public string? Password { get; set; }

  [Column("_passwordUpdateDate")]
  public DateTime? PasswordUpdateDate { get; set; }

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

  [Column("_loginAttemptCount")]
  public byte LoginAttemptCount { get; set; }

  [Column("_lastLoginDate")]
  public DateTime? LastLoginDate { get; set; }

  [Column("_roleGroupMemberMemo")]
  [StringLength(50)]
  public string? RoleGroupMemberMemo { get; set; }

  [Column("_extraTime")]
  public DateTime? ExtraTime { get; set; }
}