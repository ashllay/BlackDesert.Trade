using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "IconKey")]
[Table("TblShadowArenaPurchasedProfileIcon", Schema = "PaGamePrivate")]
public class TblShadowArenaPurchasedProfileIcon
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_iconKey")]
  public short IconKey { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}