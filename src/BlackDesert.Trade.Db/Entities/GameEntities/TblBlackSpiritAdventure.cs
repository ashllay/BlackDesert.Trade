using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblBlackSpiritAdventure", Schema = "PaWebGamePrivate")]
public class TblBlackSpiritAdventure
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_regionKey")]
  public int RegionKey { get; set; }

  [Column("_territoryKey")]
  public int TerritoryKey { get; set; }

  [Column("_remainMoveCount")]
  public byte RemainMoveCount { get; set; }

  [Column("_todayChargeCount")]
  public byte TodayChargeCount { get; set; }

  [Column("_level")]
  public byte Level { get; set; }

  [Column("_exp")]
  public int Exp { get; set; }

  [Column("_isMainQuest")]
  public bool IsMainQuest { get; set; }

  [Column("_mapPiece")]
  [StringLength(10)]
  public string? MapPiece { get; set; }

  [Column("_boxRegionKey")]
  public int? BoxRegionKey { get; set; }

  [Column("_restUpdateDate", TypeName = "datetime")]
  public DateTime? RestUpdateDate { get; set; }

  [Column("_moveCountUpdateDate", TypeName = "datetime")]
  public DateTime MoveCountUpdateDate { get; set; }

  [Column("_lastPlayDate", TypeName = "datetime")]
  public DateTime LastPlayDate { get; set; }
}