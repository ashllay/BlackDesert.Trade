using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCouponTargetUser", Schema = "PaOperationPrivate")]
public class TblCouponTargetUser
{
  [Column("_userNo")]
  public long? UserNo { get; set; }
}