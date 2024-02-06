using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("GuildNo", "SkillNo")]
[Table("TblGuildSkillCoolTime", Schema = "PaGamePrivate")]
public class TblGuildSkillCoolTime
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Key]
  [Column("_skillNo")]
  public int SkillNo { get; set; }

  [Column("_reusableTime", TypeName = "datetime")]
  public DateTime ReusableTime { get; set; }
}