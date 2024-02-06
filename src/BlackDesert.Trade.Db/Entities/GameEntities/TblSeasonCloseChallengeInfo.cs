using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("ChallengeKey", "CloseType")]
[Table("TblSeasonCloseChallengeInfo", Schema = "PaGamePrivate")]
public class TblSeasonCloseChallengeInfo
{
  [Key]
  [Column("_challengeKey")]
  public int ChallengeKey { get; set; }

  [Key]
  [Column("_closeType")]
  public int CloseType { get; set; }
}