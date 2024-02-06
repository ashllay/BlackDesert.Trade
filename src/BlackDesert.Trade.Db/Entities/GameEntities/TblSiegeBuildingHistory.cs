using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSiegeBuildingHistory", Schema = "PaGamePrivate")]
public class TblSiegeBuildingHistory
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime? RegisterDate { get; set; }

  [Column("_siegeHistoryDate")]
  public int? SiegeHistoryDate { get; set; }

  [Column("isVillageSiege")]
  public bool IsVillageSiege { get; set; }

  [Column("_guildNo")]
  public long GuildNo { get; set; }

  [Column("_guildName")]
  [StringLength(30)]
  public string GuildName { get; set; } = null!;

  [Column("_masterUserNo")]
  public long? MasterUserNo { get; set; }

  [Column("_masterUserNickname")]
  [StringLength(30)]
  public string? MasterUserNickname { get; set; }

  [Column("_guildMark")]
  public byte[]? GuildMark { get; set; }

  [Column("_itemKey")]
  public int ItemKey { get; set; }

  [Column("_territoryKey")]
  public int? TerritoryKey { get; set; }

  [Column("_buildRegionKey")]
  public int? BuildRegionKey { get; set; }

  [Column("_posX")]
  public double PosX { get; set; }

  [Column("_posY")]
  public double PosY { get; set; }

  [Column("_posZ")]
  public double PosZ { get; set; }

  [Column("_createdDate", TypeName = "datetime")]
  public DateTime CreatedDate { get; set; }

  [Column("_completedDate", TypeName = "datetime")]
  public DateTime CompletedDate { get; set; }

  [Column("_destroyedDate", TypeName = "datetime")]
  public DateTime? DestroyedDate { get; set; }

  [Column("_destroyerGuildNo")]
  public long? DestroyerGuildNo { get; set; }

  [Column("_destoryerGuildName")]
  [StringLength(30)]
  public string? DestoryerGuildName { get; set; }

  [Column("_destroyermasterUserNo")]
  public long? DestroyermasterUserNo { get; set; }

  [Column("_destroyermasterUserNickname")]
  [StringLength(30)]
  public string? DestroyermasterUserNickname { get; set; }

  [Column("_destroyerguildMark")]
  public byte[]? DestroyerguildMark { get; set; }

  [Column("_destroyerCharacterNo")]
  public long? DestroyerCharacterNo { get; set; }

  [Column("_destroyerCharacterName")]
  [StringLength(30)]
  public string? DestroyerCharacterName { get; set; }
}