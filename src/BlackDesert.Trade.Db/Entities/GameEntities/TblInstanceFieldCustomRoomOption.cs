using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "ServerNo", "UniqueIndex")]
[Table("TblInstanceFieldCustomRoomOption", Schema = "PaGamePrivate")]
public class TblInstanceFieldCustomRoomOption
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

  [Column("_hostUserNo")]
  public long HostUserNo { get; set; }

  [Column("_isShow")]
  public bool IsShow { get; set; }

  [Column("_aiCount")]
  public int AiCount { get; set; }

  [Column("_aiLevel")]
  public short AiLevel { get; set; }

  [Column("_isHostObserver")]
  public bool IsHostObserver { get; set; }

  [Column("_isShowNickName")]
  public bool IsShowNickName { get; set; }

  [Column("_minTier")]
  public byte MinTier { get; set; }

  [Column("_maxTier")]
  public byte MaxTier { get; set; }

  [Column("_matchType")]
  public byte MatchType { get; set; }
}