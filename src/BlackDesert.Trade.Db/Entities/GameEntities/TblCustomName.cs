using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   커스터마이징 된 이름 TABLE
/// </summary>
[PrimaryKey("Type", "Param")]
[Table("TblCustomName", Schema = "PaGamePrivate")]
public class TblCustomName
{
  /// <summary>
  ///   타입
  /// </summary>
  [Key]
  [Column("_type")]
  public short Type { get; set; }

  /// <summary>
  ///   파라메터
  /// </summary>
  [Key]
  [Column("_param")]
  public long Param { get; set; }

  /// <summary>
  ///   유저가 작성한 이름
  /// </summary>
  [Column("_name")]
  [StringLength(30)]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   생성/변경일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}