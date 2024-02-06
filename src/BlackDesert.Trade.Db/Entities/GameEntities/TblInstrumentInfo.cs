using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "InstrumentNo")]
[Table("TblInstrumentInfo", Schema = "PaGamePrivate")]
public class TblInstrumentInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_instrumentNo")]
  public byte InstrumentNo { get; set; }
}