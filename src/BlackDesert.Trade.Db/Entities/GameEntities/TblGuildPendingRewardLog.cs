using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblGuildPendingRewardLog", Schema = "PaGamePrivate")]
public class TblGuildPendingRewardLog
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_itemKey")]
  public int? ItemKey { get; set; }

  [Column("_itemCount")]
  public long? ItemCount { get; set; }
}