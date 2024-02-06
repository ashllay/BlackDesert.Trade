using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드하우스 대량제작
/// </summary>
[PrimaryKey("GuildNo", "ReceipeKey")]
[Table("TblGuildHouseLargeCraft", Schema = "PaGamePrivate")]
public class TblGuildHouseLargeCraft
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
  [Column("_largeExchangeKey")]
  public int LargeExchangeKey { get; set; }

  /// <summary>
  ///   대량생산 남은 수 0
  /// </summary>
  [Column("_completePoint0")]
  public long CompletePoint0 { get; set; }

  /// <summary>
  ///   대량생산 남은 수 1
  /// </summary>
  [Column("_completePoint1")]
  public long CompletePoint1 { get; set; }

  /// <summary>
  ///   대량생산 남은 수 2
  /// </summary>
  [Column("_completePoint2")]
  public long CompletePoint2 { get; set; }

  /// <summary>
  ///   대량생산 남은 수 3
  /// </summary>
  [Column("_completePoint3")]
  public long CompletePoint3 { get; set; }

  /// <summary>
  ///   대량생산 남은 수 4
  /// </summary>
  [Column("_completePoint4")]
  public long CompletePoint4 { get; set; }

  /// <summary>
  ///   대량생산 남은 수 5
  /// </summary>
  [Column("_completePoint5")]
  public long CompletePoint5 { get; set; }
}