using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   퀘스트 완료 목록
/// </summary>
[PrimaryKey("UserCharacterNo", "IsUserBaseQuest", "QuestGroupNo", "QuestNo")]
[Table("TblClearedNewQuest", Schema = "PaGamePrivate")]
public class TblClearedNewQuest
{
  /// <summary>
  ///   1이면 유저 0이면 캐릭터 기반
  /// </summary>
  [Key]
  [Column("_isUserBaseQuest")]
  public bool IsUserBaseQuest { get; set; }

  /// <summary>
  ///   유저캐릭터번호
  /// </summary>
  [Key]
  [Column("_userCharacterNo")]
  public long UserCharacterNo { get; set; }

  /// <summary>
  ///   _questGroupNo
  /// </summary>
  [Key]
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  /// <summary>
  ///   퀘스트번호
  /// </summary>
  [Key]
  [Column("_questNo")]
  public int QuestNo { get; set; }

  /// <summary>
  ///   반복 퀘스트일 경우 초기화될 시간
  /// </summary>
  [Column("_resetTime", TypeName = "datetime")]
  public DateTime? ResetTime { get; set; }

  /// <summary>
  ///   쾌스트 완료 시간
  /// </summary>
  [Column("_clearedTime", TypeName = "datetime")]
  public DateTime ClearedTime { get; set; }

  [Column("_isHideQuestCount")]
  public bool IsHideQuestCount { get; set; }
}