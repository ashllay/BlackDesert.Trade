using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   개인 결전 참여 정보
/// </summary>
[PrimaryKey("UserNo", "BattleNo")]
[Table("TblAttendPersonalBattle", Schema = "PaGamePrivate")]
public class TblAttendPersonalBattle
{
  /// <summary>
  ///   결전 번호
  /// </summary>
  [Key]
  [Column("_battleNo")]
  public long BattleNo { get; set; }

  /// <summary>
  ///   유저 번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   참여 상태
  /// </summary>
  [Column("_teamNo")]
  public short TeamNo { get; set; }
}