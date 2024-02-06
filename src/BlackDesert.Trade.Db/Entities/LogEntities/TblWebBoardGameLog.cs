using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblWebBoardGameLog", Schema = "PaWebGamePrivate")]
public class TblWebBoardGameLog
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_logType")]
  public byte LogType { get; set; }

  [Column("_operationLogType")]
  public short OperationLogType { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string? UserIp { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_diceValue")]
  public byte DiceValue { get; set; }

  [Column("_startPosition")]
  public byte StartPosition { get; set; }

  [Column("_dicePosition")]
  public byte DicePosition { get; set; }

  [Column("_nowPosition")]
  public byte NowPosition { get; set; }

  [Column("_finishCount")]
  public int FinishCount { get; set; }

  [Column("_todayCount")]
  public byte TodayCount { get; set; }

  [Column("_prizeType")]
  public byte? PrizeType { get; set; }

  [Column("_param0")]
  public long? Param0 { get; set; }

  [Column("_param1")]
  public long? Param1 { get; set; }

  [Column("_param2")]
  public long? Param2 { get; set; }

  [Column("_param3")]
  public long? Param3 { get; set; }

  [Column("_reason")]
  public short Reason { get; set; }
}