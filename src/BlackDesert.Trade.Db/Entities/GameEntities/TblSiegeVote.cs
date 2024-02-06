using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "TerritoryKey")]
[Table("TblSiegeVote", Schema = "PaGamePrivate")]
public class TblSiegeVote
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_territoryKey")]
  public int TerritoryKey { get; set; }

  [Column("_isLike")]
  public bool IsLike { get; set; }
}