using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblOperationMention", Schema = "PaGamePrivate")]
public class TblOperationMention
{
  [Key]
  [Column("_mentionNo")]
  public long MentionNo { get; set; }

  [Column("_type")]
  public byte Type { get; set; }

  [Column("_mention")]
  [StringLength(50)]
  public string Mention { get; set; } = null!;

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_resourceType")]
  public short ResourceType { get; set; }
}