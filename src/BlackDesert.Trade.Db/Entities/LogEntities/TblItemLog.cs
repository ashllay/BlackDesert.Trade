﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.LogEntities;

[Keyless]
[Table("TblItemLog", Schema = "PaGamePrivate")]
public class TblItemLog
{
  [Column("_logNo")]
  public long LogNo { get; set; }

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

  [Column("_isUserGm")]
  public bool? IsUserGm { get; set; }

  [Column("_playMinuteOfUser")]
  public long? PlayMinuteOfUser { get; set; }

  [Column("_isPcRoom")]
  public bool IsPcRoom { get; set; }

  [Column("_isPcRoomPremium")]
  public bool IsPcRoomPremium { get; set; }

  [Column("_isPvP")]
  public bool? IsPvP { get; set; }

  [Column("_isGuestAccount")]
  public bool? IsGuestAccount { get; set; }

  [Column("_gameAgeGradeType")]
  public byte? GameAgeGradeType { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string? CharacterName { get; set; }

  [Column("_characterNo")]
  public long? CharacterNo { get; set; }

  [Column("_characterLevel")]
  public int? CharacterLevel { get; set; }

  [Column("_characterExperience")]
  public long? CharacterExperience { get; set; }

  [Column("_characterTendency")]
  public int? CharacterTendency { get; set; }

  [Column("_playMinuteOfCharacter")]
  public long? PlayMinuteOfCharacter { get; set; }

  [Column("_currentPositionX")]
  public double? CurrentPositionX { get; set; }

  [Column("_currentPositionY")]
  public double? CurrentPositionY { get; set; }

  [Column("_currentPositionZ")]
  public double? CurrentPositionZ { get; set; }

  [Column("_isDoingSiege")]
  public bool? IsDoingSiege { get; set; }

  [Column("_itemNo")]
  public long ItemNo { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_pushedItemKey0")]
  public int? PushedItemKey0 { get; set; }

  [Column("_pushedItemKey1")]
  public int? PushedItemKey1 { get; set; }

  [Column("_pushedItemKey2")]
  public int? PushedItemKey2 { get; set; }

  [Column("_pushedItemKey3")]
  public int? PushedItemKey3 { get; set; }

  [Column("_pushedItemKey4")]
  public int? PushedItemKey4 { get; set; }

  [Column("_pushedItemKey5")]
  public int? PushedItemKey5 { get; set; }

  [Column("_expirationDate", TypeName = "datetime")]
  public DateTime? ExpirationDate { get; set; }

  [Column("_endurance")]
  public int Endurance { get; set; }

  [Column("_maxEndurance")]
  public int MaxEndurance { get; set; }

  [Column("_itemWhereType")]
  public byte ItemWhereType { get; set; }

  [Column("_variousNo")]
  public long? VariousNo { get; set; }

  [Column("_isFocused")]
  public bool? IsFocused { get; set; }

  [Column("_beforeCount")]
  public long? BeforeCount { get; set; }

  [Column("_variedCount")]
  public long VariedCount { get; set; }

  [Column("_peerCharacterName")]
  [StringLength(30)]
  public string? PeerCharacterName { get; set; }

  [Column("_peerCharacterNo")]
  public long? PeerCharacterNo { get; set; }

  [Column("_peerCharacterKey")]
  public int? PeerCharacterKey { get; set; }

  [Column("_peerCharacterisGm")]
  public bool? PeerCharacterisGm { get; set; }

  [Column("_reason")]
  public short Reason { get; set; }

  [Column("_peerItemNo")]
  public long? PeerItemNo { get; set; }

  [Column("_peerItemWhereType")]
  public byte? PeerItemWhereType { get; set; }

  [Column("_peerVariousNo")]
  public long? PeerVariousNo { get; set; }

  [Column("_param1")]
  public long? Param1 { get; set; }

  [Column("_param2")]
  public long? Param2 { get; set; }

  [Column("_param3")]
  public long? Param3 { get; set; }

  [Column("_param4")]
  public long? Param4 { get; set; }

  [Column("_param5")]
  public long? Param5 { get; set; }

  [Column("_param6")]
  public long? Param6 { get; set; }

  [Column("_textParam1")]
  [StringLength(30)]
  public string? TextParam1 { get; set; }

  [Column("_textParam2")]
  [StringLength(30)]
  public string? TextParam2 { get; set; }

  [Column("_cashProductNo")]
  public int? CashProductNo { get; set; }

  [Column("_cashCount")]
  public long? CashCount { get; set; }

  [Column("_receivingUserId")]
  [StringLength(30)]
  public string? ReceivingUserId { get; set; }

  [Column("_receivingUserNo")]
  public long? ReceivingUserNo { get; set; }

  [Column("_receivingCharacterName")]
  [StringLength(30)]
  public string? ReceivingCharacterName { get; set; }

  [Column("_receivingCharacterNo")]
  public long? ReceivingCharacterNo { get; set; }

  [Column("_receivingMailNo")]
  public long? ReceivingMailNo { get; set; }
}