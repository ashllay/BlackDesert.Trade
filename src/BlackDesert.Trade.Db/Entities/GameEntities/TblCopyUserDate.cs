using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCopyUserDate", Schema = "PaWebGamePrivate")]
public class TblCopyUserDate
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_liveUserNo")]
  public long LiveUserNo { get; set; }

  [Column("_nation")]
  [StringLength(4)]
  public string Nation { get; set; } = null!;

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;
}