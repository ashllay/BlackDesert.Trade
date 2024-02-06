using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   공성&amp;마을 정보
/// </summary>
[Table("TblSiege", Schema = "PaGamePrivate")]
public class TblSiege
{
  /// <summary>
  ///   최초 등록시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

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
  ///   성주가 설정한 세율
  /// </summary>
  [Column("_taxRateForSiege")]
  public int TaxRateForSiege { get; set; }

  /// <summary>
  ///   성주가 인출할 수 있는 세금잔량
  /// </summary>
  [Column("_taxRemainedAmountForSiege")]
  public long TaxRemainedAmountForSiege { get; set; }

  /// <summary>
  ///   영주가 인출할 수 있는 세금잔량
  /// </summary>
  [Column("_taxRemainedAmountForFortress")]
  public long TaxRemainedAmountForFortress { get; set; }

  /// <summary>
  ///   _taxRemainedAmount이 변경된 시간
  /// </summary>
  [Column("_updateDateOfTaxRemainedAmount", TypeName = "datetime")]
  public DateTime UpdateDateOfTaxRemainedAmount { get; set; }

  /// <summary>
  ///   좋아요수 (약탈게임)
  /// </summary>
  [Column("_like")]
  public long Like { get; set; }

  /// <summary>
  ///   싫어요수 (약탈게임)
  /// </summary>
  [Column("_dislike")]
  public long Dislike { get; set; }
}