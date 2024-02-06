using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   위탁 판매 정보
/// </summary>
[Table("TblConsignmentSale", Schema = "PaGamePrivate")]
public class TblConsignmentSale
{
  /// <summary>
  ///   _consignmentNo
  /// </summary>
  [Key]
  [Column("_consignmentNo")]
  public long ConsignmentNo { get; set; }

  /// <summary>
  ///   _householdNo
  /// </summary>
  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  /// <summary>
  ///   _installationNo
  /// </summary>
  [Column("_installationNo")]
  public long InstallationNo { get; set; }

  /// <summary>
  ///   _itemNo
  /// </summary>
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   _itemKey
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   _isStackable
  /// </summary>
  [Column("_isStackable")]
  public bool IsStackable { get; set; }

  /// <summary>
  ///   _ownerCharacterNo
  /// </summary>
  [Column("_ownerCharacterNo")]
  public long OwnerCharacterNo { get; set; }

  /// <summary>
  ///   등록비
  /// </summary>
  [Column("_registerMoney")]
  public long RegisterMoney { get; set; }

  /// <summary>
  ///   개당 가격
  /// </summary>
  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  /// <summary>
  ///   판매후 모아진 돈(수수료 뺀 금액)
  /// </summary>
  [Column("_gatherMoney")]
  public long GatherMoney { get; set; }

  /// <summary>
  ///   수수료(등록시 저장)
  /// </summary>
  [Column("_commissionRate")]
  public double CommissionRate { get; set; }

  /// <summary>
  ///   판매 종료일
  /// </summary>
  [Column("_expireTime")]
  public long ExpireTime { get; set; }

  /// <summary>
  ///   아이템이 모두팔리면 1
  /// </summary>
  [Column("_saleEnd")]
  public bool SaleEnd { get; set; }
}