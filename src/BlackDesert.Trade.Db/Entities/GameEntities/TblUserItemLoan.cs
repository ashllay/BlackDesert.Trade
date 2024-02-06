using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저의 아이템 반납 정보
/// </summary>
[PrimaryKey("UserNo", "ItemKey", "EnchantLevel")]
[Table("TblUserItemLoan", Schema = "PaGamePrivate")]
public class TblUserItemLoan
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   아이템 키
  /// </summary>
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   인챈트 레벨
  /// </summary>
  [Key]
  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  /// <summary>
  ///   개수
  /// </summary>
  [Column("_count")]
  public long Count { get; set; }

  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}