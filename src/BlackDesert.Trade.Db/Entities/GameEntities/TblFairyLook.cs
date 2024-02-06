using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   요정 외형
/// </summary>
[Keyless]
[Table("TblFairyLook", Schema = "PaGamePrivate")]
public class TblFairyLook
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   소유 사용자번호
  /// </summary>
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  /// <summary>
  ///   바꿀외형 번호
  /// </summary>
  [Column("_actionIndex")]
  public int ActionIndex { get; set; }
}