using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드가공
/// </summary>
[Keyless]
[Table("TblGuildManufacture", Schema = "PaGamePrivate")]
public class TblGuildManufacture
{
  /// <summary>
  ///   길드번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   슬롯번호
  /// </summary>
  [Column("_index")]
  public byte Index { get; set; }

  /// <summary>
  ///   가공아이템갯수
  /// </summary>
  [Column("_productItemCount")]
  public long ProductItemCount { get; set; }

  /// <summary>
  ///   재료아이템갯수0
  /// </summary>
  [Column("_requiredItemCount0")]
  public long RequiredItemCount0 { get; set; }

  /// <summary>
  ///   재료아이템갯수1
  /// </summary>
  [Column("_requiredItemCount1")]
  public long RequiredItemCount1 { get; set; }

  /// <summary>
  ///   재료아이템갯수2
  /// </summary>
  [Column("_requiredItemCount2")]
  public long RequiredItemCount2 { get; set; }

  /// <summary>
  ///   재료아이템갯수3
  /// </summary>
  [Column("_requiredItemCount3")]
  public long RequiredItemCount3 { get; set; }

  /// <summary>
  ///   재료아이템갯수4
  /// </summary>
  [Column("_requiredItemCount4")]
  public long RequiredItemCount4 { get; set; }

  /// <summary>
  ///   재료아이템갯수5
  /// </summary>
  [Column("_requiredItemCount5")]
  public long RequiredItemCount5 { get; set; }

  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   완료일
  /// </summary>
  [Column("_completeDate", TypeName = "datetime")]
  public DateTime CompleteDate { get; set; }

  /// <summary>
  ///   가공아이템
  /// </summary>
  [Column("_productItemKey")]
  public int ProductItemKey { get; set; }

  /// <summary>
  ///   재료아이템0
  /// </summary>
  [Column("_requiredItemKey0")]
  public int RequiredItemKey0 { get; set; }

  /// <summary>
  ///   재료아이템1
  /// </summary>
  [Column("_requiredItemKey1")]
  public int RequiredItemKey1 { get; set; }

  /// <summary>
  ///   재료아이템2
  /// </summary>
  [Column("_requiredItemKey2")]
  public int RequiredItemKey2 { get; set; }

  /// <summary>
  ///   재료아이템3
  /// </summary>
  [Column("_requiredItemKey3")]
  public int RequiredItemKey3 { get; set; }

  /// <summary>
  ///   재료아이템4
  /// </summary>
  [Column("_requiredItemKey4")]
  public int RequiredItemKey4 { get; set; }

  /// <summary>
  ///   재료아이템5
  /// </summary>
  [Column("_requiredItemKey5")]
  public int RequiredItemKey5 { get; set; }
}