using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "SessionLevel", "AiLevel")]
[Table("TblInstanceFieldCurruetServerNo", Schema = "PaGamePrivate")]
public class TblInstanceFieldCurruetServerNo
{
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Key]
  [Column("_sessionLevel")]
  public byte SessionLevel { get; set; }

  [Key]
  [Column("_aiLevel")]
  public short AiLevel { get; set; }
}