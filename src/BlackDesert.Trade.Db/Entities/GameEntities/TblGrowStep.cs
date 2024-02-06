using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   성장 단계 테이블
/// </summary>
[PrimaryKey("UserNo", "GrowStepKey")]
[Table("TblGrowStep", Schema = "PaGamePrivate")]
public class TblGrowStep
{
  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   성장 단계 키
  /// </summary>
  [Key]
  [Column("_growStepKey")]
  public short GrowStepKey { get; set; }

  /// <summary>
  ///   성장 단계 오픈여부
  /// </summary>
  [Column("_isOpen")]
  public bool IsOpen { get; set; }
}