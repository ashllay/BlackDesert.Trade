using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblHarvestInstallation", Schema = "PaGamePrivate")]
public class TblHarvestInstallation
{
  [Key]
  [Column("_installationNo")]
  public long InstallationNo { get; set; }

  [Column("_remainLopCount")]
  public byte RemainLopCount { get; set; }

  [Column("_remainPestCount")]
  public byte RemainPestCount { get; set; }

  [Column("_remainBirdAttackCount")]
  public byte RemainBirdAttackCount { get; set; }

  [Column("_nextType")]
  public byte NextType { get; set; }

  [Column("_remainEventTime")]
  public long RemainEventTime { get; set; }
}