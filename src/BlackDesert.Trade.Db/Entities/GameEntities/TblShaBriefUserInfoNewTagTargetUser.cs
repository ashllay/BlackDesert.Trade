using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblShaBriefUserInfo_NewTagTargetUser", Schema = "PaOperationPrivate")]
public class TblShaBriefUserInfoNewTagTargetUser
{
  [Column("_idx")]
  public int? Idx { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }
}