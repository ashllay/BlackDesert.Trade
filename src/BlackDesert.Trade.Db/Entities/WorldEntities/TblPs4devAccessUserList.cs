using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblPS4DevAccessUserList", Schema = "PaGamePrivate")]
public class TblPs4devAccessUserList
{
  [Key]
  [Column("_tokenKey")]
  [StringLength(25)]
  public string TokenKey { get; set; } = null!;

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_ps4UserId")]
  [StringLength(30)]
  public string Ps4UserId { get; set; } = null!;

  [Column("_accessIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string AccessIp { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_usedDate", TypeName = "datetime")]
  public DateTime? UsedDate { get; set; }
}