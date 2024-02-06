using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "GameOptionType")]
[Table("TblUserGameOptionType", Schema = "PaGamePrivate")]
public class TblUserGameOptionType
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_gameOptionType")]
  public int GameOptionType { get; set; }

  [Column("_gameOptionValue")]
  [StringLength(100)]
  [Unicode(false)]
  public string GameOptionValue { get; set; } = null!;
}