using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "SkinKey")]
[Table("TblShadowArenaSkinDyingInfo", Schema = "PaGamePrivate")]
public class TblShadowArenaSkinDyingInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_skinKey")]
  public int SkinKey { get; set; }

  [Column("_dyeingInfo1")]
  [MaxLength(24)]
  public byte[]? DyeingInfo1 { get; set; }

  [Column("_dyeingInfo2")]
  [MaxLength(24)]
  public byte[]? DyeingInfo2 { get; set; }

  [Column("_dyeingInfo3")]
  [MaxLength(24)]
  public byte[]? DyeingInfo3 { get; set; }

  [Column("_dyeingInfo4")]
  [MaxLength(24)]
  public byte[]? DyeingInfo4 { get; set; }

  [Column("_dyeingInfo5")]
  [MaxLength(24)]
  public byte[]? DyeingInfo5 { get; set; }
}