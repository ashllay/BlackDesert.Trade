using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   PC의 작업 정보
/// </summary>
[Table("TblPcWorking", Schema = "PaGamePrivate")]
public class TblPcWorking
{
  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   서버번호-작업중일때만 의미있음
  /// </summary>
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   작업종류(PcWorkingType와 연결됨)
  /// </summary>
  [Column("_pcWorkingType")]
  public byte PcWorkingType { get; set; }

  /// <summary>
  ///   작업시작시간(작업종류가 변경될 때마다 설정됨)
  /// </summary>
  [Column("_startTime", TypeName = "datetime")]
  public DateTime StartTime { get; set; }

  /// <summary>
  ///   작업완료시간(작업종류가 변경될 때마다 설정됨)
  /// </summary>
  [Column("_completingTime", TypeName = "datetime")]
  public DateTime CompletingTime { get; set; }

  /// <summary>
  ///   _directionX(방향)
  /// </summary>
  [Column("_directionX")]
  public double DirectionX { get; set; }

  /// <summary>
  ///   _directionY(방향)
  /// </summary>
  [Column("_directionY")]
  public double DirectionY { get; set; }

  /// <summary>
  ///   _directionZ(방향)
  /// </summary>
  [Column("_directionZ")]
  public double DirectionZ { get; set; }

  /// <summary>
  ///   수리되는 아이템번호, 이외는 NULL
  /// </summary>
  [Column("_itemNo")]
  public long? ItemNo { get; set; }

  /// <summary>
  ///   수리하는 곳의 집 번호, 이외는 NULL
  /// </summary>
  [Column("_householdNo")]
  public long? HouseholdNo { get; set; }

  /// <summary>
  ///   수리할때 이용하는 설치물 번호, 이외는 NULL
  /// </summary>
  [Column("_installationNo")]
  public long? InstallationNo { get; set; }

  /// <summary>
  ///   설치물번호의 아이템키, 이외는 NULL
  /// </summary>
  [Column("_installationKey")]
  public int? InstallationKey { get; set; }

  /// <summary>
  ///   노선번호
  /// </summary>
  [Column("_deliveryRoute")]
  public int? DeliveryRoute { get; set; }

  /// <summary>
  ///   출발지 지역번호
  /// </summary>
  [Column("_deliveryFrom")]
  public int? DeliveryFrom { get; set; }

  /// <summary>
  ///   도착지 지역번호
  /// </summary>
  [Column("_deliveryTo")]
  public int? DeliveryTo { get; set; }

  /// <summary>
  ///   운송자 번호(이동중일때만 설정)
  /// </summary>
  [Column("_delivererNo")]
  public long? DelivererNo { get; set; }

  /// <summary>
  ///   (회복작업시)회복할 최대 대화여력
  /// </summary>
  [Column("_maxWp")]
  public int MaxWp { get; set; }
}