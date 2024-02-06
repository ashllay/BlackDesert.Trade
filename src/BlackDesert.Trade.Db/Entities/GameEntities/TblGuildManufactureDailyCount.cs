using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드가공일일횟수
/// </summary>
[Keyless]
[Table("TblGuildManufactureDailyCount", Schema = "PaGamePrivate")]
public class TblGuildManufactureDailyCount
{
  /// <summary>
  ///   길드번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   가공아이템완료갯수
  /// </summary>
  [Column("_completeCount")]
  public long CompleteCount { get; set; }

  /// <summary>
  ///   마지막 등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   가공아이템
  /// </summary>
  [Column("_productItemKey")]
  public int ProductItemKey { get; set; }
}