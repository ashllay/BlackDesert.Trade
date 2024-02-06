using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   집이 기간 만료 후 남아있는 자판기 및 위탁판매용 아이템 임시 저장소
/// </summary>
[Keyless]
[Table("TblVendorTempVirtualItemList", Schema = "PaGamePrivate")]
public class TblVendorTempVirtualItemList
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

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
  ///   수량
  /// </summary>
  [Column("_count")]
  public long Count { get; set; }

  /// <summary>
  ///   스택여부
  /// </summary>
  [Column("_isStackable")]
  public bool IsStackable { get; set; }

  /// <summary>
  ///   지역키
  /// </summary>
  [Column("_townRegionKey")]
  public int TownRegionKey { get; set; }
}