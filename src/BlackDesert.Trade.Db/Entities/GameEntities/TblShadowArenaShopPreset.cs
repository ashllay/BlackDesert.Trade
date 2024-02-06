using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "InstanceContentsType", "InstanceContentsMode", "ClassType", "PresetIndex")]
[Table("TblShadowArenaShopPreset", Schema = "PaGamePrivate")]
public class TblShadowArenaShopPreset
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_instanceContentsType")]
  public short InstanceContentsType { get; set; }

  [Key]
  [Column("_instanceContentsMode")]
  public short InstanceContentsMode { get; set; }

  [Key]
  [Column("_classType")]
  public byte ClassType { get; set; }

  [Key]
  [Column("_presetIndex")]
  public int PresetIndex { get; set; }

  [Column("_presetName")]
  [StringLength(30)]
  public string PresetName { get; set; } = null!;

  [Column("_itemRoute")]
  [StringLength(2000)]
  public string ItemRoute { get; set; } = null!;
}