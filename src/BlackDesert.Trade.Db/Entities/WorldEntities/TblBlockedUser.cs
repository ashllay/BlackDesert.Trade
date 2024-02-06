using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   운영 관련 그룹의 역할 테이블
/// </summary>
[Table("TblBlockedUser", Schema = "PaGamePrivate")]
public class TblBlockedUser
{
  /// <summary>
  ///   블록 고유 번호
  /// </summary>
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  /// <summary>
  ///   블록 등록 시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

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

  [Column("_macAddress")]
  [MaxLength(64)]
  public byte[]? MacAddress { get; set; }

  [Column("_macAddressString")]
  [StringLength(255)]
  [Unicode(false)]
  public string? MacAddressString { get; set; }

  [Column("_guid")]
  [StringLength(255)]
  [Unicode(false)]
  public string? Guid { get; set; }

  [Column("_diskUUID")]
  [StringLength(255)]
  [Unicode(false)]
  public string? DiskUuid { get; set; }

  [Column("_ipAddress")]
  [StringLength(255)]
  [Unicode(false)]
  public string? IpAddress { get; set; }

  [Column("_machineGuid")]
  [StringLength(255)]
  [Unicode(false)]
  public string? MachineGuid { get; set; }

  [Column("_macAddressList")]
  [StringLength(5000)]
  [Unicode(false)]
  public string? MacAddressList { get; set; }

  [Column("_userName")]
  [StringLength(64)]
  [Unicode(false)]
  public string? UserName { get; set; }
}