using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblTeleportableUser", Schema = "PaGamePrivate")]
public class TblTeleportableUser
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }
}