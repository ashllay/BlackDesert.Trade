using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("HostGuildNo", "ReciveUserNo")]
[Table("TblSimpleGuildInviteList", Schema = "PaGamePrivate")]
public class TblSimpleGuildInviteList
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_hostUserNo")]
  public long HostUserNo { get; set; }

  [Key]
  [Column("_hostGuildNo")]
  public long HostGuildNo { get; set; }

  [Key]
  [Column("_reciveUserNo")]
  public long ReciveUserNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  [Column("_hostUserNickName")]
  [StringLength(30)]
  public string HostUserNickName { get; set; } = null!;
}