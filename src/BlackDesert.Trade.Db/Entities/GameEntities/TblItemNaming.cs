using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저 아이템 네이밍
/// </summary>
[Table("TblItemNaming", Schema = "PaGamePrivate")]
public class TblItemNaming
{
  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저 넘버
  /// </summary>
  [Column("_userNo")]
  public long? UserNo { get; set; }

  /// <summary>
  ///   아이템 넘버
  /// </summary>
  [Key]
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   작성자 이름
  /// </summary>
  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  /// <summary>
  ///   작성자 이름
  /// </summary>
  [Column("_mailNo")]
  public long? MailNo { get; set; }
}