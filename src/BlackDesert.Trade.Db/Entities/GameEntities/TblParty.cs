using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblParty", Schema = "PaGamePrivate")]
public class TblParty
{
  [Column("_partyId")]
  public long PartyId { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_isPartyLeader")]
  public bool IsPartyLeader { get; set; }
}