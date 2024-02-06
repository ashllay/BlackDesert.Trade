using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   위탁 판매 정보
/// </summary>
[Table("TblFixedConsignmentSale", Schema = "PaGamePrivate")]
public class TblFixedConsignmentSale
{
  /// <summary>
  ///   위탁판매 고유번호
  /// </summary>
  [Key]
  [Column("_consignmentNo")]
  public long ConsignmentNo { get; set; }

  /// <summary>
  ///   해당지역 자판기_위탁판매기 번호
  /// </summary>
  [Column("_vendorCharacterKey")]
  public int VendorCharacterKey { get; set; }

  /// <summary>
  ///   아이템번호
  /// </summary>
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   아이템키
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   스택여부
  /// </summary>
  [Column("_isStackable")]
  public bool IsStackable { get; set; }

  /// <summary>
  ///   소유자캐릭터번호
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
  ///   판매후 모아진 돈
  /// </summary>
  [Column("_gatherMoney")]
  public long GatherMoney { get; set; }

  /// <summary>
  ///   수수료
  /// </summary>
  [Column("_commissionRate")]
  public double CommissionRate { get; set; }

  /// <summary>
  ///   판매종료일
  /// </summary>
  [Column("_expireTime")]
  public long ExpireTime { get; set; }

  /// <summary>
  ///   아이템이 모두 팔리면 1
  /// </summary>
  [Column("_saleEnd")]
  public bool SaleEnd { get; set; }
}