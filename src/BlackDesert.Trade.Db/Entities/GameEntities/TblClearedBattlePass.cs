using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Key")]
[Table("TblClearedBattlePass", Schema = "PaGamePrivate")]
public class TblClearedBattlePass
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_key")]
  public int Key { get; set; }

  [Column("_seasonKey")]
  public int SeasonKey { get; set; }

  [Column("_basicItemDate", TypeName = "datetime")]
  public DateTime? BasicItemDate { get; set; }

  [Column("_premiumItemDate", TypeName = "datetime")]
  public DateTime? PremiumItemDate { get; set; }
}