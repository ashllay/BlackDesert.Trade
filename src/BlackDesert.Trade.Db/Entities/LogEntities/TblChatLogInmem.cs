using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblChatLog_INMEM", Schema = "PaGamePrivate")]
public class TblChatLogInmem
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_operationLogType")]
  public short OperationLogType { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string UserIp { get; set; } = null!;

  [Column("_isUserGm")]
  public bool IsUserGm { get; set; }

  [Column("_playMinuteOfUser")]
  public long? PlayMinuteOfUser { get; set; }

  [Column("_isPcRoom")]
  public bool IsPcRoom { get; set; }

  [Column("_isPcRoomPremium")]
  public bool IsPcRoomPremium { get; set; }

  [Column("_isPvP")]
  public bool? IsPvP { get; set; }

  [Column("_isGuestAccount")]
  public bool? IsGuestAccount { get; set; }

  [Column("_gameAgeGradeType")]
  public byte? GameAgeGradeType { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_characterTendency")]
  public int? CharacterTendency { get; set; }

  [Column("_chatType")]
  public byte ChatType { get; set; }

  [Column("_chatMessage")]
  [StringLength(100)]
  public string ChatMessage { get; set; } = null!;

  [Column("_toCharacterName")]
  [StringLength(30)]
  public string? ToCharacterName { get; set; }

  [Column("_toCharacterNo")]
  public long? ToCharacterNo { get; set; }

  [Column("_chatLinkedItemKey")]
  public int? ChatLinkedItemKey { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_channelChatRoomName")]
  [StringLength(255)]
  public string? ChannelChatRoomName { get; set; }
}