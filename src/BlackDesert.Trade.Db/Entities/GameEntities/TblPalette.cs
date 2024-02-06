using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   팔레트
/// </summary>
[PrimaryKey("OwnerNo", "ItemKey")]
[Table("TblPalette", Schema = "PaGamePrivate")]
public class TblPalette
{
  /// <summary>
  ///   소유자번호
  /// </summary>
  [Key]
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   아이템키
  /// </summary>
  [Key]
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_paletteType")]
  public byte PaletteType { get; set; }

  /// <summary>
  ///   수량
  /// </summary>
  [Column("_count")]
  public long Count { get; set; }
}