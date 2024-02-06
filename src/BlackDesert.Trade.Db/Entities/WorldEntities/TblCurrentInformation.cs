using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   현재정보
/// </summary>
[PrimaryKey("WorldNo", "ServerNo", "UpdatedDate")]
[Table("TblCurrentInformation", Schema = "PaGamePrivate")]
public class TblCurrentInformation
{
  /// <summary>
  ///   수정시간
  /// </summary>
  [Key]
  [Column("_updatedDate", TypeName = "datetime")]
  public DateTime UpdatedDate { get; set; }

  /// <summary>
  ///   월드번호
  /// </summary>
  [Key]
  [Column("_worldNo")]
  public short WorldNo { get; set; }

  /// <summary>
  ///   서버번호
  /// </summary>
  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   총세션수
  /// </summary>
  [Column("_totalSessionCount")]
  public int TotalSessionCount { get; set; }

  /// <summary>
  ///   사용중인 세션수
  /// </summary>
  [Column("_busySessionCount")]
  public int BusySessionCount { get; set; }

  /// <summary>
  ///   ID PW는 맞는데 아직 필드 진입하지 않은 수
  /// </summary>
  [Column("_loginningUserCount")]
  public int LoginningUserCount { get; set; }

  /// <summary>
  ///   플레이중인 이용자 수
  /// </summary>
  [Column("_playingUserCount")]
  public int PlayingUserCount { get; set; }

  [Column("_pcRoomUserCount")]
  public int PcRoomUserCount { get; set; }
}