using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblUserNickNameModStr", Schema = "PaWebGamePrivate")]
public class TblUserNickNameModStr
{
  [Column("_idx")]
  public int? Idx { get; set; }

  [Column("_str")]
  [StringLength(1)]
  [Unicode(false)]
  public string? Str { get; set; }
}