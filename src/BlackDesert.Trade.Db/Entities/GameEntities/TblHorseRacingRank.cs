using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "RankIndex", "MapKey")]
[Table("TblHorseRacingRank", Schema = "PaGamePrivate")]
public class TblHorseRacingRank
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_rankIndex")]
  public int RankIndex { get; set; }

  [Key]
  [Column("_mapKey")]
  public short MapKey { get; set; }

  [Column("_servantNo")]
  public long ServantNo { get; set; }

  [Column("_recordTick")]
  public long RecordTick { get; set; }

  [Column("_recordDate", TypeName = "datetime")]
  public DateTime RecordDate { get; set; }

  [Column("_playCount")]
  public int PlayCount { get; set; }

  [Column("_firstCount")]
  public int FirstCount { get; set; }

  [Column("_secondCount")]
  public int SecondCount { get; set; }

  [Column("_thirdCount")]
  public int ThirdCount { get; set; }
}