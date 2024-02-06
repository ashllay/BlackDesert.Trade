using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   경매장 정보 ( 집 경매 및 용병 경매를 위함 )
/// </summary>
[Table("TblAuctionInfo", Schema = "PaGamePrivate")]
public class TblAuctionInfo
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   경매장 번호
  /// </summary>
  [Key]
  [Column("_auctionKey")]
  public int AuctionKey { get; set; }

  /// <summary>
  ///   다음 경매 시간
  /// </summary>
  [Column("_nextStartTime")]
  public long NextStartTime { get; set; }
}