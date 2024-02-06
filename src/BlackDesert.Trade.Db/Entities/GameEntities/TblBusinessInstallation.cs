using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   하우징 설치오브젝트 사업정보
/// </summary>
[Table("TblBusinessInstallation", Schema = "PaGamePrivate")]
public class TblBusinessInstallation
{
  /// <summary>
  ///   설치 오브젝트 번호
  /// </summary>
  [Key]
  [Column("_installationNo")]
  public long InstallationNo { get; set; }

  /// <summary>
  ///   집 번호
  /// </summary>
  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  /// <summary>
  ///   0자동판매1위탁판매
  /// </summary>
  [Column("_businessType")]
  public int BusinessType { get; set; }

  /// <summary>
  ///   판매기간
  /// </summary>
  [Column("_saleTime")]
  public long SaleTime { get; set; }

  /// <summary>
  ///   판매수수료
  /// </summary>
  [Column("_commissionRate")]
  public double CommissionRate { get; set; }

  /// <summary>
  ///   최소등록비
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