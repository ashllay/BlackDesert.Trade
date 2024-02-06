using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유저부가정보
/// </summary>
[Table("TblUserEtcInformation", Schema = "PaGamePrivate")]
public class TblUserEtcInformation
{
  /// <summary>
  ///   생성일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   _userNo
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   _cpuBrandString
  /// </summary>
  [Column("_cpuBrandString")]
  [StringLength(50)]
  [Unicode(false)]
  public string? CpuBrandString { get; set; }

  /// <summary>
  ///   _totalSystemMemory
  /// </summary>
  [Column("_totalSystemMemory")]
  public int TotalSystemMemory { get; set; }

  /// <summary>
  ///   _graphicsAdapterBrandString
  /// </summary>
  [Column("_graphicsAdapterBrandString")]
  [StringLength(50)]
  [Unicode(false)]
  public string? GraphicsAdapterBrandString { get; set; }

  /// <summary>
  ///   _resoulutionWidth
  /// </summary>
  [Column("_resoulutionWidth")]
  public int ResoulutionWidth { get; set; }

  /// <summary>
  ///   _resoulutionHeight
  /// </summary>
  [Column("_resoulutionHeight")]
  public int ResoulutionHeight { get; set; }

  /// <summary>
  ///   _textureQuality
  /// </summary>
  [Column("_textureQuality")]
  public byte TextureQuality { get; set; }

  /// <summary>
  ///   _graphicOption
  /// </summary>
  [Column("_graphicOption")]
  public byte GraphicOption { get; set; }

  [Required]
  [Column("_consoleCrossPlayOption")]
  public bool? ConsoleCrossPlayOption { get; set; }
}