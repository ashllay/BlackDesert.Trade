using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   친구 요청 리스트
/// </summary>
[PrimaryKey("UserNo", "RequestUserNo")]
[Table("TblAddFriendList", Schema = "PaGamePrivate")]
public class TblAddFriendList
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   친구요청 유저번호
  /// </summary>
  [Key]
  [Column("_requestUserNo")]
  public long RequestUserNo { get; set; }
}