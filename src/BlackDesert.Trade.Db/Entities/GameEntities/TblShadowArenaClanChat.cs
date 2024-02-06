using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaClanChat", Schema = "PaGamePrivate")]
public class TblShadowArenaClanChat
{
  [Key]
  [Column("_chatIdx")]
  public long ChatIdx { get; set; }

  [Column("_fromUserNo")]
  public long FromUserNo { get; set; }

  [Column("_fromUserId")]
  [StringLength(30)]
  public string FromUserId { get; set; } = null!;

  [Column("_chatType")]
  public byte ChatType { get; set; }

  [Column("_langType")]
  public byte LangType { get; set; }

  [Column("_emoticonPackKey")]
  public long EmoticonPackKey { get; set; }

  [Column("_chatRoomNo")]
  public long ChatRoomNo { get; set; }

  [Column("_resType")]
  public byte ResType { get; set; }

  [Column("_chatMsg")]
  [StringLength(351)]
  public string ChatMsg { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}