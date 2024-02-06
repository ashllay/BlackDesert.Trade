using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   쿨타임을 저장하기 위한 테이블
/// </summary>
[Keyless]
[Table("TblCoolTime", Schema = "PaGamePrivate")]
public class TblCoolTime
{
  /// <summary>
  ///   pc 스킬의 쿨타임인지 길드 스킬의 쿨타임인지 구분하는 타입 ( 0 = PC, 1= guild)
  /// </summary>
  [Column("_skillType")]
  public byte SkillType { get; set; }

  /// <summary>
  ///   skillType 에 따라 캐릭터No, 길드 No로 사용된다.
  /// </summary>
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   재사용 대기중인 스킬의 넘버
  /// </summary>
  [Column("_skillNo")]
  public int SkillNo { get; set; }

  /// <summary>
  ///   재사용 대기중인 스킬의 레벨
  /// </summary>
  [Column("_skillLevel")]
  public int SkillLevel { get; set; }

  /// <summary>
  ///   재사용그룹의 넘버
  /// </summary>
  [Column("_reuseGroup")]
  public int ReuseGroup { get; set; }

  [Column("_isExpiredTime")]
  public bool IsExpiredTime { get; set; }

  [Column("_remainOrExpiredtime")]
  public long RemainOrExpiredtime { get; set; }
}