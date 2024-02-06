using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   공성&amp;마을 정보
/// </summary>
[PrimaryKey("SiegeHistoryDate", "RegionKey")]
[Table("TblSiegeHistory", Schema = "PaGamePrivate")]
public class TblSiegeHistory
{
  /// <summary>
  ///   최초 등록시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   갱신된 시간
  /// </summary>
  [Column("_updateDate", TypeName = "datetime")]
  public DateTime? UpdateDate { get; set; }

  /// <summary>
  ///   공성 날짜 키
  /// </summary>
  [Key]
  [Column("_siegeHistoryDate")]
  public int SiegeHistoryDate { get; set; }

  /// <summary>
  ///   공성 종류
  /// </summary>
  [Column("_isVillageSiege")]
  public bool IsVillageSiege { get; set; }

  /// <summary>
  ///   _regionKey
  /// </summary>
  [Key]
  [Column("_regionKey")]
  public int RegionKey { get; set; }

  /// <summary>
  ///   점령일시(주인이 없다면 해방일시)
  /// </summary>
  [Column("_occupyingDate", TypeName = "datetime")]
  public DateTime OccupyingDate { get; set; }

  /// <summary>
  ///   주인이 없으면 0
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   점령 길드명
  /// </summary>
  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;
}