using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBarterUserInfo", Schema = "PaGamePrivate")]
public class TblBarterUserInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_barterSeed")]
  public long BarterSeed { get; set; }

  [Column("_barterStack")]
  public int BarterStack { get; set; }

  [Column("_nextUpdateDate", TypeName = "datetime")]
  public DateTime? NextUpdateDate { get; set; }

  [Column("_totalExchangeCount")]
  public int TotalExchangeCount { get; set; }

  [Column("_exchangeCountForTime")]
  public int ExchangeCountForTime { get; set; }

  [Column("_lastExchangeCount")]
  public int LastExchangeCount { get; set; }

  [Column("_useItemTime", TypeName = "datetime")]
  public DateTime UseItemTime { get; set; }

  [Column("_useAddCountItemTime", TypeName = "datetime")]
  public DateTime UseAddCountItemTime { get; set; }

  [Column("_changeSeedCountForDay")]
  public int ChangeSeedCountForDay { get; set; }

  [Column("_lastResetTime", TypeName = "datetime")]
  public DateTime LastResetTime { get; set; }

  [Column("_normalSeedChangeCountForDay")]
  public int NormalSeedChangeCountForDay { get; set; }

  [Column("_materialSeedChangeCountForDay")]
  public int MaterialSeedChangeCountForDay { get; set; }

  [Column("_barterType")]
  public byte BarterType { get; set; }
}