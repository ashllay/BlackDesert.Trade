using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSyncGuildInformation", Schema = "PaWebGamePrivate")]
public class TblSyncGuildInformation
{
  [Column("_memberRegisterDate", TypeName = "datetime")]
  public DateTime MemberRegisterDate { get; set; }

  [Column("_guildRegisterDate", TypeName = "datetime")]
  public DateTime GuildRegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_masterUserNo")]
  public long MasterUserNo { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  [Column("_guildGrade")]
  public byte GuildGrade { get; set; }

  [Column("_regionKey")]
  public int? RegionKey { get; set; }
}