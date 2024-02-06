using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblItemRestoreWaiting", Schema = "PaOperationPublic")]
public class TblItemRestoreWaiting
{
  [Column("_restoreNo")]
  public long RestoreNo { get; set; }

  [Column("_requestUserNo")]
  public long RequestUserNo { get; set; }

  [Column("_confirmUserNo")]
  public long? ConfirmUserNo { get; set; }

  [Column("_restoreRegDate", TypeName = "datetime")]
  public DateTime RestoreRegDate { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Required]
  [Column("_isValid")]
  public bool? IsValid { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_productionRegionKey")]
  public int ProductionRegionKey { get; set; }

  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Column("_isVested")]
  public bool IsVested { get; set; }

  [Column("_isSeized")]
  public bool IsSeized { get; set; }

  [Required]
  [Column("_isSealed")]
  public bool? IsSealed { get; set; }

  [Column("_buyingPrice")]
  public long BuyingPrice { get; set; }

  [Column("_itemWhereType")]
  public byte ItemWhereType { get; set; }

  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  [Column("_variousNo")]
  public long VariousNo { get; set; }

  [Column("_variableDate", TypeName = "datetime")]
  public DateTime VariableDate { get; set; }

  [Column("_pushedItemKey0")]
  public int? PushedItemKey0 { get; set; }

  [Column("_pushedItemKey1")]
  public int? PushedItemKey1 { get; set; }

  [Column("_pushedItemKey2")]
  public int? PushedItemKey2 { get; set; }

  [Column("_pushedItemKey3")]
  public int? PushedItemKey3 { get; set; }

  [Column("_pushedItemKey4")]
  public int? PushedItemKey4 { get; set; }

  [Column("_pushedItemKey5")]
  public int? PushedItemKey5 { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_endurance")]
  public int Endurance { get; set; }

  [Column("_maxEndurance")]
  public int MaxEndurance { get; set; }

  [Column("_dyeingList")]
  [MaxLength(24)]
  public byte[]? DyeingList { get; set; }

  [Column("_isExpirationDyeing")]
  public bool IsExpirationDyeing { get; set; }

  [Column("_confirmWaitingDate", TypeName = "datetime")]
  public DateTime? ConfirmWaitingDate { get; set; }

  [Column("_isSended")]
  public bool? IsSended { get; set; }

  [Column("_memo")]
  [StringLength(1000)]
  public string? Memo { get; set; }
}