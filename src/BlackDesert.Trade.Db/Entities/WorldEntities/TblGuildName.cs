using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblGuildName", Schema = "PaOperationPrivate")]
public class TblGuildName
{
  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;
}