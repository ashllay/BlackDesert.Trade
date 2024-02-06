using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   세금 납입 시간 기록용
/// </summary>
[Keyless]
[Table("TblSiegeTaxTime", Schema = "PaGamePrivate")]
public class TblSiegeTaxTime
{
  /// <summary>
  ///   지급 시간
  /// </summary>
  [Column("_lastPayTime", TypeName = "datetime")]
  public DateTime LastPayTime { get; set; }
}