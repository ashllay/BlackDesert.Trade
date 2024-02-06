using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblFuelInsertCharacterSettingInfo", Schema = "PaGamePrivate")]
public class TblFuelInsertCharacterSettingInfo
{
  [Key]
  [Column("_objectNo")]
  public long ObjectNo { get; set; }

  [Column("_characterKey")]
  public int CharacterKey { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_fieldNo")]
  public short FieldNo { get; set; }

  [Column("_fieldIndex")]
  public short FieldIndex { get; set; }

  [Column("_posX")]
  public float PosX { get; set; }

  [Column("_posY")]
  public float PosY { get; set; }

  [Column("_posZ")]
  public float PosZ { get; set; }

  [Column("_dirX")]
  public double DirX { get; set; }

  [Column("_dirY")]
  public double DirY { get; set; }

  [Column("_dirZ")]
  public double DirZ { get; set; }

  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}