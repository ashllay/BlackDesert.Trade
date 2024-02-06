using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "RegionKey")]
[Table("TblTeleportationPoint", Schema = "PaGamePrivate")]
public class TblTeleportationPoint
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_regionKey")]
  public long RegionKey { get; set; }
}