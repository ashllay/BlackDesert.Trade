using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCustomizingGalleryBlind", Schema = "PaWebGamePrivate")]
public class TblCustomizingGalleryBlind
{
  [Column("_customizingNo")]
  public long CustomizingNo { get; set; }

  [Column("_blindUserNo")]
  public long BlindUserNo { get; set; }

  [Column("_blindDate", TypeName = "datetime")]
  public DateTime BlindDate { get; set; }
}