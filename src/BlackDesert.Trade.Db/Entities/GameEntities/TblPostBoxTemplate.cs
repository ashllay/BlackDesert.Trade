using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblPostBoxTemplate", Schema = "PaOperationPublic")]
public class TblPostBoxTemplate
{
  [Key]
  [Column("_templateNo")]
  public int TemplateNo { get; set; }

  [Column("_title")]
  [StringLength(200)]
  public string? Title { get; set; }

  [Column("_senderName")]
  [StringLength(200)]
  public string? SenderName { get; set; }

  [Column("_message")]
  [StringLength(1000)]
  public string? Message { get; set; }

  [Column("_memo")]
  [StringLength(200)]
  public string? Memo { get; set; }
}