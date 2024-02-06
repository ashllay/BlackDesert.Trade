using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblItemCollectionScroll", Schema = "PaGamePrivate")]
public class TblItemCollectionScroll
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_collectionPoint")]
  public int CollectionPoint { get; set; }

  [Column("_currentGrade")]
  public int CurrentGrade { get; set; }

  [Column("_coolTime", TypeName = "datetime")]
  public DateTime? CoolTime { get; set; }
}