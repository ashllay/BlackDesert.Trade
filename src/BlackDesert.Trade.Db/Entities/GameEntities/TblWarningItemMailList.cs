using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblWarningItemMailList", Schema = "PaOperationPrivate")]
public class TblWarningItemMailList
{
  [Column("_mailRequestNo")]
  public int MailRequestNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_isSended")]
  public bool IsSended { get; set; }

  [Column("_noteNo")]
  [StringLength(50)]
  public string NoteNo { get; set; } = null!;

  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_senderName")]
  [StringLength(30)]
  public string SenderName { get; set; } = null!;

  [Column("_title")]
  [StringLength(100)]
  public string Title { get; set; } = null!;

  [Column("_contents")]
  public string Contents { get; set; } = null!;

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_itemCount")]
  public long? ItemCount { get; set; }

  [Column("_enchantLevel")]
  public byte EnchantLevel { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_noteURL")]
  [StringLength(300)]
  public string? NoteUrl { get; set; }
}