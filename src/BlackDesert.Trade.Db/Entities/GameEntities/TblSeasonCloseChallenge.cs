using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseChallenge", Schema = "PaGamePrivate")]
public class TblSeasonCloseChallenge
{
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_challengeKey")]
  public int ChallengeKey { get; set; }
}