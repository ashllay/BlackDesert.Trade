using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "WebItemKey")]
[Table("TblBlackSpiritAdventureItem", Schema = "PaWebGamePrivate")]
public class TblBlackSpiritAdventureItem
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_webItemKey")]
  public int WebItemKey { get; set; }

  [Column("_itemCount")]
  public int ItemCount { get; set; }

  [Column("_useCondition")]
  public byte UseCondition { get; set; }
}