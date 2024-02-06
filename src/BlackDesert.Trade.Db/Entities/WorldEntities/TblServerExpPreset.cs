using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("SavePresetName", "ServerNo")]
[Table("TblServerExpPreset", Schema = "PaOperationPrivate")]
public class TblServerExpPreset
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_savePresetName")]
  [StringLength(30)]
  public string SavePresetName { get; set; } = null!;

  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_isShowExpEvent")]
  public bool IsShowExpEvent { get; set; }

  [Column("_isShowDropEvent")]
  public bool IsShowDropEvent { get; set; }

  [Column("_battleExp")]
  public int BattleExp { get; set; }

  [Column("_battleDrop")]
  public int BattleDrop { get; set; }

  [Column("_skillExp")]
  public int SkillExp { get; set; }

  [Column("_vehicleExp")]
  public int VehicleExp { get; set; }

  [Column("_lifeExp1")]
  public int LifeExp1 { get; set; }

  [Column("_lifeDrop1")]
  public int LifeDrop1 { get; set; }

  [Column("_lifeExp2")]
  public int LifeExp2 { get; set; }

  [Column("_lifeDrop2")]
  public int LifeDrop2 { get; set; }

  [Column("_lifeExp3")]
  public int LifeExp3 { get; set; }

  [Column("_lifeDrop3")]
  public int LifeDrop3 { get; set; }

  [Column("_lifeExp4")]
  public int LifeExp4 { get; set; }

  [Column("_lifeDrop4")]
  public int LifeDrop4 { get; set; }

  [Column("_lifeExp5")]
  public int LifeExp5 { get; set; }

  [Column("_lifeDrop5")]
  public int LifeDrop5 { get; set; }

  [Column("_lifeExp6")]
  public int LifeExp6 { get; set; }

  [Column("_lifeDrop6")]
  public int LifeDrop6 { get; set; }

  [Column("_lifeExp7")]
  public int LifeExp7 { get; set; }

  [Column("_lifeDrop7")]
  public int LifeDrop7 { get; set; }

  [Column("_lifeExp8")]
  public int LifeExp8 { get; set; }

  [Column("_lifeDrop8")]
  public int LifeDrop8 { get; set; }

  [Column("_lifeExp9")]
  public int LifeExp9 { get; set; }

  [Column("_lifeDrop9")]
  public int LifeDrop9 { get; set; }

  [Column("_lifeExp10")]
  public int LifeExp10 { get; set; }

  [Column("_lifeDrop10")]
  public int LifeDrop10 { get; set; }

  [Column("_battleExpTooltipText")]
  [StringLength(30)]
  public string? BattleExpTooltipText { get; set; }

  [Column("_lifeExp11")]
  public int LifeExp11 { get; set; }

  [Column("_lifeDrop11")]
  public int LifeDrop11 { get; set; }

  [Column("_lifeExp12")]
  public int LifeExp12 { get; set; }

  [Column("_lifeDrop12")]
  public int LifeDrop12 { get; set; }

  [Column("_lifeExp13")]
  public int LifeExp13 { get; set; }

  [Column("_lifeDrop13")]
  public int LifeDrop13 { get; set; }

  [Column("_lifeExp14")]
  public int LifeExp14 { get; set; }

  [Column("_lifeDrop14")]
  public int LifeDrop14 { get; set; }

  [Column("_lifeExp15")]
  public int LifeExp15 { get; set; }

  [Column("_lifeDrop15")]
  public int LifeDrop15 { get; set; }
}