using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblStatementTemp", Schema = "PaOperationPrivate")]
public class TblStatementTemp
{
  [Column("_idx")]
  public int Idx { get; set; }

  [Column("_objecttype")]
  [StringLength(30)]
  [Unicode(false)]
  public string? Objecttype { get; set; }

  [Column("_objectName")]
  [StringLength(100)]
  [Unicode(false)]
  public string? ObjectName { get; set; }

  [Column("_objectQuert")]
  [Unicode(false)]
  public string? ObjectQuert { get; set; }
}