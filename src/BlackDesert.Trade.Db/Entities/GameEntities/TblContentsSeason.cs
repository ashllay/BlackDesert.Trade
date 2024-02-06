using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ContentsType", "Season")]
[Table("TblContentsSeason", Schema = "PaGamePrivate")]
public class TblContentsSeason
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_contentsType")]
  public int ContentsType { get; set; }

  [Key]
  [Column("_season")]
  public int Season { get; set; }
}