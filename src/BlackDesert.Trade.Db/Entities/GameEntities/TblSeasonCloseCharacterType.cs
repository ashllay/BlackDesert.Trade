using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseCharacterType", Schema = "PaGamePrivate")]
public class TblSeasonCloseCharacterType
{
  [Column("_fromType")]
  public byte? FromType { get; set; }

  [Column("_toType")]
  public byte? ToType { get; set; }
}