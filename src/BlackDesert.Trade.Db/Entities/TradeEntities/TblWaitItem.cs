using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("KeyType", "MainKey", "SubKey")]
[Table("TblWaitItem", Schema = "PaGamePrivate")]
public class TblWaitItem
{
  [Key]
  [Column("_keyType")]
  public int KeyType { get; set; }

  [Key]
  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Key]
  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}