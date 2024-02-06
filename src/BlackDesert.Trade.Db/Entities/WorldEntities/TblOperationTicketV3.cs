using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblOperationTicket_v3", Schema = "PaOperationPrivate")]
public class TblOperationTicketV3
{
  [Column("_registerDate")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_ticketNo")]
  public long TicketNo { get; set; }

  [Column("_whereType")]
  public byte WhereType { get; set; }

  [Column("_requestWhereNo")]
  public long RequestWhereNo { get; set; }

  [Column("_requestRoleGroupNo")]
  public int? RequestRoleGroupNo { get; set; }

  [Column("_requestRoleGroupName")]
  [StringLength(30)]
  public string? RequestRoleGroupName { get; set; }

  [Column("_requestXmlName")]
  [StringLength(30)]
  public string RequestXmlName { get; set; } = null!;

  [Column("_requestDbName")]
  [StringLength(30)]
  public string RequestDbName { get; set; } = null!;

  [Column("_requestSpName")]
  [StringLength(100)]
  public string RequestSpName { get; set; } = null!;

  [Column("_requestList")]
  public string RequestList { get; set; } = null!;

  [Column("_requestReason")]
  [StringLength(300)]
  public string RequestReason { get; set; } = null!;

  [Column("_requestType")]
  public byte RequestType { get; set; }

  [Column("_ticketState")]
  public byte TicketState { get; set; }

  [Column("_confirmWhereNo")]
  public long? ConfirmWhereNo { get; set; }

  [Column("_confirmRoleGroupNo")]
  public int? ConfirmRoleGroupNo { get; set; }

  [Column("_confirmRoleGroupName")]
  [StringLength(30)]
  public string? ConfirmRoleGroupName { get; set; }

  [Column("_confirmReason")]
  [StringLength(300)]
  public string? ConfirmReason { get; set; }

  [Column("_confirmDate")]
  public DateTime? ConfirmDate { get; set; }
}