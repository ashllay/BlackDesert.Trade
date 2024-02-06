using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblSkillPresetLastUpdateTime", Schema = "PaGamePrivate")]
public class TblSkillPresetLastUpdateTime
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_lastUpdateTimeNpc", TypeName = "datetime")]
  public DateTime? LastUpdateTimeNpc { get; set; }

  [Column("_lastUpdateTimeBuff", TypeName = "datetime")]
  public DateTime? LastUpdateTimeBuff { get; set; }
}