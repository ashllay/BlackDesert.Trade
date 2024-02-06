using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblTradeCompany", Schema = "PaGamePrivate")]
public class TblTradeCompany
{
  [Key]
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  [Column("_isActiveWorkerTrade")]
  public bool IsActiveWorkerTrade { get; set; }

  [Column("_money")]
  public long Money { get; set; }

  [Column("_carriage")]
  public int Carriage { get; set; }

  [Column("_amulet")]
  public int Amulet { get; set; }

  [Column("_porter")]
  public int Porter { get; set; }

  [Column("_guard")]
  public int Guard { get; set; }
}