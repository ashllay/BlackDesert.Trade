using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   시간 테이블
/// </summary>
[Table("TblCommonTime", Schema = "PaGamePrivate")]
public class TblCommonTime
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_worldNo")]
  public short WorldNo { get; set; }

  /// <summary>
  ///   서버가 켜진 시간
  /// </summary>
  [Column("_serverOpenTime", TypeName = "datetime")]
  public DateTime? ServerOpenTime { get; set; }

  /// <summary>
  ///   서버의 마지막 업데이트 시간
  /// </summary>
  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime? LastUpdateTime { get; set; }

  /// <summary>
  ///   서버 누적 시간(서버가 켜진 상태에서만 누적됨)
  /// </summary>
  [Column("_cumulatedTick")]
  public long CumulatedTick { get; set; }
}