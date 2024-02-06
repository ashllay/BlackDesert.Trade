using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblContentsOptionsNewList", Schema = "PaGamePrivate")]
public class TblContentsOptionsNewList
{
  [Key]
  [Column("_contentsOptionKey")]
  public long ContentsOptionKey { get; set; }
}