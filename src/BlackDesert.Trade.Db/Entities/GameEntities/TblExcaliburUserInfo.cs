using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblExcaliburUserInfo", Schema = "PaGamePrivate")]
public class TblExcaliburUserInfo
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_drawExcaliburCount")]
  public int DrawExcaliburCount { get; set; }

  [Column("_resetTime", TypeName = "datetime")]
  public DateTime ResetTime { get; set; }
}