using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 쾌스트 진행 목록
/// </summary>
[Table("TblGuildQuestList", Schema = "PaGamePrivate")]
public class TblGuildQuestList
{
  /// <summary>
  ///   길드번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   길드 쾌스트 번호
  /// </summary>
  [Column("_guildQuestNo")]
  public int GuildQuestNo { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   _count1
  /// </summary>
  [Column("_count1")]
  public int Count1 { get; set; }

  /// <summary>
  ///   _count2
  /// </summary>
  [Column("_count2")]
  public int Count2 { get; set; }

  /// <summary>
  ///   _count3
  /// </summary>
  [Column("_count3")]
  public int Count3 { get; set; }

  /// <summary>
  ///   _count4
  /// </summary>
  [Column("_count4")]
  public int Count4 { get; set; }

  /// <summary>
  ///   _count5
  /// </summary>
  [Column("_count5")]
  public int Count5 { get; set; }

  /// <summary>
  ///   쾌스트수락일시
  /// </summary>
  [Column("_orderTime", TypeName = "datetime")]
  public DateTime OrderTime { get; set; }

  /// <summary>
  ///   제한시간
  /// </summary>
  [Column("_limitTime")]
  public long? LimitTime { get; set; }

  /// <summary>
  ///   선점여부
  /// </summary>
  [Column("_isPreoccupancy")]
  public bool IsPreoccupancy { get; set; }
}