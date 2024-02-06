using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "ServerNo", "UniqueIndex")]
[Table("TblInstanceFieldMatching", Schema = "PaGamePrivate")]
public class TblInstanceFieldMatching
{
  [Key]
  [Column("_serverNo")]
  public short ServerNo { get; set; }

  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Key]
  [Column("_uniqueIndex")]
  public int UniqueIndex { get; set; }

  [Column("_isMatching")]
  public byte IsMatching { get; set; }

  [Column("_matchedCount")]
  public int? MatchedCount { get; set; }

  [Column("_botCount")]
  public int? BotCount { get; set; }

  [Column("_hostUserNickName")]
  [StringLength(30)]
  public string? HostUserNickName { get; set; }

  [Column("_title")]
  [StringLength(30)]
  public string? Title { get; set; }

  [Column("_instanceFieldMapKey")]
  public int InstanceFieldMapKey { get; set; }

  [Column("_password")]
  [StringLength(10)]
  [Unicode(false)]
  public string? Password { get; set; }

  [Column("_partyId")]
  public long? PartyId { get; set; }

  [Column("_hostUserNo")]
  public long HostUserNo { get; set; }

  [Column("_sessionLevel")]
  public byte SessionLevel { get; set; }

  [Column("_aiLevel")]
  public short AiLevel { get; set; }

  [Column("_gameId")]
  [StringLength(30)]
  public string? GameId { get; set; }

  [Column("_closeFlag")]
  public byte CloseFlag { get; set; }

  [Column("_gameStartTime", TypeName = "datetime")]
  public DateTime GameStartTime { get; set; }
}