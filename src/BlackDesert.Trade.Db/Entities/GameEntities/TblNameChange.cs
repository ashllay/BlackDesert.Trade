using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   이름 변경 요청
/// </summary>
[PrimaryKey("OwnerNo", "NameChangeType")]
[Table("TblNameChange", Schema = "PaGamePrivate")]
public class TblNameChange
{
  /// <summary>
  ///   신청 날짜
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   이름 변경 타입
  /// </summary>
  [Key]
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
  [Column("_name")]
  [StringLength(30)]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   변경전 이름
  /// </summary>
  [Column("_beforeName")]
  [StringLength(30)]
  public string? BeforeName { get; set; }

  /// <summary>
  ///   불건전한 이름 확인 여부
  /// </summary>
  [Column("_isBadName")]
  public bool IsBadName { get; set; }
}