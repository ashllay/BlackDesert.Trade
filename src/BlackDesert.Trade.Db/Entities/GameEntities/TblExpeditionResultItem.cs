using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   토벌결과아이템
/// </summary>
[PrimaryKey("UserNo", "ItemEnchantKey")]
[Table("TblExpeditionResultItem", Schema = "PaGamePrivate")]
public class TblExpeditionResultItem
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   아이템키
  /// </summary>
  [Key]
  [Column("_itemEnchantKey")]
  public int ItemEnchantKey { get; set; }

  /// <summary>
  ///   아이템 갯수
  /// </summary>
  [Column("_itemCount")]
  public long ItemCount { get; set; }

  /// <summary>
  ///   등록된 시간
  /// </summary>
  [Column("_registerDateDate", TypeName = "datetime")]
  public DateTime RegisterDateDate { get; set; }
}