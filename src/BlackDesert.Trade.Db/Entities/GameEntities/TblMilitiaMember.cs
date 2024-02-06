using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   민병대 정보
/// </summary>
[Keyless]
[Table("TblMilitiaMember", Schema = "PaGamePrivate")]
public class TblMilitiaMember
{
  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_territoryKey")]
  public int TerritoryKey { get; set; }

  /// <summary>
  ///   유저 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  /// <summary>
  ///   길드 번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   공격 팀 신청
  /// </summary>
  [Column("_isAttackTeam")]
  public bool? IsAttackTeam { get; set; }

  /// <summary>
  ///   신청 상태
  /// </summary>
  [Column("_state")]
  public byte State { get; set; }

  /// <summary>
  ///   공방 합
  /// </summary>
  [Column("_adSummary")]
  public int AdSummary { get; set; }
}