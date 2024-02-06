using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "ContentsType")]
[Table("TblTroller", Schema = "PaGamePrivate")]
public class TblTroller
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   컨텐츠 타입
  /// </summary>
  [Key]
  [Column("_contentsType")]
  public int ContentsType { get; set; }

  /// <summary>
  ///   신고 당한 횟수
  /// </summary>
  [Column("_reportStack")]
  public int ReportStack { get; set; }

  /// <summary>
  ///   밴 시간
  /// </summary>
  [Column("_bannedTime", TypeName = "datetime")]
  public DateTime? BannedTime { get; set; }
}