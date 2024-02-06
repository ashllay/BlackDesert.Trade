using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   범용 저장소
/// </summary>
[PrimaryKey("Type", "MainKey", "SubKey")]
[Table("TblGeneralRepository", Schema = "PaGamePrivate")]
public class TblGeneralRepository
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   타입별로 아래 분류
  /// </summary>
  [Key]
  [Column("_type")]
  public long Type { get; set; }

  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_mainKey")]
  public long MainKey { get; set; }

  /// <summary>
  ///   WayPoint 또는 캐릭터키
  /// </summary>
  [Key]
  [Column("_subKey")]
  public long SubKey { get; set; }

  /// <summary>
  ///   탐험lv 또는 친밀도
  /// </summary>
  [Column("_value")]
  public long? Value { get; set; }

  /// <summary>
  ///   발견또는 레벨변경일시 또는 미사용
  /// </summary>
  [Column("_dateTime", TypeName = "datetime")]
  public DateTime? DateTime { get; set; }
}