using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   창고 확장 슬롯 수 저장
/// </summary>
[PrimaryKey("UserNo", "RegionKey")]
[Table("TblWarehouseSlotCount", Schema = "PaGamePrivate")]
public class TblWarehouseSlotCount
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   지역키
  /// </summary>
  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  /// <summary>
  ///   슬롯 추가 갯수(아이템 사용)
  /// </summary>
  [Column("_slotCount")]
  public byte SlotCount { get; set; }
}