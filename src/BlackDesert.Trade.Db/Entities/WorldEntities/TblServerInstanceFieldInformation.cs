using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Keyless]
[Table("TblServerInstanceFieldInformation", Schema = "PaGamePrivate")]
public class TblServerInstanceFieldInformation
{
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_instanceFieldType")]
  public short InstanceFieldType { get; set; }

  [Column("_instanceFieldMode")]
  public short InstanceFieldMode { get; set; }

  [Column("_instanceFieldMapKey")]
  public short InstanceFieldMapKey { get; set; }

  [Column("_count")]
  public short Count { get; set; }
}