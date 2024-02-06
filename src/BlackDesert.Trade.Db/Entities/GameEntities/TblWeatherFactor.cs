using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   날씨 요소
/// </summary>
[PrimaryKey("SlotNo", "SectorX", "SectorZ")]
[Table("TblWeatherFactor", Schema = "PaGamePrivate")]
public class TblWeatherFactor
{
  /// <summary>
  ///   마지막 수정일시
  /// </summary>
  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }

  /// <summary>
  ///   슬롯번호
  /// </summary>
  [Key]
  [Column("_slotNo")]
  public byte SlotNo { get; set; }

  /// <summary>
  ///   _sectorX
  /// </summary>
  [Key]
  [Column("_sectorX")]
  public int SectorX { get; set; }

  /// <summary>
  ///   _sectorZ
  /// </summary>
  [Key]
  [Column("_sectorZ")]
  public int SectorZ { get; set; }

  /// <summary>
  ///   습기
  /// </summary>
  [Column("_humidity")]
  public double Humidity { get; set; }

  /// <summary>
  ///   섭씨
  /// </summary>
  [Column("_celsius")]
  public double Celsius { get; set; }

  /// <summary>
  ///   물
  /// </summary>
  [Column("_water")]
  public double Water { get; set; }

  /// <summary>
  ///   기름
  /// </summary>
  [Column("_oil")]
  public double Oil { get; set; }

  /// <summary>
  ///   잔디
  /// </summary>
  [Column("_grass")]
  public double Grass { get; set; }
}