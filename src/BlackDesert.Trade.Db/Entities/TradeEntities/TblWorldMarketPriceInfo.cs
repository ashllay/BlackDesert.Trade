using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Keyless]
[Table("TblWorldMarketPriceInfo", Schema = "PaGamePrivate")]
public class TblWorldMarketPriceInfo
{
  [Column("_registTimeStamp")]
  public long RegistTimeStamp { get; set; }

  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_price")]
  public long Price { get; set; }
}