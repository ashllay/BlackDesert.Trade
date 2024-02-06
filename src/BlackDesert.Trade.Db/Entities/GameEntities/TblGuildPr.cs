using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildPR", Schema = "PaGamePrivate")]
public class TblGuildPr
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_category")]
  public byte Category { get; set; }

  [Column("_isOpen")]
  public bool IsOpen { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  [Column("_masterUserNickName")]
  [StringLength(30)]
  public string MasterUserNickName { get; set; } = null!;

  [Column("_guildGrade")]
  public byte GuildGrade { get; set; }

  [Column("_memberCount")]
  public int MemberCount { get; set; }

  [Column("_aquiredSkillPoint")]
  public int AquiredSkillPoint { get; set; }
}