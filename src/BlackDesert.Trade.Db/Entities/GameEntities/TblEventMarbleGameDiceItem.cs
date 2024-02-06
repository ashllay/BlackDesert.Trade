using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "DiceItemKey")]
[Table("TblEventMarbleGameDiceItem", Schema = "PaWebGamePrivate")]
public class TblEventMarbleGameDiceItem
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_diceItemKey")]
  public int DiceItemKey { get; set; }

  [Column("_count")]
  public int Count { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}