using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblChannelChatBlockInfo", Schema = "PaGamePrivate")]
public class TblChannelChatBlockInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_availableBlockCount")]
  public short? AvailableBlockCount { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }

  [Column("_blockedCount")]
  public short? BlockedCount { get; set; }

  [Column("_chattingBlockEndTime", TypeName = "datetime")]
  public DateTime ChattingBlockEndTime { get; set; }

  [Column("_channelJoinBlockEndTime", TypeName = "datetime")]
  public DateTime ChannelJoinBlockEndTime { get; set; }
}