using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "RegionKey", "MenuType")]
[Table("TblBlackSpiritAdventureRegion", Schema = "PaWebGamePrivate")]
public class TblBlackSpiritAdventureRegion
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_menuType")]
  public byte MenuType { get; set; }

  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  [Column("_status")]
  public bool Status { get; set; }
}