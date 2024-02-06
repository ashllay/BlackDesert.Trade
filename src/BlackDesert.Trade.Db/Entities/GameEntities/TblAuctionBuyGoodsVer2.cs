using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   경매 구매 테이블(삽니다)
/// </summary>
[Table("TblAuctionBuyGoodsVer2", Schema = "PaGamePrivate")]
public class TblAuctionBuyGoodsVer2
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   경매상품 번호
  /// </summary>
  [Key]
  [Column("_auctionGoodsNo")]
  public long AuctionGoodsNo { get; set; }

  /// <summary>
  ///   경매장 번호
  /// </summary>
  [Column("_auctionKey")]
  public int AuctionKey { get; set; }

  /// <summary>
  ///   매입자
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   매입자
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   구매할 아이템 키
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   구매할 아이템 갯수
  /// </summary>
  [Column("_totalItemCount")]
  public long TotalItemCount { get; set; }

  /// <summary>
  ///   구매한 아이템 갯수
  /// </summary>
  [Column("_currentItemCount")]
  public long CurrentItemCount { get; set; }

  /// <summary>
  ///   개당 아이템 갯수
  /// </summary>
  [Column("_itemPrice")]
  public long ItemPrice { get; set; }

  /// <summary>
  ///   보증금
  /// </summary>
  [Column("_deposit")]
  public long Deposit { get; set; }

  /// <summary>
  ///   구매 종료 시간
  /// </summary>
  [Column("_expireTime")]
  public long ExpireTime { get; set; }

  /// <summary>
  ///   경매종료(경매종료 1)
  /// </summary>
  [Column("_isAuctionEnd")]
  public bool IsAuctionEnd { get; set; }
}