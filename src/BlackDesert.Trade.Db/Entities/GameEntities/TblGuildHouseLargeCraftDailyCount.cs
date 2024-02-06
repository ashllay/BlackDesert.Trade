using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드하우스 대량제작
/// </summary>
[PrimaryKey("GuildNo", "ReceipeKey", "LargeExchangeKey")]
[Table("TblGuildHouseLargeCraftDailyCount", Schema = "PaGamePrivate")]
public class TblGuildHouseLargeCraftDailyCount
{
  /// <summary>
  ///   대량생산의 주체번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   집의 레시피타입키 / 0은 용도없음
  /// </summary>
  [Key]
  [Column("_receipeKey")]
  public int ReceipeKey { get; set; }

  /// <summary>
  ///   대량생산 exchange키
  /// </summary>
  [Key]
  [Column("_largeExchangeKey")]
  public int LargeExchangeKey { get; set; }

  /// <summary>
  ///   오늘 수행한대량생산 수
  /// </summary>
  [Column("_completeCount")]
  public long CompleteCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}