using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("GuildNo", "GuildCommentNo", "UserNo")]
[Table("TblGuildInformationComment", Schema = "PaWebGamePrivate")]
public class TblGuildInformationComment
{
  [Key]
  [Column("_guildCommentNo")]
  public long GuildCommentNo { get; set; }

  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_level")]
  public int Level { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_comment")]
  [StringLength(1000)]
  public string Comment { get; set; } = null!;

  [Column("_regdate", TypeName = "datetime")]
  public DateTime Regdate { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime UpdateDate { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }

  [Column("_isDelete")]
  public bool IsDelete { get; set; }
}