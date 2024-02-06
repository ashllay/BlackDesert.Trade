using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaRestrictMode", Schema = "PaGamePrivate")]
public class TblShadowArenaRestrictMode
{
  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_isRestrict")]
  public bool IsRestrict { get; set; }
}