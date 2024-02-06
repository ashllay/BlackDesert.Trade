using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아이템 운송 정보
/// </summary>
[Table("TblDeliveryRepository", Schema = "PaGamePrivate")]
public class TblDeliveryRepository
{
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   유저 고유 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   운송 상태
  /// </summary>
  [Column("_progress")]
  public byte Progress { get; set; }

  /// <summary>
  ///   출발 지역 번호
  /// </summary>
  [Column("_from")]
  public int From { get; set; }

  /// <summary>
  ///   도착 지역 번호
  /// </summary>
  [Column("_to")]
  public int To { get; set; }

  /// <summary>
  ///   운송하는 객체 번호
  /// </summary>
  [Column("_delivererNo")]
  public long? DelivererNo { get; set; }

  /// <summary>
  ///   운송하는 객체 타입
  /// </summary>
  [Column("_delivererType")]
  public byte DelivererType { get; set; }

  /// <summary>
  ///   운송 노선 번호
  /// </summary>
  [Column("_deliveryRoute")]
  public int DeliveryRoute { get; set; }

  /// <summary>
  ///   아이템 번호
  /// </summary>
  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}