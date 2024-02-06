using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblPS4CashConsumeLog", Schema = "PaGamePrivate")]
public class TblPs4cashConsumeLog
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_useLimit")]
  public long UseLimit { get; set; }

  [Column("_useCount")]
  public long UseCount { get; set; }

  [Column("_entitlementId")]
  [StringLength(20)]
  public string EntitlementId { get; set; } = null!;

  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_mailNo")]
  public long MailNo { get; set; }
}