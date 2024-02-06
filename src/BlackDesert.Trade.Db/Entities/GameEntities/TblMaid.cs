using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   메이드
/// </summary>
[Table("TblMaid", Schema = "PaGamePrivate")]
public class TblMaid
{
  /// <summary>
  ///   소유 사용자 번호
  /// </summary>
  [Column("_ownerUserNo")]
  public long OwnerUserNo { get; set; }

  /// <summary>
  ///   메이드 고유번호
  /// </summary>
  [Key]
  [Column("_maidNo")]
  public long MaidNo { get; set; }

  /// <summary>
  ///   메이드 식별자
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   재사용 가능시간
  /// </summary>
  [Column("_reuseTime", TypeName = "datetime")]
  public DateTime ReuseTime { get; set; }
}