using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[PrimaryKey("GroupContentno", "CultureCode")]
[Table("TblShutDownDetail", Schema = "PaGamePrivate")]
public class TblShutDownDetail
{
  [Key]
  [Column("_groupContentno")]
  public int GroupContentno { get; set; }

  [Key]
  [Column("_cultureCode")]
  [StringLength(8)]
  [Unicode(false)]
  public string CultureCode { get; set; } = null!;

  [Column("_mainMessage")]
  public string? MainMessage { get; set; }

  [Column("_subMessage")]
  public string? SubMessage { get; set; }

  [Column("_redirectUrl")]
  [StringLength(300)]
  public string? RedirectUrl { get; set; }

  [Column("_memo")]
  [StringLength(200)]
  public string? Memo { get; set; }
}