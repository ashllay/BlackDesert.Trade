using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   길드 스킬 정보
/// </summary>
[PrimaryKey("GuildNo", "SkillNo")]
[Table("TblGuildSkill", Schema = "PaGamePrivate")]
public class TblGuildSkill
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   길드번호
  /// </summary>
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   습득한 길드 스킬 번호
  /// </summary>
  [Key]
  [Column("_skillNo")]
  public int SkillNo { get; set; }

  /// <summary>
  ///   습득한 길드 스킬 레벨
  /// </summary>
  [Column("_skillLevel")]
  public int SkillLevel { get; set; }

  /// <summary>
  ///   스킬을 활성한 시킨 유저 정보
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }
}