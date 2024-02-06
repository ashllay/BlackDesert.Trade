using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유저정보
/// </summary>
[Table("TblUserInformation", Schema = "PaGamePrivate")]
public class TblUserInformation
{
  /// <summary>
  ///   생성일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   참인 경우에만 선택할 수 있는 사용자임
  /// </summary>
  [Required]
  [Column("_isValid")]
  public bool? IsValid { get; set; }

  /// <summary>
  ///   _userNo
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   _userId
  /// </summary>
  [Column("_userId")]
  [StringLength(64)]
  public string UserId { get; set; } = null!;

  /// <summary>
  ///   _userNickname
  /// </summary>
  [Column("_userNickname")]
  [StringLength(30)]
  public string? UserNickname { get; set; }

  /// <summary>
  ///   인증Key
  /// </summary>
  [Column("_authenticKey")]
  public int AuthenticKey { get; set; }

  /// <summary>
  ///   인증유통기한
  /// </summary>
  [Column("_authenticExpiration", TypeName = "datetime")]
  public DateTime AuthenticExpiration { get; set; }

  [Column("_webAuthenticKey")]
  public int WebAuthenticKey { get; set; }

  /// <summary>
  ///   최근로그인시간
  /// </summary>
  [Column("_lastLoginTime", TypeName = "datetime")]
  public DateTime LastLoginTime { get; set; }

  /// <summary>
  ///   최근로그아웃시간
  /// </summary>
  [Column("_lastLogoutTime", TypeName = "datetime")]
  public DateTime LastLogoutTime { get; set; }

  /// <summary>
  ///   총 play시간(단위:분)
  /// </summary>
  [Column("_totalPlayTime")]
  public long TotalPlayTime { get; set; }

  /// <summary>
  ///   최근접속IP
  /// </summary>
  [Column("_lastIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string LastIp { get; set; } = null!;

  /// <summary>
  ///   접속중인 월드번호.=&gt;접속중이 아니면 음수임
  /// </summary>
  [Column("_lastServerNo")]
  public short LastServerNo { get; set; }

  /// <summary>
  ///   비밀번호 틀린 횟수
  /// </summary>
  [Column("_failPasswordCount")]
  public byte FailPasswordCount { get; set; }

  /// <summary>
  ///   퍼블리셔 토큰 정보
  /// </summary>
  [Column("_publisherCryptToken")]
  [StringLength(40)]
  [Unicode(false)]
  public string? PublisherCryptToken { get; set; }

  /// <summary>
  ///   유저 채널링 정보
  /// </summary>
  [Column("_membershipType")]
  public byte MembershipType { get; set; }

  /// <summary>
  ///   스피드서버 접속 가능 여부
  /// </summary>
  [Column("_isAdmissionToSpeedServer")]
  public byte IsAdmissionToSpeedServer { get; set; }

  /// <summary>
  ///   피씨방 여부
  /// </summary>
  [Column("_isPcRoom")]
  public bool IsPcRoom { get; set; }

  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  /// <summary>
  ///   게스트 패스
  /// </summary>
  [Column("_isGuestAccount")]
  public bool IsGuestAccount { get; set; }

  /// <summary>
  ///   스피드서버 접속 가능 기간
  /// </summary>
  [Column("_speedServerExpiration", TypeName = "datetime")]
  public DateTime SpeedServerExpiration { get; set; }

  /// <summary>
  ///   계정 만료 시간
  /// </summary>
  [Column("_accountExpirationDate", TypeName = "datetime")]
  public DateTime? AccountExpirationDate { get; set; }

  /// <summary>
  ///   하드웨어와 드라이버 정보
  /// </summary>
  [Column("_surveyHWAndSW")]
  [StringLength(200)]
  [Unicode(false)]
  public string? SurveyHwandSw { get; set; }

  /// <summary>
  ///   밸런스 채널에 접속 가능한가
  /// </summary>
  [Required]
  [Column("_isAccessBlanceChannel")]
  public bool? IsAccessBlanceChannel { get; set; }

  /// <summary>
  ///   프리미엄 채널 입장 가능여부
  /// </summary>
  [Column("_isPremiumChannelPermission")]
  public bool IsPremiumChannelPermission { get; set; }

  /// <summary>
  ///   사전생성 기간에도 접속 유무
  /// </summary>
  [Column("_isIgnoreCheckCustomizeOnly")]
  public bool IsIgnoreCheckCustomizeOnly { get; set; }

  /// <summary>
  ///   재접 인증Key
  /// </summary>
  [Column("_preAuthenticKey")]
  public int PreAuthenticKey { get; set; }

  /// <summary>
  ///   성인 채널에 접속 한 계정인지
  /// </summary>
  [Column("_isAdultWorldUser")]
  public bool? IsAdultWorldUser { get; set; }

  /// <summary>
  ///   셧다운 시간
  /// </summary>
  [Column("_shutDownTime", TypeName = "datetime")]
  public DateTime? ShutDownTime { get; set; }

  [Column("_isOtp")]
  public bool IsOtp { get; set; }

  [Column("_atField")]
  [StringLength(13)]
  [Unicode(false)]
  public string? AtField { get; set; }

  [Column("_isCompleteTesterSubmit")]
  public bool IsCompleteTesterSubmit { get; set; }

  [Column("_lastWorldNo")]
  public short? LastWorldNo { get; set; }

  [Column("_serviceType")]
  public short? ServiceType { get; set; }

  [Column("_lastMacAddress")]
  [MaxLength(64)]
  public byte[]? LastMacAddress { get; set; }

  [Column("_allCharacterTotalLevel")]
  public int AllCharacterTotalLevel { get; set; }

  [Column("_email")]
  [StringLength(125)]
  public string? Email { get; set; }

  [Column("_username")]
  [StringLength(32)]
  public string Username { get; set; } = null!;

  [Column("_realPassword")]
  [StringLength(32)]
  public string RealPassword { get; set; } = null!;

  [Column("_balance")]
  public long Balance { get; set; }

  [Column("_isEmailConfirmed")]
  public bool IsEmailConfirmed { get; set; }

  [Column("_fullname")]
  [StringLength(255)]
  public string? Fullname { get; set; }

  [Column("_isAppliedNickNameChange")]
  public bool IsAppliedNickNameChange { get; set; }

  /// <summary>
  ///   2차 비밀 번호
  /// </summary>
  [Column("_password")]
  [MaxLength(256)]
  public byte[]? Password { get; set; }

  /// <summary>
  ///   결제 비밀 번호
  /// </summary>
  [Column("_paymentPassword")]
  [MaxLength(256)]
  public byte[]? PaymentPassword { get; set; }

  [Column("_playToken")]
  [StringLength(256)]
  [Unicode(false)]
  public string? PlayToken { get; set; }

  [Column("_refreshToken")]
  [StringLength(256)]
  [Unicode(false)]
  public string? RefreshToken { get; set; }

  [Column("_tokenExpireDate")]
  public DateTime? TokenExpireDate { get; set; }
}