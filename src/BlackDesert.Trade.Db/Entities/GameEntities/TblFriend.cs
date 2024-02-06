using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   친구 목록
/// </summary>
[PrimaryKey("UserNo", "FriendUserNo")]
[Table("TblFriends", Schema = "PaGamePrivate")]
public class TblFriend
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   친구 유저번호
  /// </summary>
  [Key]
  [Column("_friendUserNo")]
  public long FriendUserNo { get; set; }

  /// <summary>
  ///   그룹번호
  /// </summary>
  [Column("_groupNo")]
  public int GroupNo { get; set; }

  /// <summary>
  ///   0 일반,1 파티
  /// </summary>
  [Column("_friendType")]
  public int FriendType { get; set; }

  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}