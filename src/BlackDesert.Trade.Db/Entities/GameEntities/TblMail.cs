using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   편지 정보
/// </summary>
[Table("TblMail", Schema = "PaGamePrivate")]
public partial class TblMail
{
  /// <summary>
  ///   등록 일시
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   편지 고유 번호
  /// </summary>
  [Key]
  [Column("_mailNo")]
  public long MailNo { get; set; }

  /// <summary>
  ///   보낸 캐릭터 이름
  /// </summary>
  [Column("_senderName")]
  [StringLength(30)]
  public string SenderName { get; set; } = null!;

  /// <summary>
  ///   보낸 사용자번호
  /// </summary>
  [Column("_senderUserNo")]
  public long SenderUserNo { get; set; }

  /// <summary>
  ///   받는 캐릭터 이름
  /// </summary>
  [Column("_receiverName")]
  [StringLength(30)]
  public string ReceiverName { get; set; } = null!;

  /// <summary>
  ///   받는 사용자번호
  /// </summary>
  [Column("_receiverUserNo")]
  public long ReceiverUserNo { get; set; }

  /// <summary>
  ///   편지 제목
  /// </summary>
  [Column("_title")]
  [StringLength(100)]
  public string Title { get; set; } = null!;

  /// <summary>
  ///   편지 내용
  /// </summary>
  [Column("_contents")]
  [StringLength(500)]
  public string Contents { get; set; } = null!;

  /// <summary>
  ///   편지 타입
  /// </summary>
  [Column("_mailType")]
  public byte MailType { get; set; }

  /// <summary>
  ///   _mailType에 따라 의미 다름
  /// </summary>
  [Column("_variousNo")]
  public long? VariousNo { get; set; }

  /// <summary>
  ///   첨부된 아이템 인챈트 레벨
  /// </summary>
  [Column("_enchantLevel")]
  public byte? EnchantLevel { get; set; }

  /// <summary>
  ///   첨부된 아이템 개수
  /// </summary>
  [Column("_itemCount")]
  public long? ItemCount { get; set; }

  /// <summary>
  ///   첨부된 아이템 유통기한
  /// </summary>
  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  /// <summary>
  ///   편지 삭제 시간
  /// </summary>
  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  /// <summary>
  ///   우편발송 웹창고 아이템 구분 (0:인게임메일, 1:쿠폰지급 아이템, 2:패키지, 3:웹샵 아이템, 그외 추가 가능)
  /// </summary>
  [Column("_webItemType")]
  public byte WebItemType { get; set; }

  [Column("_chargeNo")]
  [StringLength(60)]
  [Unicode(false)]
  public string? ChargeNo { get; set; }
}