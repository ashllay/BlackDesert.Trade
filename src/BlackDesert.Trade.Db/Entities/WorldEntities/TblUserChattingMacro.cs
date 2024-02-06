using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유저를 위한 채팅 매크로 정보
/// </summary>
[PrimaryKey("UserNo", "MacroNo")]
[Table("TblUserChattingMacro", Schema = "PaGamePrivate")]
public class TblUserChattingMacro
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   매크로 번호
  /// </summary>
  [Key]
  [Column("_macroNo")]
  public int MacroNo { get; set; }

  /// <summary>
  ///   채팅 타입
  /// </summary>
  [Column("_chatType")]
  public byte ChatType { get; set; }

  /// <summary>
  ///   채팅 메시지
  /// </summary>
  [Column("_chatMessage")]
  [StringLength(100)]
  public string ChatMessage { get; set; } = null!;
}