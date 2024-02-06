using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   집이 기간 만료 후 남아있는 위탁판매기의 위탁판매물 임시저장소(0408안씀)
/// </summary>
[Keyless]
[Table("TblInstallationTempRealItemList", Schema = "PaGamePrivate")]
public class TblInstallationTempRealItemList
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

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
  ///   _townRegionKey
  /// </summary>
  [Column("_townRegionKey")]
  public int TownRegionKey { get; set; }
}