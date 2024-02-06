using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아이템 구매 갯수 저장
/// </summary>
[PrimaryKey("IsUserNo", "UserCharacterNo", "CashProductNo", "Type")]
[Table("TblCashItemBuyCount", Schema = "PaGamePrivate")]
public class TblCashItemBuyCount
{
  /// <summary>
  ///   유저번호인가?
  /// </summary>
  [Key]
  [Column("_isUserNo")]
  public bool IsUserNo { get; set; }

  /// <summary>
  ///   유저번호&amp;캐릭터번호(_isUserNo가 참이면 유저번호임)
  /// </summary>
  [Key]
  [Column("_userCharacterNo")]
  public long UserCharacterNo { get; set; }

  /// <summary>
  ///   캐시상품키
  /// </summary>
  [Key]
  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  /// <summary>
  ///   구매량
  /// </summary>
  [Column("_count")]
  public int Count { get; set; }

  [Column("_resetTime")]
  public long ResetTime { get; set; }

  [Key]
  [Column("_type")]
  public bool Type { get; set; }
}