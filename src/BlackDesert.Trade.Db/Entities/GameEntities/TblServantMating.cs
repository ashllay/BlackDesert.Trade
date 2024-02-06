using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   말 교배 정보
/// </summary>
[Table("TblServantMating", Schema = "PaGamePrivate")]
public class TblServantMating
{
  /// <summary>
  ///   교배 고유 번호
  /// </summary>
  [Key]
  [Column("_matingNo")]
  public long MatingNo { get; set; }

  /// <summary>
  ///   교배 시작 시간
  /// </summary>
  [Column("_startDate", TypeName = "datetime")]
  public DateTime StartDate { get; set; }

  /// <summary>
  ///   교배 종료 시간
  /// </summary>
  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }

  /// <summary>
  ///   암컷 말 고유 번호
  /// </summary>
  [Column("_femaleServantNo")]
  public long FemaleServantNo { get; set; }

  /// <summary>
  ///   수컷 말 고유 번호
  /// </summary>
  [Column("_maleServantNo")]
  public long MaleServantNo { get; set; }

  /// <summary>
  ///   망아지 캐릭터 키
  /// </summary>
  [Column("_childCharacterKey")]
  public int ChildCharacterKey { get; set; }

  /// <summary>
  ///   수컷 말 종마 구분
  /// </summary>
  [Column("_isMaleStallion")]
  public bool? IsMaleStallion { get; set; }
}