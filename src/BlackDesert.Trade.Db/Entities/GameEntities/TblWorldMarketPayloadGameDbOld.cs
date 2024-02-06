﻿using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblWorldMarketPayloadGameDB_OLD", Schema = "PaGamePrivate")]
public class TblWorldMarketPayloadGameDbOld
{
  [Column("_payload")]
  public long Payload { get; set; }

  [Column("_type")]
  public short Type { get; set; }

  [Column("_state")]
  public short State { get; set; }

  [Column("_nationCode")]
  public int NationCode { get; set; }

  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_keyType")]
  public int KeyType { get; set; }

  [Column("_mainKey")]
  public int MainKey { get; set; }

  [Column("_subKey")]
  public int SubKey { get; set; }

  [Column("_isSealed")]
  public bool IsSealed { get; set; }

  [Column("_param0")]
  public long Param0 { get; set; }

  [Column("_param1")]
  public long Param1 { get; set; }

  [Column("_param2")]
  public long Param2 { get; set; }

  [Column("_param3")]
  public long Param3 { get; set; }

  [Column("_param4")]
  public long Param4 { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_isMovingTradeWeb")]
  public bool IsMovingTradeWeb { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}