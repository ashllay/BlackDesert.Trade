using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "SeasonKey", "RankPoint", "UserNo")]
[Table("TblInstanceFieldNormalData", Schema = "PaGamePrivate")]
public class TblInstanceFieldNormalDatum
{
  [Key]
  [Column("_instanceFieldKey")]
  public int InstanceFieldKey { get; set; }

  [Key]
  [Column("_seasonKey")]
  public int SeasonKey { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_playCount")]
  public int PlayCount { get; set; }

  [Column("_sumKillCount")]
  public int SumKillCount { get; set; }

  [Column("_bestSessionPoint")]
  public int BestSessionPoint { get; set; }

  [Column("_sumSessionPoint")]
  public int SumSessionPoint { get; set; }

  [Key]
  [Column("_rankPoint")]
  public long RankPoint { get; set; }
}