using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   날씨 동적 요소
/// </summary>
[Keyless]
[Table("TblWeatherDynamicFactor", Schema = "PaGamePrivate")]
public class TblWeatherDynamicFactor
{
  /// <summary>
  ///   마지막 수정일시
  /// </summary>
  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }

  /// <summary>
  ///   _positionX
  /// </summary>
  [Column("_positionX")]
  public double PositionX { get; set; }

  /// <summary>
  ///   _positionY
  /// </summary>
  [Column("_positionY")]
  public double PositionY { get; set; }

  /// <summary>
  ///   _positionZ
  /// </summary>
  [Column("_positionZ")]
  public double PositionZ { get; set; }

  /// <summary>
  ///   속도
  /// </summary>
  [Column("_speed")]
  public double Speed { get; set; }

  /// <summary>
  ///   방향
  /// </summary>
  [Column("_direction")]
  public double Direction { get; set; }

  /// <summary>
  ///   최소반경
  /// </summary>
  [Column("_radiusMin")]
  public double RadiusMin { get; set; }

  /// <summary>
  ///   최대반경
  /// </summary>
  [Column("_radiusMax")]
  public double RadiusMax { get; set; }

  /// <summary>
  ///   구름비율(운량)
  /// </summary>
  [Column("_cloudRate")]
  public double CloudRate { get; set; }

  /// <summary>
  ///   강수량
  /// </summary>
  [Column("_rainAmount")]
  public double RainAmount { get; set; }

  /// <summary>
  ///   기압
  /// </summary>
  [Column("_airPress")]
  public double AirPress { get; set; }
}