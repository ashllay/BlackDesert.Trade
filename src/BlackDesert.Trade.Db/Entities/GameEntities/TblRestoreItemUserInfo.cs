using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "RestoreType")]
[Table("TblRestoreItemUserInfo", Schema = "PaGamePrivate")]
public class TblRestoreItemUserInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_restoreType")]
  public byte RestoreType { get; set; }

  [Column("_nextResetDate", TypeName = "datetime")]
  public DateTime NextResetDate { get; set; }

  [Column("_count")]
  public int Count { get; set; }
}