using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblShaRegistedUserYesterday", Schema = "PaOperationPrivate")]
public class TblShaRegistedUserYesterday
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }
}