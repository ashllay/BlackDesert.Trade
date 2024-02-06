using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblBlockType", Schema = "PaGamePublic")]
public class TblBlockType
{
  [Column("_index")]
  public long Index { get; set; }

  [Key]
  [Column("_blockCode")]
  public int BlockCode { get; set; }

  [Column("_duration")]
  public long Duration { get; set; }

  [Column("_blockReason")]
  [StringLength(200)]
  public string BlockReason { get; set; } = null!;

  [Required]
  [Column("_isUse")]
  public bool? IsUse { get; set; }

  [Column("_memo")]
  [StringLength(200)]
  public string Memo { get; set; } = null!;
}