using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstallationNo", "VendingIndex")]
[Table("TblVendingMachine", Schema = "PaGamePrivate")]
public class TblVendingMachine
{
  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  [Key]
  [Column("_installationNo")]
  public long InstallationNo { get; set; }

  [Key]
  [Column("_vendingIndex")]
  public short VendingIndex { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Column("_isStackable")]
  public bool IsStackable { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_buyFromUserPrice")]
  public long BuyFromUserPrice { get; set; }

  [Column("_sellToUserPrice")]
  public long SellToUserPrice { get; set; }

  [Column("_maxStackCount")]
  public long MaxStackCount { get; set; }
}