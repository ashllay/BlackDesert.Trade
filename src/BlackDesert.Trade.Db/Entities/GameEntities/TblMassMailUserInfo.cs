using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("MassMailNo", "UserNo")]
[Table("TblMassMailUserInfo", Schema = "PaGamePrivate")]
public class TblMassMailUserInfo
{
  [Key]
  [Column("_massMailNo")]
  public long MassMailNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_mailState")]
  public byte? MailState { get; set; }
}