using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMassPlayerTitleRequest", Schema = "PaOperationPublic")]
public class TblMassPlayerTitleRequest
{
  [Column("_no")]
  public long No { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_userIdString")]
  [StringLength(5000)]
  [Unicode(false)]
  public string? UserIdString { get; set; }

  [Column("_titleKey")]
  public long? TitleKey { get; set; }
}