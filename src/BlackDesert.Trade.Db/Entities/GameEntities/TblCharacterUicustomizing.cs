using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   유저 캐릭을 위한 UI Customizing정보
/// </summary>
[Table("TblCharacterUICustomizing", Schema = "PaGamePrivate")]
public class TblCharacterUicustomizing
{
  /// <summary>
  ///   캐릭터번호
  /// </summary>
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   퀵슬롯 데이터
  /// </summary>
  [Column("_quickSlotSerializedData")]
  [StringLength(756)]
  [Unicode(false)]
  public string QuickSlotSerializedData { get; set; } = null!;

  /// <summary>
  ///   퀘스트 데이터
  /// </summary>
  [Column("_questSerializedData")]
  [StringLength(300)]
  [Unicode(false)]
  public string QuestSerializedData { get; set; } = null!;

  /// <summary>
  ///   퀘스트 선택 타입
  /// </summary>
  [Column("_questSelectType")]
  [StringLength(18)]
  [Unicode(false)]
  public string QuestSelectType { get; set; } = null!;

  /// <summary>
  ///   퀘스트 정렬 타입
  /// </summary>
  [Column("_questSortType")]
  [StringLength(9)]
  [Unicode(false)]
  public string QuestSortType { get; set; } = null!;
}