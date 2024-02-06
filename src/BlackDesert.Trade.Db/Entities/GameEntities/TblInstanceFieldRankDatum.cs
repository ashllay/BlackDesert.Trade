using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("InstanceFieldKey", "SeasonKey", "Mmr", "UserNo")]
[Table("TblInstanceFieldRankData", Schema = "PaGamePrivate")]
public class TblInstanceFieldRankDatum
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

  [Column("_tier")]
  public byte Tier { get; set; }

  [Column("_tierPoint")]
  public int TierPoint { get; set; }

  [Column("_playCount")]
  public int PlayCount { get; set; }

  [Column("_bestSessionPoint")]
  public int BestSessionPoint { get; set; }

  [Column("_sumSessionPoint")]
  public int SumSessionPoint { get; set; }

  [Column("_rankPoint")]
  public long RankPoint { get; set; }

  [Column("_sumKillCount")]
  public int SumKillCount { get; set; }

  [Column("_prevRankPoint")]
  public long PrevRankPoint { get; set; }

  [Column("_defeatStack")]
  public int DefeatStack { get; set; }

  [Key]
  [Column("_MMR")]
  public long Mmr { get; set; }
}