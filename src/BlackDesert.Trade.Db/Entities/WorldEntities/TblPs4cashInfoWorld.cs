using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("UserId", "EntitlementId")]
[Table("TblPS4CashInfoWorld", Schema = "PaGamePrivate")]
public class TblPs4cashInfoWorld
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Key]
  [Column("_entitlementId")]
  [StringLength(16)]
  public string EntitlementId { get; set; } = null!;

  [Column("_useLimit")]
  public long UseLimit { get; set; }

  [Column("_useCount")]
  public long UseCount { get; set; }

  [Column("_consumeCount")]
  public long ConsumeCount { get; set; }

  [Column("_activeDate", TypeName = "datetime")]
  public DateTime ActiveDate { get; set; }
}