using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("RoomNo", "MessageIndex")]
[Table("TblMessengerMessage", Schema = "PaGamePrivate")]
public class TblMessengerMessage
{
  [Key]
  [Column("_roomNo")]
  public long RoomNo { get; set; }

  [Key]
  [Column("_messageIndex")]
  public long MessageIndex { get; set; }

  [Column("_senderUserNo")]
  public long SenderUserNo { get; set; }

  [Column("_messageContent")]
  [StringLength(350)]
  public string MessageContent { get; set; } = null!;

  [Column("_emoticonKey")]
  public long EmoticonKey { get; set; }

  [Column("_messageDate", TypeName = "datetime")]
  public DateTime MessageDate { get; set; }

  [Column("_messageRealIndex")]
  public long MessageRealIndex { get; set; }
}