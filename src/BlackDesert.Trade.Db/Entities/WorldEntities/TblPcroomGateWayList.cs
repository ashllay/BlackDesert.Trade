using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblPCRoomGateWayList", Schema = "PaGamePrivate")]
public class TblPcroomGateWayList
{
  [Key]
  [Column("_gatewayServerNo")]
  public byte GatewayServerNo { get; set; }

  [Column("_serverIP")]
  [StringLength(20)]
  public string ServerIp { get; set; } = null!;

  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }

  [Column("_status")]
  public byte Status { get; set; }
}