using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Season", "MapKey")]
[Table("TblHorseRacingPreTotalRank", Schema = "PaWebGamePrivate")]
public class TblHorseRacingPreTotalRank
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_userNickname")]
  [StringLength(30)]
  public string UserNickname { get; set; } = null!;

  [Column("_servantName")]
  [StringLength(30)]
  public string ServantName { get; set; } = null!;

  [Key]
  [Column("_season")]
  public int Season { get; set; }

  [Column("_rank")]
  public int Rank { get; set; }

  [Key]
  [Column("_mapKey")]
  public byte MapKey { get; set; }

  [Column("_playCount")]
  public int PlayCount { get; set; }

  [Column("_firstCount")]
  public int FirstCount { get; set; }

  [Column("_secondCount")]
  public int SecondCount { get; set; }

  [Column("_thirdCount")]
  public int ThirdCount { get; set; }

  [Column("_totalScore")]
  public int TotalScore { get; set; }
}