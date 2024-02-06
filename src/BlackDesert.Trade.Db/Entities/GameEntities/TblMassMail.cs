using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMassMail", Schema = "PaGamePrivate")]
public class TblMassMail
{
  [Column("_massMailNo")]
  public long MassMailNo { get; set; }

  [Column("_senderName")]
  [StringLength(30)]
  public string SenderName { get; set; } = null!;

  [Column("_title")]
  [StringLength(100)]
  public string Title { get; set; } = null!;

  [Column("_itemKey")]
  public long? ItemKey { get; set; }

  [Column("_itemCount")]
  public long? ItemCount { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_contents")]
  [StringLength(500)]
  public string Contents { get; set; } = null!;
}