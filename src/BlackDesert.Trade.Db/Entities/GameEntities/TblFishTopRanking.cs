using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   낚시 TOP 랭킹
/// </summary>
[PrimaryKey("EncyclopediaKey", "UserNo")]
[Table("TblFishTopRanking", Schema = "PaGamePrivate")]
public class TblFishTopRanking
{
  /// <summary>
  ///   낚은 시간
  /// </summary>
  [Column("_lastUpdateDate", TypeName = "datetime")]
  public DateTime LastUpdateDate { get; set; }

  /// <summary>
  ///   어류도감 키
  /// </summary>
  [Key]
  [Column("_encyclopediaKey")]
  public int EncyclopediaKey { get; set; }

  /// <summary>
  ///   어류도감 키
  /// </summary>
  [Column("_fishLength")]
  public int FishLength { get; set; }

  /// <summary>
  ///   _positionX
  /// </summary>
  [Column("_positionX")]
  public long PositionX { get; set; }

  /// <summary>
  ///   _positionY
  /// </summary>
  [Column("_positionY")]
  public long PositionY { get; set; }

  /// <summary>
  ///   _positionZ
  /// </summary>
  [Column("_positionZ")]
  public long PositionZ { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   캐릭터명
  /// </summary>
  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  /// <summary>
  ///   가문명
  /// </summary>
  [Column("_userNickname")]
  [StringLength(30)]
  public string? UserNickname { get; set; }
}