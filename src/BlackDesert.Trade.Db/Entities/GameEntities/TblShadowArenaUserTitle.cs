using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaUserTitle", Schema = "PaGamePrivate")]
public class TblShadowArenaUserTitle
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_titleKey")]
  public int TitleKey { get; set; }
}