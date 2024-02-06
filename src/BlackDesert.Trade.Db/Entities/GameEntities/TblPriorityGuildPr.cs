using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblPriorityGuildPR", Schema = "PaGamePrivate")]
public class TblPriorityGuildPr
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }
}