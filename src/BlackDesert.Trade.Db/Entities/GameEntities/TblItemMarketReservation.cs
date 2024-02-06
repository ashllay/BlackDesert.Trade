using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ItemEnchantKey", "RegisterUserNo")]
[Table("TblItemMarketReservation", Schema = "PaGamePrivate")]
public class TblItemMarketReservation
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_itemEnchantKey")]
  public int ItemEnchantKey { get; set; }

  [Key]
  [Column("_registerUserNo")]
  public long RegisterUserNo { get; set; }

  [Column("_onePrice")]
  public long OnePrice { get; set; }

  [Column("_totalCount")]
  public long TotalCount { get; set; }

  [Column("_leftCount")]
  public long LeftCount { get; set; }

  [Column("_registerTerritory")]
  public long RegisterTerritory { get; set; }

  [Column("_registerCharacterName")]
  [StringLength(30)]
  public string RegisterCharacterName { get; set; } = null!;
}