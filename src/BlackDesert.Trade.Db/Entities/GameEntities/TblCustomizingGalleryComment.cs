using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCustomizingGalleryComment", Schema = "PaWebGamePrivate")]
public class TblCustomizingGalleryComment
{
  [Column("_customizingNo")]
  public long CustomizingNo { get; set; }

  [Key]
  [Column("_customizingCommentNo")]
  public long CustomizingCommentNo { get; set; }

  [Column("_customizingComment")]
  [StringLength(500)]
  public string CustomizingComment { get; set; } = null!;

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

  [Column("_commentReportCount")]
  public int CommentReportCount { get; set; }

  [Column("_CommentRegdate", TypeName = "datetime")]
  public DateTime CommentRegdate { get; set; }

  [Column("_CommentUpdateDate", TypeName = "datetime")]
  public DateTime CommentUpdateDate { get; set; }

  [Column("_isBlind")]
  public bool IsBlind { get; set; }

  [Column("_isDelete")]
  public bool IsDelete { get; set; }
}