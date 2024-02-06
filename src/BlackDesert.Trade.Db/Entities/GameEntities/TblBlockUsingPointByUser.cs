using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBlockUsingPointByUser", Schema = "PaGamePrivate")]
public class TblBlockUsingPointByUser
{
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_reasonMemo")]
  [StringLength(200)]
  public string? ReasonMemo { get; set; }
}