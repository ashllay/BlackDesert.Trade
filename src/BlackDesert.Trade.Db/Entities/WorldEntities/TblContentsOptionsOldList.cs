using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblContentsOptionsOldList", Schema = "PaGamePrivate")]
public class TblContentsOptionsOldList
{
  [Key]
  [Column("_contentsOptionKey")]
  public long ContentsOptionKey { get; set; }
}