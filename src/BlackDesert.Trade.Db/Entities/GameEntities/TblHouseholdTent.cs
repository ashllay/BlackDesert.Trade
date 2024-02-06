using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   하우징 하우스홀드 텐트 테이블
/// </summary>
[Table("TblHouseholdTent", Schema = "PaGamePrivate")]
public class TblHouseholdTent
{
  /// <summary>
  ///   _householdNo
  /// </summary>
  [Key]
  [Column("_householdNo")]
  public long HouseholdNo { get; set; }

  /// <summary>
  ///   아이템번호(아이템테이블과 연결)
  /// </summary>
  [Column("_itemNo")]
  public long ItemNo { get; set; }

  /// <summary>
  ///   설치하기 전에 사용한 텐트 아이템 키
  /// </summary>
  [Column("_itemKey")]
  public int ItemKey { get; set; }

  /// <summary>
  ///   _fieldNo
  /// </summary>
  [Column("_fieldNo")]
  public short FieldNo { get; set; }

  /// <summary>
  ///   _fieldIndex
  /// </summary>
  [Column("_fieldIndex")]
  public short FieldIndex { get; set; }

  /// <summary>
  ///   _posX
  /// </summary>
  [Column("_posX")]
  public float PosX { get; set; }

  /// <summary>
  ///   _posY
  /// </summary>
  [Column("_posY")]
  public float PosY { get; set; }

  /// <summary>
  ///   _posZ
  /// </summary>
  [Column("_posZ")]
  public float PosZ { get; set; }

  /// <summary>
  ///   _dirX
  /// </summary>
  [Column("_dirX")]
  public double DirX { get; set; }

  /// <summary>
  ///   _dirY
  /// </summary>
  [Column("_dirY")]
  public double DirY { get; set; }

  /// <summary>
  ///   _dirZ
  /// </summary>
  [Column("_dirZ")]
  public double DirZ { get; set; }

  [Column("_territoryKey")]
  public long TerritoryKey { get; set; }

  /// <summary>
  ///   _buildProgressPoint0
  /// </summary>
  [Column("_buildProgressPoint0")]
  public int BuildProgressPoint0 { get; set; }

  /// <summary>
  ///   _buildProgressPoint1
  /// </summary>
  [Column("_buildProgressPoint1")]
  public int BuildProgressPoint1 { get; set; }

  /// <summary>
  ///   _buildProgressPoint2
  /// </summary>
  [Column("_buildProgressPoint2")]
  public int BuildProgressPoint2 { get; set; }

  /// <summary>
  ///   _buildProgressPoint3
  /// </summary>
  [Column("_buildProgressPoint3")]
  public int BuildProgressPoint3 { get; set; }

  /// <summary>
  ///   _buildProgressPoint4
  /// </summary>
  [Column("_buildProgressPoint4")]
  public int BuildProgressPoint4 { get; set; }

  [Column("_buildGuildNo")]
  public long? BuildGuildNo { get; set; }

  [Column("_buildCreatedDate", TypeName = "datetime")]
  public DateTime BuildCreatedDate { get; set; }

  [Column("_buildCompletedDate", TypeName = "datetime")]
  public DateTime? BuildCompletedDate { get; set; }

  [Column("_buildDestroyedDate", TypeName = "datetime")]
  public DateTime? BuildDestroyedDate { get; set; }

  [Column("_buildDestroyerGuildNo")]
  public long? BuildDestroyerGuildNo { get; set; }

  /// <summary>
  ///   _growingRate0
  /// </summary>
  [Column("_growingRate0")]
  public int GrowingRate0 { get; set; }

  /// <summary>
  ///   _growingRate1
  /// </summary>
  [Column("_growingRate1")]
  public int GrowingRate1 { get; set; }

  /// <summary>
  ///   _growingRate2
  /// </summary>
  [Column("_growingRate2")]
  public int GrowingRate2 { get; set; }

  /// <summary>
  ///   설치한 곳의 지역 키
  /// </summary>
  [Column("_buildRegionKey")]
  public int? BuildRegionKey { get; set; }

  /// <summary>
  ///   지역의 세금 단계
  /// </summary>
  [Column("_regionTaxLevel")]
  public byte? RegionTaxLevel { get; set; }

  /// <summary>
  ///   파괴한 캐릭터 번호
  /// </summary>
  [Column("_destroyerCharacterNo")]
  public long? DestroyerCharacterNo { get; set; }

  /// <summary>
  ///   파괴한 캐릭터 명
  /// </summary>
  [Column("_destroyerCharacterName")]
  [StringLength(30)]
  public string? DestroyerCharacterName { get; set; }
}