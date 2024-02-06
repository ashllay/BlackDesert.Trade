using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   친구 그룹
/// </summary>
[PrimaryKey("UserNo", "GroupNo")]
[Table("TblFriendGroup", Schema = "PaGamePrivate")]
public class TblFriendGroup
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   그룹번호
  /// </summary>
  [Key]
  [Column("_groupNo")]
  public int GroupNo { get; set; }

  /// <summary>
  ///   그룹이름
  /// </summary>
  [Column("_groupName")]
  [StringLength(30)]
  public string GroupName { get; set; } = null!;
}