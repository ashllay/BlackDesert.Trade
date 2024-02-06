using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Type")]
[Table("TblMiniGameUserInformation", Schema = "PaGamePrivate")]
public class TblMiniGameUserInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_type")]
  public int Type { get; set; }

  [Column("_win")]
  public int Win { get; set; }

  [Column("_lose")]
  public int Lose { get; set; }

  [Column("_draw")]
  public int Draw { get; set; }

  [Column("_escape")]
  public int Escape { get; set; }
}