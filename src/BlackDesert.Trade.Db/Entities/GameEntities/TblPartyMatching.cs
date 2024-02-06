using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblPartyMatching", Schema = "PaGamePrivate")]
public class TblPartyMatching
{
  [Key]
  [Column("_matchId")]
  public long MatchId { get; set; }

  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_memberCount")]
  public int MemberCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}