using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCompositionNotes", Schema = "PaWebGamePrivate")]
public class TblCompositionNote
{
  [Key]
  [Column("_noteNo")]
  public long NoteNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_noteTitle")]
  [StringLength(100)]
  public string NoteTitle { get; set; } = null!;

  [Column("_noteContent")]
  [StringLength(3000)]
  public string NoteContent { get; set; } = null!;

  [Column("_musicTitle")]
  [StringLength(300)]
  public string MusicTitle { get; set; } = null!;

  [Column("_musicOwn")]
  [StringLength(60)]
  public string MusicOwn { get; set; } = null!;

  [Column("_musicTime")]
  public TimeSpan MusicTime { get; set; }

  [Column("_musicPath")]
  [StringLength(500)]
  public string MusicPath { get; set; } = null!;

  [Column("_isDownload")]
  public bool IsDownload { get; set; }

  [Column("_isAdventurer")]
  public bool IsAdventurer { get; set; }

  [Column("_isBlind")]
  public byte IsBlind { get; set; }

  [Column("_regDate")]
  public DateTime RegDate { get; set; }

  [Column("_updDate")]
  public DateTime UpdDate { get; set; }

  [Column("_instrument")]
  [StringLength(100)]
  [Unicode(false)]
  public string? Instrument { get; set; }

  [Column("_rank")]
  [StringLength(30)]
  [Unicode(false)]
  public string? Rank { get; set; }

  [Column("_heartCount")]
  public int HeartCount { get; set; }

  [Column("_starCount")]
  public int StarCount { get; set; }

  [Column("_playCount")]
  public int PlayCount { get; set; }

  [Column("_downloadCount")]
  public int DownloadCount { get; set; }

  [Column("_replyCount")]
  public int ReplyCount { get; set; }

  [Required]
  [Column("_isEdit")]
  public bool? IsEdit { get; set; }

  [Column("_userNickname")]
  [StringLength(60)]
  public string UserNickname { get; set; } = null!;
}