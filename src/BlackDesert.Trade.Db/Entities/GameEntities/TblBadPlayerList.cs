using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("CharacterNo", "BadCharacterNo", "DeadTime")]
[Table("TblBadPlayerList", Schema = "PaGamePrivate")]
public class TblBadPlayerList
{
  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Key]
  [Column("_badCharacterNo")]
  public long BadCharacterNo { get; set; }

  [Column("_badUserNickname")]
  [StringLength(30)]
  public string BadUserNickname { get; set; } = null!;

  [Column("_badCharacterName")]
  [StringLength(30)]
  public string BadCharacterName { get; set; } = null!;

  [Column("_deadRegion")]
  [StringLength(30)]
  public string DeadRegion { get; set; } = null!;

  [Key]
  [Column("_deadTime", TypeName = "datetime")]
  public DateTime DeadTime { get; set; }
}