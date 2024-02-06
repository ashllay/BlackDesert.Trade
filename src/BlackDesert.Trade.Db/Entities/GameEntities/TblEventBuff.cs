using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   이벤트 버프를 저장하기 위한 테이블
/// </summary>
[PrimaryKey("ServerNo", "BuffType")]
[Table("TblEventBuff", Schema = "PaGamePrivate")]
public class TblEventBuff
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   서버 번호
  /// </summary>
  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   버프 타입
  /// </summary>
  [Key]
  [Column("_buffType")]
  public short BuffType { get; set; }

  /// <summary>
  ///   버프의 퍼센트
  /// </summary>
  [Column("_buffPercent")]
  public int BuffPercent { get; set; }

  /// <summary>
  ///   버프의 남은 시간
  /// </summary>
  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  /// <summary>
  ///   범용 변수1
  /// </summary>
  [Column("_param1")]
  public long Param1 { get; set; }

  /// <summary>
  ///   범용 변수2
  /// </summary>
  [Column("_param2")]
  public long Param2 { get; set; }
}