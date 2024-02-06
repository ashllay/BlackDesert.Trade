using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblIPBlockHistory", Schema = "PaGamePrivate")]
public class TblIpblockHistory
{
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_startIP")]
  [StringLength(15)]
  public string StartIp { get; set; } = null!;

  [Column("_endIP")]
  [StringLength(15)]
  public string EndIp { get; set; } = null!;

  [Column("_blockCode")]
  public int BlockCode { get; set; }

  [Column("_operationMemo")]
  [StringLength(200)]
  public string OperationMemo { get; set; } = null!;
}