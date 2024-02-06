using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterNo")]
[Table("TblFameTotalRank", Schema = "PaWebGamePrivate")]
public class TblFameTotalRank
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_guildName")]
  [StringLength(60)]
  public string? GuildName { get; set; }

  [Column("_rank")]
  public int Rank { get; set; }

  [Column("_fame")]
  public int Fame { get; set; }

  [Column("_killCount")]
  public int KillCount { get; set; }
}