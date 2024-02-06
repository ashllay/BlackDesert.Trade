using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblScreenShot", Schema = "PaWebGamePrivate")]
public class TblScreenShot
{
  [Key]
  [Column("_screenNo")]
  public long ScreenNo { get; set; }

  [Column("_screenImage1")]
  [StringLength(200)]
  public string? ScreenImage1 { get; set; }

  [Column("_screenImage2")]
  [StringLength(200)]
  public string? ScreenImage2 { get; set; }

  [Column("_screenImage3")]
  [StringLength(200)]
  public string? ScreenImage3 { get; set; }

  [Column("_screenImage4")]
  [StringLength(200)]
  public string? ScreenImage4 { get; set; }

  [Column("_screenImage5")]
  [StringLength(200)]
  public string? ScreenImage5 { get; set; }

  [Column("_screenImage6")]
  [StringLength(200)]
  public string? ScreenImage6 { get; set; }

  [Column("_screenThumb")]
  [StringLength(200)]
  public string? ScreenThumb { get; set; }

  [Column("_screenSignImage1")]
  [StringLength(200)]
  public string? ScreenSignImage1 { get; set; }

  [Column("_screenSignImage2")]
  [StringLength(200)]
  public string? ScreenSignImage2 { get; set; }

  [Column("_screenSignImage3")]
  [StringLength(200)]
  public string? ScreenSignImage3 { get; set; }

  [Column("_screenSignImage4")]
  [StringLength(200)]
  public string? ScreenSignImage4 { get; set; }

  [Column("_screenSignImage5")]
  [StringLength(200)]
  public string? ScreenSignImage5 { get; set; }

  [Column("_screenSignImage6")]
  [StringLength(200)]
  public string? ScreenSignImage6 { get; set; }

  [Column("_screenTitle")]
  [StringLength(50)]
  public string ScreenTitle { get; set; } = null!;

  [Column("_screenDescription")]
  [StringLength(4000)]
  public string? ScreenDescription { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_viewCount")]
  public long ViewCount { get; set; }

  [Column("_commentCount")]
  public long CommentCount { get; set; }

  [Column("_likeCount")]
  public int LikeCount { get; set; }

  [Column("_regdate", TypeName = "datetime")]
  public DateTime Regdate { get; set; }

  [Column("_category")]
  public byte Category { get; set; }

  [Column("_isMine")]
  public bool IsMine { get; set; }

  [Column("_isDelete")]
  public bool IsDelete { get; set; }

  [Column("_isSignature")]
  public bool IsSignature { get; set; }
}