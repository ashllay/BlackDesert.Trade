using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("MainKey", "SubKey", "KeyType", "UserNo")]
[Table("TblWorldMarketBiddingBuy", Schema = "PaGamePrivate")]
public class TblWorldMarketBiddingBuy
{
  [Column("_buyNo")]
  public long BuyNo { get; set; }

  [Key]
  [Column("_keyType")]
  public int KeyType { get; set; }

  [Key]
  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Key]
  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_chooseSubKey")]
  public int ChooseSubKey { get; set; }

  [Column("_needMaterialCount")]
  public long NeedMaterialCount { get; set; }

  [Column("_leftCount")]
  public long LeftCount { get; set; }

  [Column("_boughtCount")]
  public long BoughtCount { get; set; }

  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  [Column("_addEnchantPrice")]
  public long AddEnchantPrice { get; set; }

  [Column("_registerMoneyCount")]
  public long RegisterMoneyCount { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_isCashCategory")]
  public bool IsCashCategory { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}