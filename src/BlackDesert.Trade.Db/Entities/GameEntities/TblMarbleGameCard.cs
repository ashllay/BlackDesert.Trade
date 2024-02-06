using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CardKey")]
[Table("TblMarbleGameCard", Schema = "PaWebGamePrivate")]
public class TblMarbleGameCard
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_cardKey")]
  public int CardKey { get; set; }

  [Column("_count")]
  public int Count { get; set; }
}