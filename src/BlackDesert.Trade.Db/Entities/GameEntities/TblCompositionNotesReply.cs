using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCompositionNotesReply", Schema = "PaWebGamePrivate")]
public class TblCompositionNotesReply
{
  [Key]
  [Column("_replyNo")]
  public long ReplyNo { get; set; }

  [Column("_noteNo")]
  public long NoteNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_replyContent")]
  [StringLength(500)]
  public string ReplyContent { get; set; } = null!;

  [Column("_replyOrder")]
  public short ReplyOrder { get; set; }

  [Column("_isBlind")]
  public byte IsBlind { get; set; }

  [Column("_regDate")]
  public DateTime RegDate { get; set; }

  [Column("_updDate")]
  public DateTime UpdDate { get; set; }

  [Column("_userNickname")]
  [StringLength(60)]
  public string UserNickname { get; set; } = null!;
}