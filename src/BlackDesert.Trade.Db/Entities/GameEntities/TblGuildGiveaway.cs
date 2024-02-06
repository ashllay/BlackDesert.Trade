using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildGiveaway", Schema = "PaGamePrivate")]
public class TblGuildGiveaway
{
  [Key]
  [Column("_index")]
  public long Index { get; set; }

  [Column("_key")]
  public int Key { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_deleteDate", TypeName = "datetime")]
  public DateTime DeleteDate { get; set; }
}