﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblPS4CashInfoLog", Schema = "PaGamePrivate")]
public class TblPs4cashInfoLog
{
  [Column("_logNo")]
  public long LogNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_entitlementId")]
  [StringLength(20)]
  public string EntitlementId { get; set; } = null!;

  [Column("_createdCount")]
  public long CreatedCount { get; set; }

  [Column("_cashProductNo")]
  public int CashProductNo { get; set; }

  [Column("_mailNo")]
  public long MailNo { get; set; }
}