using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   자판기 정보
/// </summary>
[PrimaryKey("VendorCharacterKey", "VendingIndex")]
[Table("TblFixedVendingMachine", Schema = "PaGamePrivate")]
public class TblFixedVendingMachine
{
  /// <summary>
  ///   해당지역 자판기_위탁판매기 번호
  /// </summary>
  [Key]
  [Column("_vendorCharacterKey")]
  public int VendorCharacterKey { get; set; }

  /// <summary>
  ///   자판기 내부 물건 구분
  /// </summary>
  [Key]
  [Column("_vendingIndex")]
  public short VendingIndex { get; set; }

  /// <summary>
  ///   아이템키
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   강화레벨
  /// </summary>
  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  /// <summary>
  ///   스택여부
  /// </summary>
  [Column("_isStackable")]
  public bool IsStackable { get; set; }

  /// <summary>
  ///   갯수
  /// </summary>
  [Column("_count")]
  public long Count { get; set; }

  /// <summary>
  ///   구매가격
  /// </summary>
  [Column("_buyFromUserPrice")]
  public long BuyFromUserPrice { get; set; }

  /// <summary>
  ///   판매가격
  /// </summary>
  [Column("_sellToUserPrice")]
  public long SellToUserPrice { get; set; }

  /// <summary>
  ///   최대 스택갯수
  /// </summary>
  [Column("_maxStackCount")]
  public long MaxStackCount { get; set; }
}