using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("MainKey", "SubKey", "UserNo", "IsSealed", "KeyType")]
[Table("TblWorldMarketBiddingSell", Schema = "PaGamePrivate")]
public class TblWorldMarketBiddingSell
{
  [Column("_sellNo")]
  public long SellNo { get; set; }

  [Key]
  [Column("_keyType")]
  public int KeyType { get; set; }

  [Key]
  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Key]
  [Column("_subKey")]
  public int SubKey { get; set; }

  [Key]
  [Column("_isSealed")]
  public bool IsSealed { get; set; }

  [Column("_chooseSubKey")]
  public int ChooseSubKey { get; set; }

  [Column("_needMaterialCount")]
  public long NeedMaterialCount { get; set; }

  [Column("_leftCount")]
  public long LeftCount { get; set; }

  [Column("_soldCount")]
  public long SoldCount { get; set; }

  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  [Column("_accumulateMoneyCount")]
  public long AccumulateMoneyCount { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_isRingBuff")]
  public bool IsRingBuff { get; set; }
}