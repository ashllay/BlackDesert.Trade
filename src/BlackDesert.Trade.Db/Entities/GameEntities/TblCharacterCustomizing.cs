using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   캐릭터 커스터마이징
/// </summary>
[Table("TblCharacterCustomizing", Schema = "PaGamePrivate")]
public class TblCharacterCustomizing
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   별자리 키
  /// </summary>
  [Column("_zodiacSignKey")]
  public byte ZodiacSignKey { get; set; }

  /// <summary>
  ///   두상 모양
  /// </summary>
  [Column("_headMesh")]
  public byte HeadMesh { get; set; }

  /// <summary>
  ///   헤어 스타일
  /// </summary>
  [Column("_hairMesh")]
  public byte HairMesh { get; set; }

  [Column("_extra0")]
  public byte Extra0 { get; set; }

  [Column("_extra1")]
  public byte Extra1 { get; set; }

  [Column("_extra2")]
  public byte Extra2 { get; set; }

  [Column("_extra3")]
  public byte Extra3 { get; set; }

  /// <summary>
  ///   뼈대
  /// </summary>
  [Column("_bone")]
  [MaxLength(660)]
  public byte[]? Bone { get; set; }

  /// <summary>
  ///   장식
  /// </summary>
  [Column("_decoration")]
  [MaxLength(130)]
  public byte[]? Decoration { get; set; }

  /// <summary>
  ///   표정
  /// </summary>
  [Column("_expression")]
  [MaxLength(2)]
  public byte[] Expression { get; set; } = null!;

  [Column("_voiceType")]
  public long VoiceType { get; set; }

  /// <summary>
  ///   원저작자
  /// </summary>
  [Column("_author")]
  [StringLength(30)]
  public string? Author { get; set; }

  /// <summary>
  ///   캐릭터 커스터마이징 버전
  /// </summary>
  [Column("_version")]
  public int Version { get; set; }

  [Column("_authorUserNo")]
  public long AuthorUserNo { get; set; }

  [Required]
  [Column("_isEditable")]
  public bool? IsEditable { get; set; }

  [Column("_decorationRGB")]
  [MaxLength(12)]
  public byte[]? DecorationRgb { get; set; }
}