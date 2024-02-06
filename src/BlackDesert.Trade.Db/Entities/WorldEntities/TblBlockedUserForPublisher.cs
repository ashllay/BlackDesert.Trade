using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   북미 블록 유저 테이블
/// </summary>
[PrimaryKey("UserNo", "BlockType")]
[Table("TblBlockedUserForPublisher", Schema = "PaGamePrivate")]
public class TblBlockedUserForPublisher
{
  /// <summary>
  ///   블록 고유 번호
  /// </summary>
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  /// <summary>
  ///   블록 등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저 넘버
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   유저 이름
  /// </summary>
  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  /// <summary>
  ///   블록 타입
  /// </summary>
  [Key]
  [Column("_blockType")]
  public int BlockType { get; set; }

  /// <summary>
  ///   블록 코드
  /// </summary>
  [Column("_blockCode")]
  public int? BlockCode { get; set; }

  /// <summary>
  ///   블록 사유
  /// </summary>
  [Column("_operationMemo")]
  [StringLength(200)]
  public string OperationMemo { get; set; } = null!;

  /// <summary>
  ///   블록 종료 시간
  /// </summary>
  [Column("_blockDuration")]
  public int BlockDuration { get; set; }

  /// <summary>
  ///   북미 서버 넘버
  /// </summary>
  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_check")]
  public bool Check { get; set; }
}