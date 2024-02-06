using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   블록 통합 테이블
/// </summary>
[Keyless]
[Table("TblBlockByKeyOrUserNo", Schema = "PaGamePrivate")]
public class TblBlockByKeyOrUserNo
{
  /// <summary>
  ///   등록일
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_registerUserNo")]
  public long? RegisterUserNo { get; set; }

  [Column("_blockNo")]
  public long BlockNo { get; set; }

  /// <summary>
  ///   블록 타입 - BlockedTbl.proc.sql에 기록
  /// </summary>
  [Column("_type")]
  public int Type { get; set; }

  [Column("_param1")]
  public long? Param1 { get; set; }

  [Column("_param2")]
  public long? Param2 { get; set; }

  [Column("_param3")]
  public long? Param3 { get; set; }

  [Column("_memo")]
  [StringLength(200)]
  public string? Memo { get; set; }
}