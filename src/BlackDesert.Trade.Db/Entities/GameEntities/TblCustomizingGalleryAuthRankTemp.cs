﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblCustomizingGalleryAuthRank_Temp", Schema = "PaWebGamePrivate")]
public class TblCustomizingGalleryAuthRankTemp
{
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_regdate", TypeName = "datetime")]
  public DateTime Regdate { get; set; }

  [Column("_author")]
  [StringLength(30)]
  public string? Author { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_downloadCount")]
  public int DownloadCount { get; set; }

  [Column("_customizingNo")]
  public long CustomizingNo { get; set; }

  [Column("_customizingImage1")]
  [StringLength(200)]
  public string? CustomizingImage1 { get; set; }

  [Column("_customizingImage2")]
  [StringLength(200)]
  public string? CustomizingImage2 { get; set; }

  [Column("_customizingFile")]
  [StringLength(200)]
  public string CustomizingFile { get; set; } = null!;

  [Column("_likeCount")]
  public int LikeCount { get; set; }

  [Column("_commentCount")]
  public long CommentCount { get; set; }

  [Column("_isDelete")]
  public bool IsDelete { get; set; }

  [Column("_isMine")]
  public bool IsMine { get; set; }

  [Column("_crossPlatform")]
  [StringLength(8)]
  public string? CrossPlatform { get; set; }
}