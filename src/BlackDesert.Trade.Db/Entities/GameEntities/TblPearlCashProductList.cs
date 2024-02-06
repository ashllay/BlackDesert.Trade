using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ServiceType", "CashProductNo")]
[Table("TblPearlCashProductList", Schema = "PaGamePrivate")]
public class TblPearlCashProductList
{
  [Key]
  [Column("_serviceType")]
  public int ServiceType { get; set; }

  [Key]
  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_totalCount")]
  public int TotalCount { get; set; }
}