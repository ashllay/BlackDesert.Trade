using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유일한 이름
/// </summary>
[PrimaryKey("Type", "Name")]
[Table("TblUniqueName", Schema = "PaGamePrivate")]
public class TblUniqueName
{
  /// <summary>
  ///   생성일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   0 캐릭터명,1 길드명, 2 가문명(enum NameType)
  /// </summary>
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   해당번호
  /// </summary>
  [Column("_variousNo")]
  public long VariousNo { get; set; }

  /// <summary>
  ///   이름
  /// </summary>
  [Key]
  [Column("_name")]
  [StringLength(50)]
  public string Name { get; set; } = null!;

  /// <summary>
  ///   월드번호
  /// </summary>
  [Column("_worldNo")]
  public short WorldNo { get; set; }

  /// <summary>
  ///   삭제일
  /// </summary>
  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_subType")]
  public byte SubType { get; set; }
}