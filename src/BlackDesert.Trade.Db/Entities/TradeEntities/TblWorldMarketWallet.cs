using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("UserNo",
            "ServerNo",
            "NationCode",
            "KeyType",
            "MainKey",
            "SubKey",
            "IsSealed")]
[Table("TblWorldMarketWallet", Schema = "PaGamePrivate")]
public class TblWorldMarketWallet
{
  [Key]
  [Column("_nationCode")]
  public int NationCode { get; set; } = 0;

  [Key]
  [Column("_serverNo")]
  public int ServerNo { get; set; } = 0;

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

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

  [Column("_count")]
  public long Count { get; set; }
}