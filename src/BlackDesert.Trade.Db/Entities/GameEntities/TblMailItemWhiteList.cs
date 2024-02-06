using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblMailItemWhiteList", Schema = "PaGamePrivate")]
public class TblMailItemWhiteList
{
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }
}