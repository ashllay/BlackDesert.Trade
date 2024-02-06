using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   Servant 정보
/// </summary>
[Table("TblServantRepository", Schema = "PaGamePrivate")]
public class TblServantRepository
{
  /// <summary>
  ///   소유자 타입
  /// </summary>
  [Column("_whereType")]
  public byte WhereType { get; set; }

  /// <summary>
  ///   소유자 고유 번호
  /// </summary>
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   소유자 유저 고유 번호
  /// </summary>
  [Column("_ownerCharacterNo")]
  public long? OwnerCharacterNo { get; set; }

  /// <summary>
  ///   고유 번호
  /// </summary>
  [Key]
  [Column("_servantNo")]
  public long ServantNo { get; set; }

  /// <summary>
  ///   캐릭터 키
  /// </summary>
  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  /// <summary>
  ///   캐릭터 타입(지상, 수상)
  /// </summary>
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   이름
  /// </summary>
  [Column("_name")]
  [StringLength(30)]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   경험치
  /// </summary>
  [Column("_expiredTime", TypeName = "datetime")]
  public DateTime? ExpiredTime { get; set; }

  /// <summary>
  ///   등록 일시
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   삭제 일시
  /// </summary>
  [Column("_deleteDate", TypeName = "datetime")]
  public DateTime? DeleteDate { get; set; }

  /// <summary>
  ///   캐싱 시퀀스번호
  /// </summary>
  [Column("_servantBasicCacheSeqNo")]
  public int ServantBasicCacheSeqNo { get; set; }

  /// <summary>
  ///   레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }

  /// <summary>
  ///   체력
  /// </summary>
  [Column("_hp")]
  public int Hp { get; set; }

  /// <summary>
  ///   스태미너
  /// </summary>
  [Column("_mp")]
  public int Mp { get; set; }

  /// <summary>
  ///   교배 횟수
  /// </summary>
  [Column("_matingCount")]
  public byte MatingCount { get; set; }

  /// <summary>
  ///   말 상태
  /// </summary>
  [Column("_stateType")]
  public byte StateType { get; set; }

  /// <summary>
  ///   _sealRegion
  /// </summary>
  [Column("_sealRegion")]
  public int? SealRegion { get; set; }

  /// <summary>
  ///   교배 고유 번호
  /// </summary>
  [Column("_matingNo")]
  public long? MatingNo { get; set; }

  [Column("_deadCount")]
  public int DeadCount { get; set; }

  /// <summary>
  ///   교감쿨타임(밀리초)
  /// </summary>
  [Column("_sympatheticCoolTime")]
  public long SympatheticCoolTime { get; set; }

  /// <summary>
  ///   압류(유/무)
  /// </summary>
  [Column("_isSeized")]
  public bool IsSeized { get; set; }

  /// <summary>
  ///   각인(유/무)
  /// </summary>
  [Column("_isImprint")]
  public bool IsImprint { get; set; }

  /// <summary>
  ///   교배 횟수 추가 아이템 사용 횟수
  /// </summary>
  [Column("_clearCountByMating")]
  public byte ClearCountByMating { get; set; }

  /// <summary>
  ///   죽은 횟수 초기화 아이템 사용 횟수
  /// </summary>
  [Column("_clearCountByDead")]
  public byte ClearCountByDead { get; set; }

  /// <summary>
  ///   스킬 변경 실패 횟수
  /// </summary>
  [Column("_skillFailedCount")]
  public int SkillFailedCount { get; set; }

  /// <summary>
  ///   연결된 마차 번호
  /// </summary>
  [Column("_ownerServantNo")]
  public long? OwnerServantNo { get; set; }

  /// <summary>
  ///   외형 인덱스
  /// </summary>
  [Column("_formIndex")]
  public int FormIndex { get; set; }

  /// <summary>
  ///   염색
  /// </summary>
  [Column("_dyeingList")]
  [MaxLength(24)]
  public byte[]? DyeingList { get; set; }

  /// <summary>
  ///   _currentFieldNo
  /// </summary>
  [Column("_currentFieldNo")]
  public short CurrentFieldNo { get; set; }

