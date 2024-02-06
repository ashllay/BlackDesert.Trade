using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblGuildWareHouseHistory", Schema = "PaGamePrivate")]
public class TblGuildWareHouseHistory
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Column("_itemCount")]
  public long ItemCount { get; set; }

  [Column("_isPush")]
  public bool IsPush { get; set; }
}