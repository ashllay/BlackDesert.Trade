using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblItemRental", Schema = "PaGamePrivate")]
public class TblItemRental
{
  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Column("_isSealed")]
  public bool IsSealed { get; set; }

  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }
}