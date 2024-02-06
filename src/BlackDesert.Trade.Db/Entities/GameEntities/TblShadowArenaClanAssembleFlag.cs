using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblShadowArenaClanAssembleFlag", Schema = "PaGamePrivate")]
public class TblShadowArenaClanAssembleFlag
{
  [Key]
  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Column("_uniqueIndex")]
  public int UniqueIndex { get; set; }

  [Column("_positionX")]
  public long PositionX { get; set; }

  [Column("_positionY")]
  public long PositionY { get; set; }

  [Column("_positionZ")]
  public long PositionZ { get; set; }

  [Column("_summonTime", TypeName = "datetime")]
  public DateTime SummonTime { get; set; }
}