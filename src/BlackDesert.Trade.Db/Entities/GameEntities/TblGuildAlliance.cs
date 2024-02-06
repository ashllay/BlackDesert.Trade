using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드연합
/// </summary>
[Keyless]
[Table("TblGuildAlliance", Schema = "PaGamePrivate")]
public class TblGuildAlliance
{
  /// <summary>
  ///   등록일(길드연합장의 등록일)
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   연합길드번호
  /// </summary>
  [Column("_chairGuildNo")]
  public long ChairGuildNo { get; set; }

  /// <summary>
  ///   길드번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   길드인원 제한
  /// </summary>
  [Column("_limitMemberCount")]
  public int LimitMemberCount { get; set; }

  /// <summary>
  ///   길드인원 세금 상수
  /// </summary>
  [Column("_taxRate")]
  public int TaxRate { get; set; }
}