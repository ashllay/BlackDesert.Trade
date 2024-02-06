using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "MainChallengeKey")]
[Table("TblPearlUsedChallengeResetCount", Schema = "PaGamePrivate")]
public class TblPearlUsedChallengeResetCount
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_mainChallengeKey")]
  public int MainChallengeKey { get; set; }

  [Column("_resetCount")]
  public int? ResetCount { get; set; }
}