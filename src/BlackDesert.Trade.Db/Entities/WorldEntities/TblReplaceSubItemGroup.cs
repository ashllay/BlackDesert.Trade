using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   변경할 드랍그룹(일본용)
/// </summary>
[Table("TblReplaceSubItemGroup", Schema = "PaGamePrivate")]
public class TblReplaceSubItemGroup
{
  /// <summary>
  ///   아이템드랍엑셀의 서브그룹키(ItemSubGroup_Table)
  /// </summary>
  [Key]
  [Column("_itemSubGroupKey")]
  public int ItemSubGroupKey { get; set; }

  /// <summary>
  ///   아이템목록
  /// </summary>
  [Column("_itemList")]
  [StringLength(2000)]
  [Unicode(false)]
  public string ItemList { get; set; } = null!;
}