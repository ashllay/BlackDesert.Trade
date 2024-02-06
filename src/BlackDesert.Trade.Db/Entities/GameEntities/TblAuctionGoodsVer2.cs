using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   경매 판매 테이블(팝니다)
/// </summary>
[Table("TblAuctionGoodsVer2", Schema = "PaGamePrivate")]
public class TblAuctionGoodsVer2
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
  ///   판매자 유져 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   판매자 캐릭터 번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   경매 종료 시간( 1분 이하 일 때 입찰되면 시간 증가 남은 최대시간을 초과할 수는 없다.)
  /// </summary>
  [Column("_expireTime")]
  public long ExpireTime { get; set; }

  /// <summary>
  ///   경매 종료 최대 시간
  /// </summary>
  [Column("_expireLimitTime")]
  public long ExpireLimitTime { get; set; }

  /// <summary>
  ///   최소 입찰가격
  /// </summary>
  [Column("_minPrice")]
  public long MinPrice { get; set; }

  /// <summary>
  ///   즉시 구매가
  /// </summary>
  [Column("_maxPrice")]
  public long MaxPrice { get; set; }

  /// <summary>
  ///   상품 종류
  /// </summary>
  [Column("_goodsType")]
  public int GoodsType { get; set; }

  /// <summary>
  ///   상품 키
  /// </summary>
  [Column("_goodsKey")]
  public long GoodsKey { get; set; }

  /// <summary>
  ///   상품 갯수
  /// </summary>
  [Column("_goodsCount")]
  public long GoodsCount { get; set; }

  /// <summary>
  ///   낙찰자 TUserNo (입찰진행중 -1 낙찰자가 찾아가면 0)
  /// </summary>
  [Column("_successBidder")]
  public long SuccessBidder { get; set; }

  /// <summary>
  ///   낙찰가
  /// </summary>
  [Column("_successBidPrice")]
  public long SuccessBidPrice { get; set; }

  /// <summary>
  ///   경매종료(경매종료 1)
  /// </summary>
  [Column("_isAuctionEnd")]
  public bool IsAuctionEnd { get; set; }

  /// <summary>
  ///   입찰(구매) 제한
  /// </summary>
  [Column("_transferType")]
  public byte TransferType { get; set; }

  /// <summary>
  ///   입찰(구매) 제한
  /// </summary>
  [Column("_transferNo")]
  public long TransferNo { get; set; }
}