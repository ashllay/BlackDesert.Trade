using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("CharacterNo1", "CharacterNo2", "ChangedDate")]
[Table("TblNameExchangeComplete", Schema = "PaGamePrivate")]
public class TblNameExchangeComplete
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  [Key]
  [Column("_characterNo1")]
  public long CharacterNo1 { get; set; }

  [Key]
  [Column("_characterNo2")]
  public long CharacterNo2 { get; set; }

  [Key]
  [Column("_changedDate", TypeName = "datetime")]
  public DateTime ChangedDate { get; set; }
}