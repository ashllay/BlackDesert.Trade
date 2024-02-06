using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCustomizingGallery", Schema = "PaWebGamePrivate")]
public class TblCustomizingGallery
{
  [Key]
  [Column("_customizingNo")]
  public long CustomizingNo { get; set; }

  [Column("_customizingCategoryCode")]
  public int CustomizingCategoryCode { get; set; }

  [Column("_customizingImage1")]
  [StringLength(200)]
  public string? CustomizingImage1 { get; set; }

  [Column("_customizingImage2")]
  [StringLength(200)]
  public string? CustomizingImage2 { get; set; }

  [Column("_customizingFile")]
  [StringLength(200)]
  public string CustomizingFile { get; set; } = null!;

  [Column("_customizingTitle")]
  [StringLength(50)]
  public string CustomizingTitle { get; set; } = null!;

  [Column("_customizingDescription")]
  [StringLength(4000)]
  public string? CustomizingDescription { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_viewCount")]
  public long ViewCount { get; set; }

  [Column("_commentCount")]
  public long CommentCount { get; set; }

  [Column("_downloadCount")]
  public int DownloadCount { get; set; }

  [Column("_regdate", TypeName = "datetime")]
  public DateTime Regdate { get; set; }

  [Column("_updateDate", TypeName = "datetime")]
  public DateTime UpdateDate { get; set; }

  [Column("_isMine")]
  public bool IsMine { get; set; }

  [Column("_isDelete")]
  public bool IsDelete { get; set; }

  [Column("_isRandom")]
  public bool IsRandom { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }

  [Column("_author")]
  [StringLength(30)]
  public string? Author { get; set; }

  [Column("_crossPlatform")]
  [StringLength(8)]
  public string? CrossPlatform { get; set; }

  [Required]
  [Column("_isEdit")]
  public bool? IsEdit { get; set; }

  [Column("_likeCount")]
  public int LikeCount { get; set; }
}