using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSyncWebUserInformation_Snap", Schema = "PaWebGamePrivate")]
public class TblSyncWebUserInformationSnap
{
  [Column("_userId")]
  [StringLength(30)]
  public string UserId { get; set; } = null!;

  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_characterNo")]
  public long CharacterNo { get; set; }

  [Column("_characterName")]
  [StringLength(30)]
  public string CharacterName { get; set; } = null!;

  [Column("_level")]
  public int Level { get; set; }

  [Column("_createDate", TypeName = "datetime")]
  public DateTime CreateDate { get; set; }

  [Column("_isValid")]
  public bool IsValid { get; set; }

  [Column("_classType")]
  public byte ClassType { get; set; }

  [Column("_deletedDate", TypeName = "datetime")]
  public DateTime? DeletedDate { get; set; }

  [Column("_aquiredPoint")]
  public int AquiredPoint { get; set; }

  [Column("_isGM")]
  public bool IsGm { get; set; }

  [Column("_offenceValue")]
  public int OffenceValue { get; set; }

  [Column("_defenceValue")]
  public int DefenceValue { get; set; }

  [Column("_guildNo")]
  public long? GuildNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string? GuildName { get; set; }
}