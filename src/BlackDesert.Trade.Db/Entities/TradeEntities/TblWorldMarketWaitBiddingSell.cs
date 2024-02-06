using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Keyless]
[Table("TblWorldMarketWaitBiddingSell", Schema = "PaGamePrivate")]
public class TblWorldMarketWaitBiddingSell
{
  [Column("_waitNo")]
  public long WaitNo { get; set; }

  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_isSealed")]
  public bool IsSealed { get; set; }

  [Column("_chooseSubKey")]
  public int ChooseSubKey { get; set; }

  [Column("_leftCount")]
  public long LeftCount { get; set; }

  [Column("_pricePerOne")]
  public long PricePerOne { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_isRingBuff")]
  public bool IsRingBuff { get; set; }

  [Column("_usedType")]
  public byte UsedType { get; set; }
}