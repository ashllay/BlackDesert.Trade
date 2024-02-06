using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblGuildInformation", Schema = "PaWebGamePrivate")]
[Microsoft.EntityFrameworkCore.Index("GuildNo", Name = "PkTblGuildInformation", IsUnique = true)]
public class TblGuildInformation
{
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildInformation")]
  [StringLength(1000)]
  public string? GuildInformation { get; set; }

  [Column("_guildImageUrl")]
  [StringLength(200)]
  public string? GuildImageUrl { get; set; }

  [Column("_guildYouTubeUrl")]
  [StringLength(200)]
  public string? GuildYouTubeUrl { get; set; }

  [Column("_guildFacebookUrl")]
  [StringLength(200)]
  public string? GuildFacebookUrl { get; set; }

  [Column("_guildCommentCount")]
  public int? GuildCommentCount { get; set; }

  [Column("_guildCommentUsed")]
  public int GuildCommentUsed { get; set; }

  [Column("_guildNickNameCommentCount")]
  public int GuildNickNameCommentCount { get; set; }

  [Column("_isBlind")]
  public bool? IsBlind { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime? UpdateDate { get; set; }
}