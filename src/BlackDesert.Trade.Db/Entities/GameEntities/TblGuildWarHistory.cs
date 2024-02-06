using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("OwnerGuildNo", "TargetGuildNo")]
[Table("TblGuildWarHistory", Schema = "PaGamePrivate")]
public class TblGuildWarHistory
{
  [Key]
  [Column("_ownerGuildNo")]
  public long OwnerGuildNo { get; set; }

  [Key]
  [Column("_targetGuildNo")]
  public long TargetGuildNo { get; set; }

  [Column("_warEndTime", TypeName = "datetime")]
  public DateTime WarEndTime { get; set; }
}