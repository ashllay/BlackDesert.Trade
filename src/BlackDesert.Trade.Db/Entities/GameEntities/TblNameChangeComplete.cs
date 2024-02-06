using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   이름 변경 완료
/// </summary>
[PrimaryKey("OwnerNo", "Name", "ChangedDate")]
[Table("TblNameChangeComplete", Schema = "PaGamePrivate")]
public class TblNameChangeComplete
{
  /// <summary>
  ///   신청 날짜
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   이름 변경 타입
  /// </summary>
  [Column("_nameChangeType")]
  public int NameChangeType { get; set; }

  /// <summary>
  ///   변경을 요청한 유저 번호
  /// </summary>
  [Key]
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   변경할 이름
  /// </summary>
  [Key]
  [Column("_name")]
  [StringLength(30)]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   변경된 날짜
  /// </summary>
  [Column("_beforeName")]
  [StringLength(30)]
  public string? BeforeName { get; set; }

  /// <summary>
  ///   변경된 날짜
  /// </summary>
  [Key]
  [Column("_changedDate", TypeName = "datetime")]
  public DateTime ChangedDate { get; set; }
}