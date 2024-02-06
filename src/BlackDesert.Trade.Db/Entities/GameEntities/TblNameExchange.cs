using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblNameExchange", Schema = "PaGamePrivate")]
public class TblNameExchange
{
  [Column("_character1No")]
  public long Character1No { get; set; }

  [Column("_character2No")]
  public long Character2No { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  [Column("_character2Name")]
  [StringLength(30)]
  public string Character2Name { get; set; } = null!;

  [Column("_character1Name")]
  [StringLength(30)]
  public string Character1Name { get; set; } = null!;
}