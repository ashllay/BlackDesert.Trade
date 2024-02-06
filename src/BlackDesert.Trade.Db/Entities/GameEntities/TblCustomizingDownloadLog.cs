using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCustomizingDownloadLog", Schema = "PaWebGamePrivate")]
public class TblCustomizingDownloadLog
{
  [Column("_customizingNo")]
  public long CustomizingNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_downloadDate", TypeName = "datetime")]
  public DateTime DownloadDate { get; set; }
}