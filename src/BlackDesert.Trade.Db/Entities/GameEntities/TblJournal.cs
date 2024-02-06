using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   나의 일지 시스템
/// </summary>
[Keyless]
[Table("TblJournal", Schema = "PaGamePrivate")]
public class TblJournal
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   날짜키
  /// </summary>
  [Column("_dateKey")]
  public long DateKey { get; set; }

  /// <summary>
  ///   소유자타입(0 캐릭터,1길드)
  /// </summary>
  [Column("_ownerType")]
  public short OwnerType { get; set; }

  /// <summary>
  ///   캐릭터 번호
  /// </summary>
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  /// <summary>
  ///   캐릭터 이름
  /// </summary>
  [Column("_ownerName")]
  [StringLength(30)]
  public string? OwnerName { get; set; }

  /// <summary>
  ///   UserNo
  /// </summary>
  [Column("_ownerUserNo")]
  public long? OwnerUserNo { get; set; }

  /// <summary>
  ///   가문명
  /// </summary>
  [Column("_ownerNickname")]
  [StringLength(30)]
  public string? OwnerNickname { get; set; }

  /// <summary>
  ///   target 캐릭터 번호
  /// </summary>
  [Column("_targetCharacterNo")]
  public long? TargetCharacterNo { get; set; }

  /// <summary>
  ///   target 캐릭터 이름
  /// </summary>
  [Column("_targetCharacterName")]
  [StringLength(30)]
  public string? TargetCharacterName { get; set; }

  /// <summary>
  ///   target UserNo
  /// </summary>
  [Column("_targetUserNo")]
  public long? TargetUserNo { get; set; }

  /// <summary>
  ///   target 가문명
  /// </summary>
  [Column("_targetUserNickname")]
  [StringLength(30)]
  public string? TargetUserNickname { get; set; }

  /// <summary>
  ///   일지타입(JournalType-0칭호획득, 1 강화성공...)
  /// </summary>
  [Column("_journalType")]
  public short JournalType { get; set; }

  /// <summary>
  ///   위치값
  /// </summary>
  [Column("_positionX")]
  public long? PositionX { get; set; }

  /// <summary>
  ///   위치값
  /// </summary>
  [Column("_positionY")]
  public long? PositionY { get; set; }

  /// <summary>
  ///   위치값
  /// </summary>
  [Column("_positionZ")]
  public long? PositionZ { get; set; }

  /// <summary>
  ///   인자1
  /// </summary>
  [Column("_parameterNo_1")]
  public long ParameterNo1 { get; set; }

  /// <summary>
  ///   인자2
  /// </summary>
  [Column("_parameterNo_2")]
  public int ParameterNo2 { get; set; }

  /// <summary>
  ///   문자열
  /// </summary>
  [Column("_parameterString")]
  [StringLength(50)]
  public string? ParameterString { get; set; }

  /// <summary>
  ///   서버 번호
  /// </summary>
  [Column("_serverNo")]
  public short? ServerNo { get; set; }
}