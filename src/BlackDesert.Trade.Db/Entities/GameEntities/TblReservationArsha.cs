using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

/// <summary>
///   아르샤의 창 예약
/// </summary>
[PrimaryKey("ReservationDay", "ServerNo")]
[Table("TblReservationArsha", Schema = "PaGamePrivate")]
public class TblReservationArsha
{
  /// <summary>
  ///   예약 채널 번호
  /// </summary>
  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  /// <summary>
  ///   예약 등록시간
  /// </summary>
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  /// <summary>
  ///   예약일
  /// </summary>
  [Key]
  [Column("_reservationDay", TypeName = "datetime")]
  public DateTime ReservationDay { get; set; }

  /// <summary>
  ///   예약 길드 번호
  /// </summary>
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  /// <summary>
  ///   예약 길드 이름
  /// </summary>
  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;
}