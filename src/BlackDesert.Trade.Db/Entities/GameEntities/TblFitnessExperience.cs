using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   건강 경험치
/// </summary>
[PrimaryKey("CharacterNo", "Type")]
[Table("TblFitnessExperience", Schema = "PaGamePrivate")]
public class TblFitnessExperience
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   0 호흡,1 힘,2 건강
  /// </summary>
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }
}