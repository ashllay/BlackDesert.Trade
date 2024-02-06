using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   번역신고
/// </summary>
[Table("TblTranslationReport", Schema = "PaGamePrivate")]
public class TblTranslationReport
{
  /// <summary>
  ///   신고일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   신고글의 고유 번호
  /// </summary>
  [Key]
  [Column("_reportNo")]
  public long ReportNo { get; set; }

  /// <summary>
  ///   언어 타입
  /// </summary>
  [Column("_serviceResourceType")]
  public byte ServiceResourceType { get; set; }

  /// <summary>
  ///   번역키
  /// </summary>
  [Column("_staticType")]
  public short StaticType { get; set; }

  /// <summary>
  ///   번역키
  /// </summary>
  [Column("_translationKey1")]
  public int TranslationKey1 { get; set; }

  /// <summary>
  ///   번역키
  /// </summary>
  [Column("_translationKey2")]
  public short TranslationKey2 { get; set; }

  /// <summary>
  ///   번역키
  /// </summary>
  [Column("_translationKey3")]
  public short TranslationKey3 { get; set; }

  /// <summary>
  ///   번역키
  /// </summary>
  [Column("_textNo")]
  public short TextNo { get; set; }

  /// <summary>
  ///   유저 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   바꾸고자 하는 번역 내용
  /// </summary>
  [Column("_translationText")]
  [StringLength(2000)]
  public string TranslationText { get; set; } = null!;

  /// <summary>
  ///   추천수
  /// </summary>
  [Column("_recommendCount")]
  public short RecommendCount { get; set; }
}