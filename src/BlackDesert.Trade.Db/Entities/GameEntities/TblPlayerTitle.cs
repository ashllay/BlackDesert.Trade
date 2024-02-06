using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   칭호 시스템
/// </summary>
[PrimaryKey("UserNo", "Key")]
[Table("TblPlayerTitle", Schema = "PaGamePrivate")]
public class TblPlayerTitle
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   유저번호
  /// </summary>
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   칭호 키
  /// </summary>
  [Key]
  [Column("_key")]
  public int Key { get; set; }

  /// <summary>
  ///   칭호 카운트
  /// </summary>
  [Column("_count")]
  public int Count { get; set; }

  /// <summary>
  ///   칭호 획득 여부
  /// </summary>
  [Column("_isAcquired")]
  public bool IsAcquired { get; set; }

  /// <summary>
  ///   칭호 종료시간
  /// </summary>
  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }
}