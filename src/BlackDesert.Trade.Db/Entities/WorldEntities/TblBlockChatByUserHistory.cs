using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblBlockChatByUserHistory", Schema = "PaGamePrivate")]
public class TblBlockChatByUserHistory
{
  [Key]
  [Column("_blockNo")]
  public long BlockNo { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userId")]
  [StringLength(30)]
  public string? UserId { get; set; }

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_userIp")]
  [StringLength(15)]
  [Unicode(false)]
  public string? UserIp { get; set; }

  [Column("_targetCharacterName")]
  [StringLength(30)]
  public string TargetCharacterName { get; set; } = null!;

  [Column("_reasonChat")]
  [StringLength(350)]
  public string ReasonChat { get; set; } = null!;
}