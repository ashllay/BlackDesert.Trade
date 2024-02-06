using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblChatBlockByUser", Schema = "PaGamePrivate")]
public class TblChatBlockByUser
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_endDate", TypeName = "datetime")]
  public DateTime? EndDate { get; set; }

  [Column("_point")]
  public short Point { get; set; }
}