using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   운영 관련 그룹의 역할 테이블
/// </summary>
[Table("TblBlockedChat", Schema = "PaGamePrivate")]
public class TblBlockedChat
{
  /// <summary>
  ///   블록 등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   블록 고유 번호
  /// </summary>
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  /// <summary>
  ///   블록 유저 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   블록 종료 시간
  /// </summary>
  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }

  /// <summary>
  ///   블록 사유
  /// </summary>
  [Column("_reasonMemo")]
  [StringLength(200)]
  public string ReasonMemo { get; set; } = null!;
}