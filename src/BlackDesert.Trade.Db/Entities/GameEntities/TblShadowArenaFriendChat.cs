using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaFriendChat", Schema = "PaGamePrivate")]
public class TblShadowArenaFriendChat
{
  [Key]
  [Column("_chatIdx")]
  public long ChatIdx { get; set; }

  [Column("_fromUserNo")]
  public long FromUserNo { get; set; }

  [Column("_fromUserId")]
  [StringLength(30)]
  public string FromUserId { get; set; } = null!;

  [Column("_toUserNo")]
  public long ToUserNo { get; set; }

  [Column("_toUserId")]
  [StringLength(30)]
  public string ToUserId { get; set; } = null!;

  [Column("_chatMsg")]
  [StringLength(351)]
  public string ChatMsg { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}