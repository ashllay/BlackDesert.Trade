using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblPCRoomLoginList", Schema = "PaGamePrivate")]
public class TblPcroomLoginList
{
  [Column("_gatewayServerNo")]
  public byte GatewayServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_sessionNo")]
  [StringLength(30)]
  [Unicode(false)]
  public string SessionNo { get; set; } = null!;

  [Column("_status")]
  public byte Status { get; set; }

  [Column("_ingameUpdateDate", TypeName = "datetime")]
  public DateTime IngameUpdateDate { get; set; }

  [Column("_gussUpdateDate", TypeName = "datetime")]
  public DateTime GussUpdateDate { get; set; }

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

  [Column("_reason")]
  public byte? Reason { get; set; }
}