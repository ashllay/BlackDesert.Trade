using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblPersonalMonsterUserInfo", Schema = "PaGamePrivate")]
public class TblPersonalMonsterUserInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }
}