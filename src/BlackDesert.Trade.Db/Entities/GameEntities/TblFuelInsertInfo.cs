using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ObjectNo", "ItemKey")]
[Table("TblFuelInsertInfo", Schema = "PaGamePrivate")]
public class TblFuelInsertInfo
{
  [Key]
  [Column("_objectNo")]
  public long ObjectNo { get; set; }

  [Key]
  [Column("_itemKey")]
  public long ItemKey { get; set; }

  [Column("_itemCount")]
  public long ItemCount { get; set; }

  [Column("_varyCount")]
  public long VaryCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}