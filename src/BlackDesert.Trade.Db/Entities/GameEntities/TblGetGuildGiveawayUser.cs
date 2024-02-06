using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("Index", "UserNo")]
[Table("TblGetGuildGiveawayUser", Schema = "PaGamePrivate")]
public class TblGetGuildGiveawayUser
{
  [Key]
  [Column("_index")]
  public long Index { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}