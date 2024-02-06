using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblBlockedItemLog", Schema = "PaGamePrivate")]
public class TblBlockedItemLog
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_detachDate", TypeName = "datetime")]
  public DateTime? DetachDate { get; set; }

  [Column("_blockNo")]
  public long? BlockNo { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_reasonMemo")]
  [StringLength(200)]
  public string? ReasonMemo { get; set; }

  [Column("_attachUserNo")]
  public long? AttachUserNo { get; set; }

  [Column("_detachUserNo")]
  public long? DetachUserNo { get; set; }

  [Column("_actionType")]
  public bool? ActionType { get; set; }
}