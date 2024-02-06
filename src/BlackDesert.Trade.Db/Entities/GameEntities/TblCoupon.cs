using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   쿠폰 테이블
/// </summary>
[PrimaryKey("UserNo", "CouponNo")]
[Table("TblCoupon", Schema = "PaGamePrivate")]
public class TblCoupon
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   쿠폰번호
  /// </summary>
  [Key]
  [Column("_couponNo")]
  public long CouponNo { get; set; }

  /// <summary>
  ///   쿠폰키
  /// </summary>
  [Column("_couponKey")]
  public int CouponKey { get; set; }

  /// <summary>
  ///   쿠폰 만료 일시
  /// </summary>
  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime ExpirationDate { get; set; }

  /// <summary>
  ///   쿠폰 사용 일시
  /// </summary>
  [Column("_useDate", TypeName = "datetime")]
  public DateTime? UseDate { get; set; }

  /// <summary>
  ///   쿠폰 상태
  /// </summary>
  [Column("_state")]
  public byte State { get; set; }
}