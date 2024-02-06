using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   고용되어 사용중인 Npc
/// </summary>
[Table("TblUsingHiredNpc", Schema = "PaGamePrivate")]
public class TblUsingHiredNpc
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   소유 캐릭터번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   액터키
  /// </summary>
  [Key]
  [Column("_actorKey")]
  public long ActorKey { get; set; }

  /// <summary>
  ///   캐릭터키
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   만료일
  /// </summary>
  [Column("_expiredTime", TypeName = "datetime")]
  public DateTime ExpiredTime { get; set; }
}