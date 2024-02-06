using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "LandKey", "BuildingKey")]
[Table("TblMansionListForTownManagement", Schema = "PaGamePrivate")]
public class TblMansionListForTownManagement
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_landKey")]
  public int LandKey { get; set; }

  [Column("_householdNoLand")]
  public long HouseholdNoLand { get; set; }

  [Column("_interiorSensePointLand")]
  public int InteriorSensePointLand { get; set; }

  [Column("_basePointLand")]
  public int BasePointLand { get; set; }

  [Column("_emptyPointLand")]
  public int EmptyPointLand { get; set; }

  [Column("_bonusPointLand")]
  public int BonusPointLand { get; set; }

  [Key]
  [Column("_buildingKey")]
  public int BuildingKey { get; set; }

  [Column("_householdNoBuilding")]
  public long HouseholdNoBuilding { get; set; }

  [Column("_interiorSensePointBuilding")]
  public int InteriorSensePointBuilding { get; set; }

  [Column("_basePointBuilding")]
  public int BasePointBuilding { get; set; }

  [Column("_emptyPointBuilding")]
  public int EmptyPointBuilding { get; set; }

  [Column("_bonusPointBuilding")]
  public int BonusPointBuilding { get; set; }

  [Column("_interiorSensePoint")]
  public int InteriorSensePoint { get; set; }

  [Column("_setPoint")]
  public int SetPoint { get; set; }

  [Column("_interiorUpdateTime", TypeName = "datetime")]
  public DateTime? InteriorUpdateTime { get; set; }
}