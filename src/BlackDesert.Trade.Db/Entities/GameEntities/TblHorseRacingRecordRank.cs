using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Season", "MapKey")]
[Table("TblHorseRacingRecordRank", Schema = "PaWebGamePrivate")]
public class TblHorseRacingRecordRank
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

  [Column("_recordTick")]
  public long RecordTick { get; set; }

  [Column("_recordDate", TypeName = "datetime")]
  public DateTime RecordDate { get; set; }
}