using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아이템&amp;돈 저장소
/// </summary>
[Table("TblItemRepository", Schema = "PaGamePrivate")]
[Microsoft.EntityFrameworkCore.Index("OwnerNo", "ItemWhereType", "VariousNo", "VariableDate", Name = "IxTblItemRepository_itemKey_ownerNo_itemWhereType_variousNo_variableDate")]
[Microsoft.EntityFrameworkCore.Index("ItemWhereType", Name = "IxTblItemRepository_itemWhereType")]
[Microsoft.EntityFrameworkCore.Index("OwnerNo", "ItemNo", "ItemWhereType", "VariousNo", Name = "IxTblItemRepository_ownerNo_itemNo_itemWhereType_variousNo")]
[Microsoft.EntityFrameworkCore.Index("VariousNo", "OwnerNo", Name = "IxTblItemRepository_variousNo_ownerNo")]
public class TblItemRepository
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   참인 경우에만 정상적인 아이템임
  /// </summary>
  [Required]
  [Column("_isValid")]
  public bool? IsValid { get; set; }

  /// <summary>
  ///   아이템 고유번호
  /// </summary>
  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   _itemKey
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   최초로 만들어진/생산되어진 지역번호
  /// </summary>
  [Column("_productionRegionKey")]
  public int ProductionRegionKey { get; set; }

  /// <summary>
  ///   유통기한(NULL이면 무기한임)
  /// </summary>
  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  /// <summary>
  ///   _enchantLevel
  /// </summary>
  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  /// <summary>
  ///   참이면 귀속된 것임
  /// </summary>
  [Column("_isVested")]
  public bool IsVested { get; set; }

  /// <summary>
  ///   참이면 압류임
  /// </summary>
  [Column("_isSeized")]
  public bool IsSeized { get; set; }

  /// <summary>
  ///   참이면 각인된 것임
  /// </summary>
  [Required]
  [Column("_isSealed")]
  public bool? IsSealed { get; set; }

  /// <summary>
  ///   구매가격(무역아이템/경매 에서 의미가 있음)
  /// </summary>
  [Column("_buyingPrice")]
  public long BuyingPrice { get; set; }

  /// <summary>
  ///   아이템위치
  /// </summary>
  [Column("_itemWhereType")]
  public byte ItemWhereType { get; set; }

  /// <summary>
  ///   _itemWhereType에 따라 의미 다름
  /// </summary>
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   _itemWhereType에 따라 의미 다름
  /// </summary>
  [Column("_variousNo")]
  public long VariousNo { get; set; }

  /// <summary>
  ///   _variableDate
  /// </summary>
  [Column("_variableDate", TypeName = "datetime")]
  public DateTime VariableDate { get; set; }

  /// <summary>
  ///   _pushedItemKey0
  /// </summary>
  [Column("_pushedItemKey0")]
  public int? PushedItemKey0 { get; set; }

  /// <summary>
  ///   _pushedItemKey1
  /// </summary>
  [Column("_pushedItemKey1")]
  public int? PushedItemKey1 { get; set; }

  /// <summary>
  ///   _pushedItemKey2
  /// </summary>
  [Column("_pushedItemKey2")]
  public int? PushedItemKey2 { get; set; }

  /// <summary>
  ///   _pushedItemKey3
  /// </summary>
  [Column("_pushedItemKey3")]
  public int? PushedItemKey3 { get; set; }

  /// <summary>
  ///   _pushedItemKey4
  /// </summary>
  [Column("_pushedItemKey4")]
  public int? PushedItemKey4 { get; set; }

  /// <summary>
  ///   _pushedItemKey5
  /// </summary>
  [Column("_pushedItemKey5")]
  public int? PushedItemKey5 { get; set; }

  /// <summary>
  ///   아이템 개수
  /// </summary>
  [Column("_count")]
  public long Count { get; set; }

  /// <summary>
  ///   내구도
  /// </summary>
  [Column("_endurance")]
  public int Endurance { get; set; }

  /// <summary>
  ///   최대 내구도
  /// </summary>
  [Column("_maxEndurance")]
  public int MaxEndurance { get; set; }

  [Column("_dyeingList")]
  [MaxLength(24)]
  public byte[]? DyeingList { get; set; }

  /// <summary>
  ///   true 면 기간제 염색이 적용된 아이템임
  /// </summary>
  [Column("_isExpirationDyeing")]
  public bool IsExpirationDyeing { get; set; }
}