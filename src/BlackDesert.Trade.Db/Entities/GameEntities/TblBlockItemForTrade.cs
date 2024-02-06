using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBlockItemForTrade", Schema = "PaGamePrivate")]
public class TblBlockItemForTrade
{
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_reasonMemo")]
  [StringLength(200)]
  public string? ReasonMemo { get; set; }
}