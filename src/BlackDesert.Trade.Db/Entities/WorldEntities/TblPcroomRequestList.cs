using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblPCRoomRequestList", Schema = "PaGamePrivate")]
public class TblPcroomRequestList
{
  [Column("_gatewayServerNo")]
  public byte? GatewayServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_sessionNo")]
  [StringLength(30)]
  [Unicode(false)]
  public string? SessionNo { get; set; }

  [Column("_requestType")]
  public byte RequestType { get; set; }

  [Column("_registDate", TypeName = "datetime")]
  public DateTime? RegistDate { get; set; }

  [Column("_doState")]
  public byte? DoState { get; set; }

  [Column("_machineID")]
  [MaxLength(20)]
  public byte[] MachineId { get; set; } = null!;

  [Column("_clientIP")]
  [StringLength(20)]
  [Unicode(false)]
  public string ClientIp { get; set; } = null!;

  [Column("_localIP")]
  [StringLength(20)]
  [Unicode(false)]
  public string LocalIp { get; set; } = null!;
}