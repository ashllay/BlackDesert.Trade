using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   연합 정보
/// </summary>
[Keyless]
[Table("TblGuildAllianceInformation", Schema = "PaGamePrivate")]
public class TblGuildAllianceInformation
{
  /// <summary>
  ///   연합 번호
  /// </summary>
  [Column("_allianceNo")]
  public long AllianceNo { get; set; }

  /// <summary>
  ///   연합 이름
  /// </summary>
  [Column("_allianceName")]
  [StringLength(30)]
  public string AllianceName { get; set; } = null!;

  /// <summary>
  ///   마크 등록 시간
  /// </summary>
  [Column("_allianceMarkRegisterTime", TypeName = "datetime")]
  public DateTime? AllianceMarkRegisterTime { get; set; }

  /// <summary>
  ///   기본 정보 동기화 번호
  /// </summary>
  [Column("_allianceBasicSeqNo")]
  public int AllianceBasicSeqNo { get; set; }

  /// <summary>
  ///   마크 동기화 번호
  /// </summary>
  [Column("_allianceMarkSeqNo")]
  public int AllianceMarkSeqNo { get; set; }

  /// <summary>
  ///   연합 마크
  /// </summary>
  [Column("_allianceMark")]
  public byte[]? AllianceMark { get; set; }

  /// <summary>
  ///   연합 공지사항
  /// </summary>
  [Column("_allianceNotice")]
  [StringLength(300)]
  public string? AllianceNotice { get; set; }

  [Column("_allianceType")]
  public byte AllianceType { get; set; }
}