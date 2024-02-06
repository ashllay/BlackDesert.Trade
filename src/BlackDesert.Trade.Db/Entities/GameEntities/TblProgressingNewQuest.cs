using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   퀘스트 진행 목록
/// </summary>
[PrimaryKey("UserCharacterNo", "IsUserBaseQuest", "QuestGroupNo", "QuestNo")]
[Table("TblProgressingNewQuest", Schema = "PaGamePrivate")]
public class TblProgressingNewQuest
{
  /// <summary>
  ///   1이면 유저 0이면 캐릭터 기반
  /// </summary>
  [Key]
  [Column("_isUserBaseQuest")]
  public bool IsUserBaseQuest { get; set; }

  /// <summary>
  ///   유저,캐릭터번호
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
  ///   _count1
  /// </summary>
  [Column("_count1")]
  public int Count1 { get; set; }

  /// <summary>
  ///   _count2
  /// </summary>
  [Column("_count2")]
  public int Count2 { get; set; }

  /// <summary>
  ///   _count3
  /// </summary>
  [Column("_count3")]
  public int Count3 { get; set; }

  /// <summary>
  ///   _count4
  /// </summary>
  [Column("_count4")]
  public int Count4 { get; set; }

  /// <summary>
  ///   _count5
  /// </summary>
  [Column("_count5")]
  public int Count5 { get; set; }

  /// <summary>
  ///   _orderTime
  /// </summary>
  [Column("_orderTime", TypeName = "datetime")]
  public DateTime OrderTime { get; set; }
}