using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonResetMail", Schema = "PaGamePrivate")]
public class TblSeasonResetMail
{
  [Column("_region")]
  [StringLength(10)]
  public string? Region { get; set; }

  [Column("_infoNo")]
  public int? InfoNo { get; set; }

  [Column("_info")]
  [StringLength(50)]
  public string? Info { get; set; }

  [Column("_senderName")]
  [StringLength(50)]
  public string? SenderName { get; set; }

  [Column("_title")]
  [StringLength(50)]
  public string? Title { get; set; }

  [Column("_contents")]
  [StringLength(500)]
  public string? Contents { get; set; }

  [Column("_itemKey")]
  public int? ItemKey { get; set; }

  [Column("_itemCount")]
  public int? ItemCount { get; set; }
}