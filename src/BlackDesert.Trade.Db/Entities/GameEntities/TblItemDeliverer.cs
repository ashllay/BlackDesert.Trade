using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아이템 운송을 담당하는 객체 정보
/// </summary>
[PrimaryKey("ServerNo", "DelivererNo")]
[Table("TblItemDeliverer", Schema = "PaGamePrivate")]
public class TblItemDeliverer
{
  /// <summary>
  ///   등록 일시
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   운송 객체 고유 번호
  /// </summary>
  [Key]
  [Column("_delivererNo")]
  public long DelivererNo { get; set; }

  /// <summary>
  ///   현재 좌표(x)
  /// </summary>
  [Column("_positionX")]
  public long PositionX { get; set; }

  /// <summary>
  ///   현재 좌표(y)
  /// </summary>
  [Column("_positionY")]
  public long PositionY { get; set; }

  /// <summary>
  ///   현재 좌표(z)
  /// </summary>
  [Column("_positionZ")]
  public long PositionZ { get; set; }

  /// <summary>
  ///   목적지 웨이포인트 키
  /// </summary>
  [Column("_destinationKey")]
  public long? DestinationKey { get; set; }

  /// <summary>
  ///   목적지 웨이포인트 이름
  /// </summary>
  [Column("_destination")]
  [StringLength(100)]
  public string? Destination { get; set; }

  /// <summary>
  ///   갱신 시간
  /// </summary>
  [Column("_updateTime", TypeName = "datetime")]
  public DateTime? UpdateTime { get; set; }
}