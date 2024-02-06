using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblNewDeliveryRepository", Schema = "PaGamePrivate")]
public class TblNewDeliveryRepository
{
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_index")]
  public byte Index { get; set; }

  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_from")]
  public int From { get; set; }

  [Column("_to")]
  public int To { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_deliveryTime")]
  public int DeliveryTime { get; set; }
}