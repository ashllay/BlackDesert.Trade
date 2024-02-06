using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 게시판 정보
/// </summary>
[PrimaryKey("GuildNo", "BoardType")]
[Table("TblGuildBoard", Schema = "PaGamePrivate")]
public class TblGuildBoard
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   길드번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   사용자번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   게시판 타입
  /// </summary>
  [Key]
  [Column("_boardType")]
  public byte BoardType { get; set; }

  /// <summary>
  ///   게시판 내용
  /// </summary>
  [Column("_boardMessage")]
  [StringLength(250)]
  public string BoardMessage { get; set; } = null!;
}