using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMailPS4Sub", Schema = "PaGamePrivate")]
public class TblMailPs4sub
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_mailNo")]
  public long? MailNo { get; set; }

  [Column("_entitlementId")]
  [StringLength(16)]
  public string EntitlementId { get; set; } = null!;

  [Column("_isBundleProduct")]
  public bool IsBundleProduct { get; set; }
}