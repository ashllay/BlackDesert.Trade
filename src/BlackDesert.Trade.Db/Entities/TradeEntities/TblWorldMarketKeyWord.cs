using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Table("TblWorldMarketKeyWord", Schema = "PaGamePrivate")]
public class TblWorldMarketKeyWord
{
  [Key]
  [Column("_keyWordNo")]
  public long KeyWordNo { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_searchKeyWord")]
  [StringLength(30)]
  public string SearchKeyWord { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}