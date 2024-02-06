using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblGuildRecommend", Schema = "PaGamePrivate")]
public class TblGuildRecommend
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_recommenGuildNo")]
  public long RecommenGuildNo { get; set; }

  [Column("_decommendGuildNo")]
  public long DecommendGuildNo { get; set; }
}