using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("ProcessTime", "ContentsOptionKey")]
[Table("TblContentsOptionsLog", Schema = "PaGamePrivate")]
public class TblContentsOptionsLog
{
  [Key]
  [Column("_processTime", TypeName = "datetime")]
  public DateTime ProcessTime { get; set; }

  [Key]
  [Column("_contentsOptionKey")]
  public long ContentsOptionKey { get; set; }

  [Column("_changingStatus")]
  public int ChangingStatus { get; set; }
}