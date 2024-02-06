using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblServerGroup", Schema = "PaOperationPrivate")]
public class TblServerGroup
{
  [Column("_serverGroup")]
  [StringLength(1)]
  [Unicode(false)]
  public string? ServerGroup { get; set; }

  [Column("_serverNo")]
  public int? ServerNo { get; set; }
}