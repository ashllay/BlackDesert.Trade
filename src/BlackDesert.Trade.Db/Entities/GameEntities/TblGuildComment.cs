using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblGuildComments", Schema = "PaWebGamePrivate")]
public class TblGuildComment
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_commentNo")]
  public long CommentNo { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_userComment")]
  [StringLength(200)]
  public string UserComment { get; set; } = null!;

  [Column("_chairGuildNo")]
  public long ChairGuildNo { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }
}