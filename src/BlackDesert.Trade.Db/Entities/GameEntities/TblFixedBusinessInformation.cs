using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   자판기_위탁판매
/// </summary>
[PrimaryKey("VendorCharacterKey", "OwnerUserNo")]
[Table("TblFixedBusinessInformation", Schema = "PaGamePrivate")]
public class TblFixedBusinessInformation
{
  /// <summary>
  ///   주인
  /// </summary>
  [Key]
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  /// <summary>
  ///   해당지역 자판기_위탁판매기 번호
  /// </summary>
  [Key]
  [Column("_vendorCharacterKey")]
  public int VendorCharacterKey { get; set; }

  /// <summary>
  ///   기간이 만료되어 아이템돌려줄때 사용
  /// </summary>
  [Column("_townRegionKey")]
  public int TownRegionKey { get; set; }

  /// <summary>
  ///   0자동판매1위탁판매
  /// </summary>
  [Column("_businessType")]
  public int BusinessType { get; set; }

  /// <summary>
  ///   판매기간(위탁판매시)
  /// </summary>
  [Column("_saleTime")]
  public long SaleTime { get; set; }

  /// <summary>
  ///   판매수수료(위탁판매시)
  /// </summary>
  [Column("_commissionRate")]
  public double CommissionRate { get; set; }

  /// <summary>
  ///   최소등록비(위탁판매시)
  /// </summary>
  [Column("_minRegisterMoney")]
  public long MinRegisterMoney { get; set; }

  /// <summary>
  ///   보유금액
  /// </summary>
  [Column("_holdingMoney")]
  public long HoldingMoney { get; set; }

  /// <summary>
  ///   액티브여부
  /// </summary>
  [Column("_isActive")]
  public bool IsActive { get; set; }
}