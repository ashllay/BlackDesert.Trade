using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   IP 블록 테이블
/// </summary>
[Table("TblBlockedIP", Schema = "PaGamePrivate")]
public class TblBlockedIp
{
  /// <summary>
  ///   블록 고유 번호
  /// </summary>
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  /// <summary>
  ///   등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   IP 대역 시작점 NVARCHAR형
  /// </summary>
  [Column("_startIP")]
  [StringLength(15)]
  public string StartIp { get; set; } = null!;

  /// <summary>
  ///   IP 대역 시작점 BIGINT형
  /// </summary>
  [Column("_bigintStartIP")]
  public long BigintStartIp { get; set; }

  /// <summary>
  ///   IP 대역 시작점 NVARCHAR형
  /// </summary>
  [Column("_endIP")]
  [StringLength(15)]
  public string EndIp { get; set; } = null!;

  /// <summary>
  ///   IP 대역 시작점 BIGINT형
  /// </summary>
  [Column("_bigintEndIP")]
  public long BigintEndIp { get; set; }

  /// <summary>
  ///   블록 사유 코드
  /// </summary>
  [Column("_blockCode")]
  public int BlockCode { get; set; }

  /// <summary>
  ///   블록 운영자 메모
  /// </summary>
  [Column("_operationMemo")]
  [StringLength(200)]
  public string OperationMemo { get; set; } = null!;
}