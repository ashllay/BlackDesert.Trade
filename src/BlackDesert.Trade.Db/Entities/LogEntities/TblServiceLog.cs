using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

/// <summary>
///   Service 로그
/// </summary>
[Table("TblServiceLog", Schema = "PaGamePrivate")]
public class TblServiceLog
{
  /// <summary>
  ///   로그 고유번호
  /// </summary>
  [Key]
  [Column("_logNo")]
  public long LogNo { get; set; }

  /// <summary>
  ///   로그 타입
  /// </summary>
  [Column("_operationLogType")]
  public short? OperationLogType { get; set; }

  /// <summary>
  ///   서버 번호
  /// </summary>
  [Column("_serverNo")]
  public short? ServerNo { get; set; }

  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저 ID
  /// </summary>
  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }

  /// <summary>
  ///   유저 고유 번호
  /// </summary>
  [Column("_userNo")]
  public long? UserNo { get; set; }

  /// <summary>
  ///   유저 IP
  /// </summary>
  [Column("_userIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string? UserIp { get; set; }

  /// <summary>
  ///   참이면 운영자
  /// </summary>
  [Column("_isUserGm")]
  public bool IsUserGm { get; set; }

  /// <summary>
  ///   유저 플레이 시간
  /// </summary>
  [Column("_playMinuteOfUser")]
  public long? PlayMinuteOfUser { get; set; }

  /// <summary>
  ///   참이면 PC방
  /// </summary>
  [Column("_isPcRoom")]
  public bool IsPcRoom { get; set; }

  /// <summary>
  ///   참이면 PC방 혜택
  /// </summary>
  [Column("_isPcRoomPremium")]
  public bool IsPcRoomPremium { get; set; }

  /// <summary>
  ///   참이면 PVP
  /// </summary>
  [Column("_isPvP")]
  public bool IsPvP { get; set; }

  /// <summary>
  ///   guest 계정 여부
  /// </summary>
  [Column("_isGuestAccount")]
  public bool? IsGuestAccount { get; set; }

  /// <summary>
  ///   15세 이용가
  /// </summary>
  [Column("_gameAgeGradeType")]
  public byte? GameAgeGradeType { get; set; }

  /// <summary>
  ///   운영 로그 내용
  /// </summary>
  [Column("_serviceString")]
  [StringLength(200)]
  public string? ServiceString { get; set; }

  /// <summary>
  ///   로그 이유
  /// </summary>
  [Column("_symNoReason")]
  public long SymNoReason { get; set; }

  /// <summary>
  ///   param1
  /// </summary>
  [Column("_serviceParam1")]
  public long? ServiceParam1 { get; set; }

  /// <summary>
  ///   param2
  /// </summary>
  [Column("_serviceParam2")]
  public long? ServiceParam2 { get; set; }

  /// <summary>
  ///   param3
  /// </summary>
  [Column("_serviceParam3")]
  public long? ServiceParam3 { get; set; }
}