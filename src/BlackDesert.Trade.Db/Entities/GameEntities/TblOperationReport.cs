using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblOperationReport", Schema = "PaGamePrivate")]
public class TblOperationReport
{
  [Column("_type")]
  public byte? Type { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_report")]
  [StringLength(120)]
  public string Report { get; set; } = null!;
}