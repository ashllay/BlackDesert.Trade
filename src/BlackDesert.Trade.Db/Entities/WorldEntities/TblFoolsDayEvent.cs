using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblFoolsDayEvent", Schema = "PaGamePrivate")]
public class TblFoolsDayEvent
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_mDate", TypeName = "datetime")]
  public DateTime? MDate { get; set; }

  [Column("_itemKey")]
  public long? ItemKey { get; set; }

  [Column("_sumCount")]
  public long? SumCount { get; set; }
}