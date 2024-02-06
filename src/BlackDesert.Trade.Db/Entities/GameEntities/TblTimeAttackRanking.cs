using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   타임어택 TOP 랭킹
/// </summary>
[PrimaryKey("Type", "OwnerNo", "MonsterNo")]
[Table("TblTimeAttackRanking", Schema = "PaGamePrivate")]
public class TblTimeAttackRanking
{
  /// <summary>
  ///   타입
  /// </summary>
  [Key]
  [Column("_type")]
  public int Type { get; set; }

  /// <summary>
  ///   타임어택 소유주
  /// </summary>
  [Key]
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   몬스터
  /// </summary>
  [Key]
  [Column("_monsterNo")]
  public int MonsterNo { get; set; }

  /// <summary>
  ///   완료 시간
  /// </summary>
  [Column("_completeTime")]
  public long CompleteTime { get; set; }
}