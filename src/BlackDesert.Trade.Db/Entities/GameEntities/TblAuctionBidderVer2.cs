using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   경매 입찰 테이블
/// </summary>
[PrimaryKey("UserNo", "AuctionKey", "AuctionGoodsNo")]
[Table("TblAuctionBidderVer2", Schema = "PaGamePrivate")]
public class TblAuctionBidderVer2
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
  ///   입찰자 유져 번호(입찰 완료)
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   입찰자 유져 번호(입찰 완료)
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   경매장 번호
  /// </summary>
  [Key]
  [Column("_auctionKey")]
  public int AuctionKey { get; set; }

  /// <summary>
  ///   입찰가
  /// </summary>
  [Column("_bidPrice")]
  public long BidPrice { get; set; }

  /// <summary>
  ///   낙찰자(-1 입찰중,돈찾아가면 삭제)
  /// </summary>
  [Column("_successBidder")]
  public long SuccessBidder { get; set; }

  [Column("_bidPriceOwnerNo")]
  public long BidPriceOwnerNo { get; set; }

  [Column("_bidCount")]
  public byte BidCount { get; set; }

  /// <summary>
  ///   삭제일
  /// </summary>
  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }
}