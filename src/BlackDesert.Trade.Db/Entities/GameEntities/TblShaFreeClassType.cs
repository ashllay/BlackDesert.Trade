using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShaFreeClassType", Schema = "PaGamePrivate")]
public class TblShaFreeClassType
{
  [Key]
  [Column("_classType")]
  public byte ClassType { get; set; }
}