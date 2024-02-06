using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ServiceType", "ItemKey")]
[Table("TblPearlItemList", Schema = "PaGamePrivate")]
public class TblPearlItemList
{
  [Key]
  [Column("_serviceType")]
  public int ServiceType { get; set; }

  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_totalCount")]
  public int TotalCount { get; set; }
}