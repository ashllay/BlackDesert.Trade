using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("GuildNo", "UserNo")]
[Table("TblGuildApplicants", Schema = "PaGamePrivate")]
public class TblGuildApplicant
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_level")]
  public int Level { get; set; }

  [Column("_wp")]
  public int Wp { get; set; }

  [Column("_explorationPoint")]
  public int ExplorationPoint { get; set; }

  [Column("_offenceValue")]
  public int OffenceValue { get; set; }

  [Column("_awakenValue")]
  public int AwakenValue { get; set; }

  [Column("_defenceValue")]
  public int DefenceValue { get; set; }

  [Column("_introduction")]
  [StringLength(200)]
  public string? Introduction { get; set; }
}