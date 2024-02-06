using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblInvestGuildPointInformation", Schema = "PaGamePrivate")]
public class TblInvestGuildPointInformation
{
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildPoint")]
  public int GuildPoint { get; set; }

  [Column("_investType")]
  public short InvestType { get; set; }

  [Key]
  [Column("_investKey")]
  public int InvestKey { get; set; }

  [Column("_useDate", TypeName = "datetime")]
  public DateTime UseDate { get; set; }
}