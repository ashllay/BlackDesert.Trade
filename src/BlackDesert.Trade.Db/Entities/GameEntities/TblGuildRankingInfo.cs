using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildRankingInfo", Schema = "PaWebGamePrivate")]
public class TblGuildRankingInfo
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  [Column("_masterUserNo")]
  public long MasterUserNo { get; set; }

  [Column("_masterUserNickname")]
  [StringLength(30)]
  public string? MasterUserNickname { get; set; }

  [Column("_siegeCount")]
  public int? SiegeCount { get; set; }

  [Column("_regionKey1")]
  public int? RegionKey1 { get; set; }

  [Column("_regionKey2")]
  public int? RegionKey2 { get; set; }

  [Column("_regionKey3")]
  public int? RegionKey3 { get; set; }

  [Column("_spotSiegeCount")]
  public int? SpotSiegeCount { get; set; }

  [Column("_winCount")]
  public int? WinCount { get; set; }

  [Column("_aquiredSkillPoint")]
  public int AquiredSkillPoint { get; set; }

  [Column("_memberCount")]
  public int? MemberCount { get; set; }

  [Column("_variedMemberCount")]
  public int VariedMemberCount { get; set; }

  [Column("_guildGrade")]
  public byte GuildGrade { get; set; }

  [Column("_isIntroduction")]
  public bool? IsIntroduction { get; set; }

  [Column("_commentCount")]
  public int? CommentCount { get; set; }

  [Column("_commentRegdate", TypeName = "datetime")]
  public DateTime? CommentRegdate { get; set; }

  [Column("_guildBattleRating")]
  public int? GuildBattleRating { get; set; }

  [Column("_introductionUpdateDate", TypeName = "datetime")]
  public DateTime? IntroductionUpdateDate { get; set; }
}