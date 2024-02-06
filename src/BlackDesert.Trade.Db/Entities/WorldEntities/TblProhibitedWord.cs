using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblProhibitedWord", Schema = "PaGamePublic")]
public class TblProhibitedWord
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Key]
  [Column("_prohibitedWord")]
  [StringLength(30)]
  public string ProhibitedWord { get; set; } = null!;
}