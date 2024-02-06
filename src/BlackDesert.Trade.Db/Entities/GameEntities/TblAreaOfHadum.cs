using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblAreaOfHadum", Schema = "PaGamePrivate")]
public class TblAreaOfHadum
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_point")]
  public int Point { get; set; }
}