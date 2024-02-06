using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblFindHiddenRecipe", Schema = "PaGamePrivate")]
public class TblFindHiddenRecipe
{
  [Key]
  [Column("_recipe")]
  public int Recipe { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_findTime", TypeName = "datetime")]
  public DateTime FindTime { get; set; }
}