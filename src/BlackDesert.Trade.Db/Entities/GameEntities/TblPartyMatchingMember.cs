using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblPartyMatchingMember", Schema = "PaGamePrivate")]
public class TblPartyMatchingMember
{
  [Column("_matchId")]
  public long MatchId { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }
}