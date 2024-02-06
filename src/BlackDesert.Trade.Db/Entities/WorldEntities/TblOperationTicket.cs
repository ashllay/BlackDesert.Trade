using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblOperationTicket", Schema = "PaOperationPrivate")]
public class TblOperationTicket
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_ticketNo")]
  public long TicketNo { get; set; }

  [Column("_worldNo")]
  public short WorldNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_requestType")]
  public byte RequestType { get; set; }

  [Column("_requestList")]
  [StringLength(1000)]
  public string RequestList { get; set; } = null!;

  [Column("_reason")]
  [StringLength(300)]
  public string Reason { get; set; } = null!;

  [Column("_gmUserNo")]
  public long GmUserNo { get; set; }

  [Column("_priority")]
  public byte Priority { get; set; }

  [Column("_ticketState")]
  public byte TicketState { get; set; }

  [Column("_approvedUserNo")]
  public long? ApprovedUserNo { get; set; }

  [Column("_updatedDate", TypeName = "datetime")]
  public DateTime UpdatedDate { get; set; }

  [Column("_confirmReason")]
  [StringLength(300)]
  public string? ConfirmReason { get; set; }
}