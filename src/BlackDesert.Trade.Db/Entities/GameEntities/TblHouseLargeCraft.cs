using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   집의 대량생산기능을 위한 데이터 목록
/// </summary>
[PrimaryKey("UserNo", "HouseKey")]
[Table("TblHouseLargeCraft", Schema = "PaGamePrivate")]
public class TblHouseLargeCraft
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   _houseKey
  /// </summary>
  [Key]
  [Column("_houseKey")]
  public int HouseKey { get; set; }

  /// <summary>
  ///   집 대량생산 키
  /// </summary>
  [Column("_largeExchangeKey")]
  public int LargeExchangeKey { get; set; }

  /// <summary>
  ///   대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
  /// </summary>
  [Column("_completePoint0")]
  public long CompletePoint0 { get; set; }

  /// <summary>
  ///   대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
  /// </summary>
  [Column("_completePoint1")]
  public long CompletePoint1 { get; set; }

  /// <summary>
  ///   대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
  /// </summary>
  [Column("_completePoint2")]
  public long CompletePoint2 { get; set; }

  /// <summary>
  ///   대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
  /// </summary>
  [Column("_completePoint3")]
  public long CompletePoint3 { get; set; }

  /// <summary>
  ///   대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
  /// </summary>
  [Column("_completePoint4")]
  public long CompletePoint4 { get; set; }

  /// <summary>
  ///   대량생산을 완료하기위해 남은 수량 ex) 1 : 1개더만들면 해당재료는 완료
  /// </summary>
  [Column("_completePoint5")]
  public long CompletePoint5 { get; set; }
}