using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   절대권력
/// </summary>
[PrimaryKey("UserNo", "CurseType")]
[Table("TblAbsolutePower", Schema = "PaGamePrivate")]
public class TblAbsolutePower
{
  /// <summary>
  ///   저주 걸린 사용자 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   저주 타입
  /// </summary>
  [Key]
  [Column("_curseType")]
  public short CurseType { get; set; }

  /// <summary>
  ///   만기 시간
  /// </summary>
  [Column("_expirationTime", TypeName = "datetime")]
  public DateTime ExpirationTime { get; set; }
}