using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCheckItemForRemoveCharacter", Schema = "PaGamePrivate")]
public class TblCheckItemForRemoveCharacter
{
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }
}