using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterNo", "DuelCharacterNo")]
[Table("TblDuelCharacterInfo", Schema = "PaGamePrivate")]
public class TblDuelCharacterInfo
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Key]
  [Column("_duelCharacterNo")]
  public long DuelCharacterNo { get; set; }

  [Column("_addExperience")]
  public long AddExperience { get; set; }

  [Column("_addSkillPointExperience")]
  public long AddSkillPointExperience { get; set; }
}