using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblFuelInsertCharacterInfo", Schema = "PaGamePrivate")]
public class TblFuelInsertCharacterInfo
{
  [Column("_ownerNo")]
  public long OwnerNo { get; set; }

  [Column("_objectNo")]
  public long ObjectNo { get; set; }

  [Column("_count")]
  public long Count { get; set; }

  [Column("_hp")]
  public int? Hp { get; set; }

  [Column("_objectState")]
  public byte ObjectState { get; set; }

  [Column("_lastUpdateTime", TypeName = "datetime")]
  public DateTime LastUpdateTime { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}