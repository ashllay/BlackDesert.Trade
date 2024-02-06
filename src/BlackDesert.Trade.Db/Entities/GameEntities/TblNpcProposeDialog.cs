using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   NPC 고백 시 대사 테이블
/// </summary>
[Table("TblNpcProposeDialog", Schema = "PaGamePrivate")]
public class TblNpcProposeDialog
{
  /// <summary>
  ///   index 번호
  /// </summary>
  [Key]
  [Column("_index")]
  public int Index { get; set; }

  /// <summary>
  ///   npc 번호
  /// </summary>
  [Column("_npcKey")]
  public int NpcKey { get; set; }

  /// <summary>
  ///   이름
  /// </summary>
  [Column("_senderName")]
  [StringLength(30)]
  public string SenderName { get; set; } = null!;

  /// <summary>
  ///   타이틀
  /// </summary>
  [Column("_title")]
  [StringLength(100)]
  public string Title { get; set; } = null!;

  /// <summary>
  ///   실패 시 메시지
  /// </summary>
  [Column("_fail")]
  [StringLength(300)]
  public string Fail { get; set; } = null!;

  /// <summary>
  ///   성공 시 메시지
  /// </summary>
  [Column("_success")]
  [StringLength(300)]
  public string Success { get; set; } = null!;

  /// <summary>
  ///   헤어질 때 메시지
  /// </summary>
  [Column("_farewell")]
  [StringLength(300)]
  public string Farewell { get; set; } = null!;

  [Column("_titleKey")]
  public int TitleKey { get; set; }
}