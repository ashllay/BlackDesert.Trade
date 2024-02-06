using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Type")]
[Table("TblBuffCount", Schema = "PaGamePrivate")]
public class TblBuffCount
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_count")]
  public long Count { get; set; }
}