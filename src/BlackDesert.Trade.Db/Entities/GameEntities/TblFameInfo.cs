using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblFameInfo", Schema = "PaGamePrivate")]
public class TblFameInfo
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_fame")]
  public int Fame { get; set; }

  [Column("_killCount")]
  public int KillCount { get; set; }

  [Column("_isSheriff")]
  public bool IsSheriff { get; set; }
}