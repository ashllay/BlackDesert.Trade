using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   탐험 &amp; 탐험과 연계되는 컨텐츠 저장소
/// </summary>
[PrimaryKey("UserNo", "Type", "SubType", "WaypointKey")]
[Table("TblPlantRepository", Schema = "PaGamePrivate")]
public class TblPlantRepository
{
  /// <summary>
  ///   _registerDate
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   사용자번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   대상 노드의 WaypointKey
  /// </summary>
  [Key]
  [Column("_waypointKey")]
  public int WaypointKey { get; set; }

  /// <summary>
  ///   _type 별로 의미가 다르다
  /// </summary>
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   _subType
  /// </summary>
  [Key]
  [Column("_subType")]
  public int SubType { get; set; }

  /// <summary>
  ///   _value
  /// </summary>
  [Column("_value")]
  public short Value { get; set; }

  [Column("_experience")]
  public long Experience { get; set; }

  /// <summary>
  ///   업그레이드가 완료될 시각
  /// </summary>
  [Column("_dateTime", TypeName = "datetime")]
  public DateTime DateTime { get; set; }
}