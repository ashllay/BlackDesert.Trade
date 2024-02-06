using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   연금(요리) 기록 테이블
/// </summary>
[Keyless]
[Table("TblAlchemyRecord", Schema = "PaGamePrivate")]
public class TblAlchemyRecord
{
  /// <summary>
  ///   기록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   타입(연금,요리)
  /// </summary>
  [Column("_type")]
  public byte Type { get; set; }

  /// <summary>
  ///   지식의키
  /// </summary>
  [Column("_mentalCardKey")]
  public int MentalCardKey { get; set; }

  /// <summary>
  ///   지식을 얻을때 나온 결과 아이템
  /// </summary>
  [Column("_resultItemKey")]
  public int ResultItemKey { get; set; }

  /// <summary>
  ///   아이템키값0
  /// </summary>
  [Column("_itemKey0")]
  public int? ItemKey0 { get; set; }

  /// <summary>
  ///   아이템의갯수0
  /// </summary>
  [Column("_itemCount0")]
  public long? ItemCount0 { get; set; }

  /// <summary>
  ///   아이템키값1
  /// </summary>
  [Column("_itemKey1")]
  public int? ItemKey1 { get; set; }

  /// <summary>
  ///   아이템의갯수1
  /// </summary>
  [Column("_itemCount1")]
  public long? ItemCount1 { get; set; }

  /// <summary>
  ///   아이템키값2
  /// </summary>
  [Column("_itemKey2")]
  public int? ItemKey2 { get; set; }

  /// <summary>
  ///   아이템의갯수2
  /// </summary>
  [Column("_itemCount2")]
  public long? ItemCount2 { get; set; }

  /// <summary>
  ///   아이템키값3
  /// </summary>
  [Column("_itemKey3")]
  public int? ItemKey3 { get; set; }

  /// <summary>
  ///   아이템의갯수3
  /// </summary>
  [Column("_itemCount3")]
  public long? ItemCount3 { get; set; }

  /// <summary>
  ///   아이템키값4
  /// </summary>
  [Column("_itemKey4")]
  public int? ItemKey4 { get; set; }

  /// <summary>
  ///   아이템의갯수4
  /// </summary>
  [Column("_itemCount4")]
  public long? ItemCount4 { get; set; }

  /// <summary>
  ///   아이템키값5
  /// </summary>
  [Column("_itemKey5")]
  public int? ItemKey5 { get; set; }

  /// <summary>
  ///   아이템의갯수5
  /// </summary>
  [Column("_itemCount5")]
  public long? ItemCount5 { get; set; }

  /// <summary>
  ///   아이템키값6
  /// </summary>
  [Column("_itemKey6")]
  public int? ItemKey6 { get; set; }

  /// <summary>
  ///   아이템의갯수6
  /// </summary>
  [Column("_itemCount6")]
  public long? ItemCount6 { get; set; }

  /// <summary>
  ///   아이템키값7
  /// </summary>
  [Column("_itemKey7")]
  public int? ItemKey7 { get; set; }

  /// <summary>
  ///   아이템의갯수7
  /// </summary>
  [Column("_itemCount7")]
  public long? ItemCount7 { get; set; }
}