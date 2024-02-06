using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblAltarOfBloodRank", Schema = "PaWebGamePrivate")]
public class TblAltarOfBloodRank
{
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_userCharacterName")]
  [StringLength(30)]
  public string UserCharacterName { get; set; } = null!;

  [Column("_contentsType")]
  public short ContentsType { get; set; }

  [Column("_stage")]
  public int Stage { get; set; }

  [Column("_score")]
  public int Score { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_rankingRowNum")]
  public long RankingRowNum { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;
}