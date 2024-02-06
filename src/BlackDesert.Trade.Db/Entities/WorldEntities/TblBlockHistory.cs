using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblBlockHistory", Schema = "PaGamePrivate")]
public class TblBlockHistory
{
  [Key]
  [Column("_historyNo")]
  public long HistoryNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }

  [Column("_blockCode")]
  public int BlockCode { get; set; }

  [Column("_operationMemo")]
  [StringLength(200)]
  public string OperationMemo { get; set; } = null!;
}