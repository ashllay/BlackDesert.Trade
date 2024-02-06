using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMassMailInfo", Schema = "PaOperationPublic")]
public class TblMassMailInfo
{
  [Column("_mailRequestNo")]
  public long? MailRequestNo { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }
}