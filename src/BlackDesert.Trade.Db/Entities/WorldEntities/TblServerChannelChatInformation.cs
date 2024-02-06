using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblServerChannelChatInformation", Schema = "PaGamePrivate")]
public class TblServerChannelChatInformation
{
  [Column("_orderNo")]
  public int OrderNo { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Key]
  [Column("_roomNo")]
  public long RoomNo { get; set; }

  [Column("_roomName")]
  [StringLength(32)]
  public string RoomName { get; set; } = null!;

  [Column("_roomDesc")]
  [StringLength(150)]
  public string RoomDesc { get; set; } = null!;

  [Column("_maxMemberCount")]
  public short MaxMemberCount { get; set; }
}