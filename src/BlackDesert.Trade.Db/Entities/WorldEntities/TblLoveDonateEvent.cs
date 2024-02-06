using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblLoveDonateEvent", Schema = "PaGamePrivate")]
public class TblLoveDonateEvent
{
  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_count")]
  public long? Count { get; set; }

  [Column("_eventNo")]
  public int EventNo { get; set; }
}