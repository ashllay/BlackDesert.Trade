using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Table("TblContentMst", Schema = "PaGamePrivate")]
public class TblContentMst
{
  [Key]
  [Column("_groupContentNo")]
  public int GroupContentNo { get; set; }

  [Column("_contentStartDate", TypeName = "datetime")]
  public DateTime? ContentStartDate { get; set; }

  [Column("_contentEndDate", TypeName = "datetime")]
  public DateTime? ContentEndDate { get; set; }

  [Required]
  [Column("_isDisplay")]
  public bool? IsDisplay { get; set; }

  [Column("_isDelete")]
  public bool IsDelete { get; set; }

  [Column("_regDate", TypeName = "datetime")]
  public DateTime RegDate { get; set; }

  [Column("_updDate", TypeName = "datetime")]
  public DateTime? UpdDate { get; set; }
}