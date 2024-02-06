using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCharacterNameModStr", Schema = "PaWebGamePrivate")]
public class TblCharacterNameModStr
{
  [Column("_idx")]
  public int? Idx { get; set; }

  [Column("_str")]
  [StringLength(1)]
  [Unicode(false)]
  public string? Str { get; set; }
}