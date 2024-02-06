using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   버프의 유효시간
/// </summary>
[Keyless]
[Table("TblBuffExpirationDate", Schema = "PaGamePrivate")]
public class TblBuffExpirationDate
{
  /// <summary>
  ///   게임내 고유 유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   버프 종류 =&gt; enum값과 연결됨
  /// </summary>
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   버프 만료일시(절대시간임) =&gt; NULL 이거나 과거면 버프 없음.
  /// </summary>
  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  /// <summary>
  ///   버프 레벨.
  /// </summary>
  [Column("_level")]
  public int Level { get; set; }

  [Column("_param1")]
  public int Param1 { get; set; }
}