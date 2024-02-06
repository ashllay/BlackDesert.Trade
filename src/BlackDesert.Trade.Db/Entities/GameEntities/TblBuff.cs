using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   버프를 저장하기 위한 테이블
/// </summary>
[Keyless]
[Table("TblBuff", Schema = "PaGamePrivate")]
public class TblBuff
{
  /// <summary>
  ///   버프가 적용되는 캐릭터의 번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   서버에서 사용하는 버프키
  /// </summary>
  [Column("_buffKey")]
  public int BuffKey { get; set; }

  /// <summary>
  ///   버프의 남은 시간
  /// </summary>
  [Column("_remainTime")]
  public long RemainTime { get; set; }

  /// <summary>
  ///   버프의 남은 적용 횟수
  /// </summary>
  [Column("_leftApplyingCount")]
  public int? LeftApplyingCount { get; set; }
}