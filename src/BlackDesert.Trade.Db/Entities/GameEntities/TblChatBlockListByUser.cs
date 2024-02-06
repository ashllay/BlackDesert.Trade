using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("FromUserNo", "ToUserNo")]
[Table("TblChatBlockListByUser", Schema = "PaGamePrivate")]
public class TblChatBlockListByUser
{
  [Key]
  [Column("_fromUserNo")]
  public long FromUserNo { get; set; }

  [Key]
  [Column("_toUserNo")]
  public long ToUserNo { get; set; }

  [Column("_lastDate", TypeName = "datetime")]
  public DateTime LastDate { get; set; }
}