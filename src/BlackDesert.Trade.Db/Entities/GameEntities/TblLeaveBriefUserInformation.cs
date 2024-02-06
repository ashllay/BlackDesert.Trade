using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblLeaveBriefUserInformation", Schema = "PaGamePrivate")]
public class TblLeaveBriefUserInformation
{
  [Column("_leaveDate", TypeName = "datetime")]
  public DateTime? LeaveDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string? UserNickname { get; set; }

  [Column("_tmpName")]
  [StringLength(30)]
  public string? TmpName { get; set; }
}