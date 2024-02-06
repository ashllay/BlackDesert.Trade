using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblWantedList", Schema = "PaGamePrivate")]
public class TblWantedList
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_leftDeadCount")]
  public int LeftDeadCount { get; set; }

  [Column("_bounty")]
  public long Bounty { get; set; }
}