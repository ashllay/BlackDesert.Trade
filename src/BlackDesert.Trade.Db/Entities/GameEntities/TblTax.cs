using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   세금정보
/// </summary>
[PrimaryKey("RegionKey", "TaxType")]
[Table("TblTax", Schema = "PaGamePrivate")]
public class TblTax
{
  /// <summary>
  ///   점령일시
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _regionKey
  /// </summary>
  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  /// <summary>
  ///   _taxType
  /// </summary>
  [Key]
  [Column("_taxType")]
  public byte TaxType { get; set; }

  /// <summary>
  ///   현재 세율
  /// </summary>
  [Column("_taxRate")]
  public int TaxRate { get; set; }

  /// <summary>
  ///   지방세(해당지역의 세금합)
  /// </summary>
  [Column("_producedAmount")]
  public long ProducedAmount { get; set; }

  /// <summary>
  ///   주민세(소속지역주민들의 세금합)
  /// </summary>
  [Column("_affiliatedAmount")]
  public long AffiliatedAmount { get; set; }
}