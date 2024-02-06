using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblChangeContentsOptionUser", Schema = "PaGamePrivate")]
public class TblChangeContentsOptionUser
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }
}