using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaAbusingUser", Schema = "PaGamePrivate")]
public class TblShadowArenaAbusingUser
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}