  /// <summary>
  ///   _currentFieldIndex
  /// </summary>
  [Column("_currentFieldIndex")]
  public short CurrentFieldIndex { get; set; }

  /// <summary>
  ///   _currentPositionX
  /// </summary>
  [Column("_currentPositionX")]
  public long CurrentPositionX { get; set; }

  /// <summary>
  ///   _currentPositionY
  /// </summary>
  [Column("_currentPositionY")]
  public long CurrentPositionY { get; set; }

  /// <summary>
  ///   _currentPositionZ
  /// </summary>
  [Column("_currentPositionZ")]
  public long CurrentPositionZ { get; set; }

  /// <summary>
  ///   _variedMaxHp
  /// </summary>
  [Column("_variedMaxHp")]
  public int VariedMaxHp { get; set; }

  /// <summary>
  ///   _variedMaxMp
  /// </summary>
  [Column("_variedMaxMp")]
  public int VariedMaxMp { get; set; }

  /// <summary>
  ///   성장 가변 가속도
  /// </summary>
  [Column("_variedAcceleration")]
  public int VariedAcceleration { get; set; }

  /// <summary>
  ///   성장 가변 속도
  /// </summary>
  [Column("_variedMoveSpeed")]
  public int VariedMoveSpeed { get; set; }

  /// <summary>
  ///   성장 가변 코너링
  /// </summary>
  [Column("_variedCornering")]
  public int VariedCornering { get; set; }

  /// <summary>
  ///   성장 가변 브레이크
  /// </summary>
  [Column("_variedBrake")]
  public int VariedBrake { get; set; }

  /// <summary>
  ///   스킬 훈련 종료시간
  /// </summary>
  [Column("_endSkillExpTrainingTime", TypeName = "datetime")]
  public DateTime? EndSkillExpTrainingTime { get; set; }

  /// <summary>
  ///   소환된 서버 번호
  /// </summary>
  [Column("_lastServerNo")]
  public short? LastServerNo { get; set; }

  /// <summary>
  ///   서번트 소환 가능 시간
  /// </summary>
  [Column("_unsealDelayTime", TypeName = "datetime")]
  public DateTime? UnsealDelayTime { get; set; }

  /// <summary>
  ///   준마 각성 스택
  /// </summary>
  [Column("_awakenStack")]
  public int AwakenStack { get; set; }

  [Column("_food")]
  public int? Food { get; set; }

  [Column("_statParam1")]
  public int? StatParam1 { get; set; }

  [Column("_statParam2")]
  public int? StatParam2 { get; set; }

  [Column("_statParam3")]
  public int? StatParam3 { get; set; }

  [Column("_rentOwnerNo")]
  public long? RentOwnerNo { get; set; }

  /// <summary>
  ///   _direction
  /// </summary>
  [Column("_direction")]
  public int? Direction { get; set; }

  [Column("_rentEndDate", TypeName = "datetime")]
  public DateTime? RentEndDate { get; set; }

  /// <summary>
  ///   성장 가변 대포 쿨타임
  /// </summary>
  [Column("_variedCannonCoolTime")]
  public int VariedCannonCoolTime { get; set; }

  /// <summary>
  ///   성장 가변 대포 정확도
  /// </summary>
  [Column("_variedCannonAccuracy")]
  public int VariedCannonAccuracy { get; set; }

  /// <summary>
  ///   성장 가변 대포 사거리
  /// </summary>
  [Column("_variedCannonMaxLength")]
  public int VariedCannonMaxLength { get; set; }

  /// <summary>
  ///   성장 가변 대포 각도
  /// </summary>
  [Column("_variedCannonMaxAngle")]
  public int VariedCannonMaxAngle { get; set; }

  [Column("_skillDiceCount")]
  public int SkillDiceCount { get; set; }

  [Column("_useAccelerationStatItem")]
  public byte UseAccelerationStatItem { get; set; }

  [Column("_useMoveSpeedStatItem")]
  public byte UseMoveSpeedStatItem { get; set; }

  [Column("_useCorneringStatItem")]
  public byte UseCorneringStatItem { get; set; }

  [Column("_useBrakeStatItem")]
  public byte UseBrakeStatItem { get; set; }
}