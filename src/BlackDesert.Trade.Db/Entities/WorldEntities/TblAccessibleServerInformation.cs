using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

/// <summary>
///   유저별 접속가능한 게임서버(채널번호)
/// </summary>
[Keyless]
[Table("TblAccessibleServerInformation", Schema = "PaGamePrivate")]
public class TblAccessibleServerInformation
{
  /// <summary>
  ///   월드 번호
  /// </summary>
  [Column("_worldNo")]
  public short WorldNo { get; set; }

  /// <summary>
  ///   유저 번호
  /// </summary>
  [Column("_userNo")]
  public long UserNo { get; set; }

  /// <summary>
  ///   서버 번호(채널)
  /// </summary>
  [Column("_serverNo")]
  public short? ServerNo { get; set; }

  /// <summary>
  ///   작업중 이라서 이곳으로 접속 가능
  /// </summary>
  [Column("_isWorking")]
  public bool? IsWorking { get; set; }

  /// <summary>
  ///   이 시간이 지나야 채널 이동을 할 수 있다
  /// </summary>
  [Column("_moveableTime", TypeName = "datetime")]
  public DateTime? MoveableTime { get; set; }

  /// <summary>
  ///   이 시간이 지나야 특수 채널 이동을 할 수 있다
  /// </summary>
  [Column("_moveableSpecialChannelTime", TypeName = "datetime")]
  public DateTime? MoveableSpecialChannelTime { get; set; }

  [Column("_serverGroupNo")]
  public short? ServerGroupNo { get; set; }

  [Column("_restrictReason")]
  public byte RestrictReason { get; set; }
}