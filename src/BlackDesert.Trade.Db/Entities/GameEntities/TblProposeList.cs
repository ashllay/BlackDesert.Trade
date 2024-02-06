using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   고백 리스트 테이블
/// </summary>
[PrimaryKey("UserNo", "NpcKey")]
[Table("TblProposeList", Schema = "PaGamePrivate")]
public class TblProposeList
{
  /// <summary>
  ///   고백한 유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   npc 번호
  /// </summary>
  [Key]
  [Column("_npcKey")]
  public int NpcKey { get; set; }
}