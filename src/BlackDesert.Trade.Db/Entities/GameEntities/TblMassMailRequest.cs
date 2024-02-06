using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMassMailRequest", Schema = "PaOperationPublic")]
public class TblMassMailRequest
{
  [Column("_mailRequestNo")]
  public long MailRequestNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_isAllUser")]
  public bool? IsAllUser { get; set; }

  [Column("_userIdString")]
  [Unicode(false)]
  public string? UserIdString { get; set; }

  [Column("_userIdCount")]
  public int? UserIdCount { get; set; }

  [Column("_senderName")]
  [StringLength(30)]
  public string? SenderName { get; set; }

  [Column("_title")]
  [StringLength(100)]
  public string? Title { get; set; }

  [Column("_contents")]
  [StringLength(500)]
  public string? Contents { get; set; }

  [Column("_itemKey")]
  public int? ItemKey { get; set; }

  [Column("_itemCount")]
  public long? ItemCount { get; set; }

  [Column("_enchantLevel")]
  public byte? EnchantLevel { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_sendingWaitingNo")]
  public long? SendingWaitingNo { get; set; }

  [Column("_isComplete")]
  public bool? IsComplete { get; set; }
}