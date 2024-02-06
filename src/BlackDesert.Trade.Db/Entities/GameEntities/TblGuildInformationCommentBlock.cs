using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("GuildNo", "GuildCommentBlockNo")]
[Table("TblGuildInformationCommentBlock", Schema = "PaWebGamePrivate")]
public class TblGuildInformationCommentBlock
{
  [Key]
  [Column("_guildCommentBlockNo")]
  public long GuildCommentBlockNo { get; set; }

  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_isBlock")]
  public int IsBlock { get; set; }

  [Column("_regdate", TypeName = "datetime")]
  public DateTime Regdate { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime UpdateDate { get; set; }
}