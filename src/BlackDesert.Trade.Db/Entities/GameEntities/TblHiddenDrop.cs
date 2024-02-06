using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   히든 드랍
/// </summary>
[PrimaryKey("UserNo", "HiddenDropNo")]
[Table("TblHiddenDrop", Schema = "PaGamePrivate")]
public class TblHiddenDrop
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   드랍 고유 번호
  /// </summary>
  [Key]
  [Column("_hiddenDropNo")]
  public long HiddenDropNo { get; set; }

  /// <summary>
  ///   진행 정도
  /// </summary>
  [Column("_hiddenDropCount")]
  public long HiddenDropCount { get; set; }

  /// <summary>
  ///   완료 시간
  /// </summary>
  [Column("_completeDate", TypeName = "datetime")]
  public DateTime? CompleteDate { get; set; }
}