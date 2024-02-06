using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저캐릭 메모
/// </summary>
[Table("TblCharacterMemo", Schema = "PaGamePrivate")]
public class TblCharacterMemo
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   현재 수행중이던 퀘스트 그룹번호
  /// </summary>
  [Column("_currentQuestGroupNo")]
  public int? CurrentQuestGroupNo { get; set; }

  /// <summary>
  ///   현재 수행중이던 퀘스트 번호
  /// </summary>
  [Column("_currentQuestNo")]
  public int? CurrentQuestNo { get; set; }

  /// <summary>
  ///   마지막 수행중이던 퀘스트 그룹번호
  /// </summary>
  [Column("_lastQuestGroupNo0")]
  public int? LastQuestGroupNo0 { get; set; }

  /// <summary>
  ///   마지막 수행중이던 퀘스트 번호
  /// </summary>
  [Column("_lastQuestNo0")]
  public int? LastQuestNo0 { get; set; }

  /// <summary>
  ///   마지막-1 수행중이던 퀘스트 그룹번호
  /// </summary>
  [Column("_lastQuestGroupNo1")]
  public int? LastQuestGroupNo1 { get; set; }

  /// <summary>
  ///   마지막-1 수행중이던 퀘스트 번호
  /// </summary>
  [Column("_lastQuestNo1")]
  public int? LastQuestNo1 { get; set; }

  /// <summary>
  ///   OdbcUserMemo와 연결됨
  /// </summary>
  [Column("_memo")]
  [StringLength(300)]
  public string? Memo { get; set; }

  /// <summary>
  ///   아이템 교환 길찾기 중이던 ItemEnchantKey
  /// </summary>
  [Column("_currentFindExchangeItemEnchantKey")]
  public int? CurrentFindExchangeItemEnchantKey { get; set; }

  /// <summary>
  ///   현재 수행중이던 퀘스트 좌표
  /// </summary>
  [Column("_currentQuestPositionX")]
  public float? CurrentQuestPositionX { get; set; }

  /// <summary>
  ///   현재 수행중이던 퀘스트 좌표
  /// </summary>
  [Column("_currentQuestPositionY")]
  public float? CurrentQuestPositionY { get; set; }

  /// <summary>
  ///   현재 수행중이던 퀘스트 좌표
  /// </summary>
  [Column("_currentQuestPositionZ")]
  public float? CurrentQuestPositionZ { get; set; }

  /// <summary>
  ///   현재 유저가 설정한 목표 좌표
  /// </summary>
  [Column("_userTargetPositionX")]
  public float? UserTargetPositionX { get; set; }

  /// <summary>
  ///   현재 유저가 설정한 목표 좌표
  /// </summary>
  [Column("_userTargetPositionY")]
  public float? UserTargetPositionY { get; set; }

  /// <summary>
  ///   현재 유저가 설정한 목표 좌표
  /// </summary>
  [Column("_userTargetPositionZ")]
  public float? UserTargetPositionZ { get; set; }
}