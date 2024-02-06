using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   생활 숙련도 정보
/// </summary>
[PrimaryKey("CharacterNo", "Type")]
[Table("TblLifeExperience", Schema = "PaGamePrivate")]
public class TblLifeExperience
{
  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   타입
  /// </summary>
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   숙련도
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }
}