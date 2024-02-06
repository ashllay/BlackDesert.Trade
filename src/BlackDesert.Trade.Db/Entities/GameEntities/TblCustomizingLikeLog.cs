using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCustomizingLikeLog", Schema = "PaWebGamePrivate")]
public class TblCustomizingLikeLog
{
  [Column("_customizingNo")]
  public long CustomizingNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_LikeDate", TypeName = "datetime")]
  public DateTime LikeDate { get; set; }
}