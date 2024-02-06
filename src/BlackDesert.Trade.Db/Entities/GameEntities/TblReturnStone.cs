using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("CharacterNo", "TeleportType")]
[Table("TblReturnStone", Schema = "PaGamePrivate")]
public class TblReturnStone
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_returnPositionX")]
  public long ReturnPositionX { get; set; }

  [Column("_returnPositionY")]
  public long ReturnPositionY { get; set; }

  [Column("_returnPositionZ")]
  public long ReturnPositionZ { get; set; }

  [Column("_usableDate", TypeName = "datetime")]
  public DateTime UsableDate { get; set; }

  [Column("_returnRegionKey")]
  public int ReturnRegionKey { get; set; }

  [Key]
  [Column("_teleportType")]
  public byte TeleportType { get; set; }
}