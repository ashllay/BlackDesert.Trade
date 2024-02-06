using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "SeasonKey")]
[Table("TblBattlePass", Schema = "PaGamePrivate")]
public class TblBattlePass
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_seasonKey")]
  public int SeasonKey { get; set; }

  [Column("_point")]
  public int Point { get; set; }

  [Column("_isPremium")]
  public bool IsPremium { get; set; }
}