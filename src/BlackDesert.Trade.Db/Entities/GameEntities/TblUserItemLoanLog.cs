using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("RegisterDate", "UserNo", "ItemNo", "ItemKey")]
[Table("TblUserItemLoanLog", Schema = "PaGamePrivate")]
public class TblUserItemLoanLog
{
  [Key]
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_enchantLevel")]
  public byte? EnchantLevel { get; set; }

  [Column("_ownerNo")]
  public long? OwnerNo { get; set; }

  [Column("_itemWhereType")]
  public byte? ItemWhereType { get; set; }

  [Column("_beforeCount")]
  public long? BeforeCount { get; set; }

  [Column("_variedCount")]
  public long? VariedCount { get; set; }
}