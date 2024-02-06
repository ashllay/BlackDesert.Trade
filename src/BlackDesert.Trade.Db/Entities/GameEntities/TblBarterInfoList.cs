using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "IsSpecial", "RegionKey")]
[Table("TblBarterInfoList", Schema = "PaGamePrivate")]
public class TblBarterInfoList
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  [Column("_fromItemEnchantKey")]
  public int FromItemEnchantKey { get; set; }

  [Column("_fromItemCount")]
  public long FromItemCount { get; set; }

  [Column("_toItemEnchantKey")]
  public int ToItemEnchantKey { get; set; }

  [Column("_toItemCount")]
  public long ToItemCount { get; set; }

  [Column("_currentExchangeCount")]
  public int CurrentExchangeCount { get; set; }

  [Column("_maxExchangeCount")]
  public int MaxExchangeCount { get; set; }

  [Column("_exchangeCountForTime")]
  public int ExchangeCountForTime { get; set; }

  [Key]
  [Column("_isSpecial")]
  public bool IsSpecial { get; set; }

  [Column("_barterSeed")]
  public long? BarterSeed { get; set; }

  [Column("_barterType")]
  public byte BarterType { get; set; }
}