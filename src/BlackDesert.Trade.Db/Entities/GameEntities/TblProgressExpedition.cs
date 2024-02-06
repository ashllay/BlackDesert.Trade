using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   토벌테이블
/// </summary>
[Keyless]
[Table("TblProgressExpedition", Schema = "PaGamePrivate")]
public class TblProgressExpedition
{
  /// <summary>
  ///   유저 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  /// <summary>
  ///   유닛 번호
  /// </summary>
  [Column("_unitNo")]
  public long UnitNo { get; set; }

  /// <summary>
  ///   토벌 그룹
  /// </summary>
  [Column("_groupKey")]
  public byte GroupKey { get; set; }

  /// <summary>
  ///   토벌 지역
  /// </summary>
  [Column("_slotIndex")]
  public byte SlotIndex { get; set; }

  /// <summary>
  ///   토벌 등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}