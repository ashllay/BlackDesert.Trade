using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblRestoreServantList", Schema = "PaOperationPublic")]
public class TblRestoreServantList
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_whereType")]
  public int? WhereType { get; set; }

  [Column("_servantNo")]
  public long? ServantNo { get; set; }

  [Column("_characterKey")]
  public int? CharacterKey { get; set; }

  [Column("_name")]
  [StringLength(30)]
  public string? Name { get; set; }

  [Column("_ownerNo")]
  public long? OwnerNo { get; set; }
}