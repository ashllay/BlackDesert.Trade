using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Type")]
[Table("TblWorldMarketTicket", Schema = "PaGamePrivate")]
public class TblWorldMarketTicket
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_ticketNo")]
  public Guid? TicketNo { get; set; }

  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }
}