using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblAuctionBidderVer2_GuildHouse_bak", Schema = "PaOperationPrivate")]
public class TblAuctionBidderVer2GuildHouseBak
{
  [Column("_backupDate", TypeName = "datetime")]
  public DateTime? BackupDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_auctionGoodsNo")]
  public long? AuctionGoodsNo { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_auctionKey")]
  public int? AuctionKey { get; set; }

  [Column("_bidPrice")]
  public long? BidPrice { get; set; }

  [Column("_successBidder")]
  public long? SuccessBidder { get; set; }

  [Column("_bidPriceOwnerNo")]
  public long? BidPriceOwnerNo { get; set; }

  [Column("_bidCount")]
  public byte? BidCount { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }
}