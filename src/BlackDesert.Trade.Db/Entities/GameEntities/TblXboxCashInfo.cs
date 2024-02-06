using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   캐쉬정보
/// </summary>
[PrimaryKey("AccountNo", "LegacyProductId")]
[Table("TblXBoxCashInfo", Schema = "PaGamePrivate")]
public class TblXboxCashInfo
{
  /// <summary>
  ///   생성일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   계정 번호
  /// </summary>
  [Key]
  [Column("_accountNo")]
  [StringLength(30)]
  public string AccountNo { get; set; } = null!;

  /// <summary>
  ///   xbox 에서 구매한 상품 개수 (누적 수량, remarks 참고)
  /// </summary>
  [Column("_productCount")]
  public long ProductCount { get; set; }

  /// <summary>
  ///   사용한 상품 개수 (누적 수량, remarks 참고)
  /// </summary>
  [Column("_consumeCount")]
  public long ConsumeCount { get; set; }

  /// <summary>
  ///   상품 넘버
  /// </summary>
  [Key]
  [Column("_legacyProductId")]
  [StringLength(40)]
  public string LegacyProductId { get; set; } = null!;
}