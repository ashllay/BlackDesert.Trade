using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   연인 테이블
/// </summary>
[Table("TblLoverList", Schema = "PaGamePrivate")]
public class TblLoverList
{
  /// <summary>
  ///   npc 번호
  /// </summary>
  [Key]
  [Column("_npcKey")]
  public int NpcKey { get; set; }

  /// <summary>
  ///   npc의 연인 유저 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }
}