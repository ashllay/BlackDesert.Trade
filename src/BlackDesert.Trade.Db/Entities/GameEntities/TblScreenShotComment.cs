using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblScreenShotComment", Schema = "PaWebGamePrivate")]
public class TblScreenShotComment
{
  [Column("_screenNo")]
  public long ScreenNo { get; set; }

  [Key]
  [Column("_screenCommentNo")]
  public long ScreenCommentNo { get; set; }

  [Column("_screenComment")]
  [StringLength(500)]
  public string ScreenComment { get; set; } = null!;

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