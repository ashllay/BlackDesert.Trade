using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   일꾼 작업
/// </summary>
[Table("TblWorkerWorking", Schema = "PaGamePrivate")]
public class TblWorkerWorking
{
  /// <summary>
  ///   작업시작시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _workerNo
  /// </summary>
  [Key]
  [Column("_workerNo")]
  public long WorkerNo { get; set; }

  /// <summary>
  ///   서버번호
  /// </summary>
  [Column("_serverNo")]
  public short? ServerNo { get; set; }

  /// <summary>
  ///   OdbcNpcWorkingType 와 연결됨.
  /// </summary>
  [Column("_workingType")]
  public byte WorkingType { get; set; }

  /// <summary>
  ///   남은 작업회수
  /// </summary>
  [Column("_leftCount")]
  public int LeftCount { get; set; }

  /// <summary>
  ///   목적지 정보(_workingType에 따라서 가변적임)
  /// </summary>
  [Column("_toVariable")]
  public long ToVariable { get; set; }

  /// <summary>
  ///   작업내역 정보(_workingType에 따라서 가변적임)
  /// </summary>
  [Column("_workingVariable")]
  public int WorkingVariable { get; set; }

  /// <summary>
  ///   작업내역 정보2(_workingType에 따라서 가변적임)
  /// </summary>
  [Column("_workingVariable2")]
  public int WorkingVariable2 { get; set; }

  /// <summary>
  ///   목적지(=작업할 물건이 있는 곳)
  /// </summary>
  [Column("_toPlantKey")]
  public int ToPlantKey { get; set; }

  /// <summary>
  ///   목적지가 동적 플랜트일경우 추가키
  /// </summary>
  [Column("_toPlantDynamicKey")]
  public long ToPlantDynamicKey { get; set; }

  /// <summary>
  ///   할일(전출의 경우 키 지정없음)
  /// </summary>
  [Column("_exchangeKey")]
  public int ExchangeKey { get; set; }

  /// <summary>
  ///   집에서 제작하는 경우 사용할 (설치된)주설비의 번호
  /// </summary>
  [Column("_installationNo")]
  public long InstallationNo { get; set; }

  /// <summary>
  ///   생산 효율 레벨
  /// </summary>
  [Column("_productivityLevel")]
  public short ProductivityLevel { get; set; }

  /// <summary>
  ///   운 생산 효율 레벨
  /// </summary>
  [Column("_luckProductivityLevel")]
  public short LuckProductivityLevel { get; set; }

  /// <summary>
  ///   개량할 아이템종류의 enchantLevel(_workingType에 따라서 가변적임)
  /// </summary>
  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  /// <summary>
  ///   개량할 아이템의 내구도
  /// </summary>
  [Column("_endurance")]
  public int Endurance { get; set; }

  /// <summary>
  ///   개량할 아이템의 최대 내구도
  /// </summary>
  [Column("_maxEndurance")]
  public int MaxEndurance { get; set; }

  /// <summary>
  ///   일상태 변경시간
  /// </summary>
  [Column("_stateChangeTime", TypeName = "datetime")]
  public DateTime StateChangeTime { get; set; }

  /// <summary>
  ///   일의 상태
  /// </summary>
  [Column("_workingState")]
  public int WorkingState { get; set; }
}