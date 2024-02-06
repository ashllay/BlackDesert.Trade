using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   부대
/// </summary>
[Table("TblExpeditionaryUnits", Schema = "PaGamePrivate")]
public class TblExpeditionaryUnit
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   유닛 번호
  /// </summary>
  [Key]
  [Column("_unitNo")]
  public long UnitNo { get; set; }

  /// <summary>
  ///   유닛키
  /// </summary>
  [Column("_unitKey")]
  public int UnitKey { get; set; }

  [Column("_unitGrade")]
  public byte UnitGrade { get; set; }

  /// <summary>
  ///   부대레벨
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  /// <summary>
  ///   부대 경험치
  /// </summary>
  [Column("_experience")]
  public long Experience { get; set; }

  [Column("_energyPoint")]
  public int EnergyPoint { get; set; }
}