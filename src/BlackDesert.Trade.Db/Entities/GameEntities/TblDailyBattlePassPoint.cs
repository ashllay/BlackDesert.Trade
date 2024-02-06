using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "Type")]
[Table("TblDailyBattlePassPoint", Schema = "PaGamePrivate")]
public class TblDailyBattlePassPoint
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_point")]
  public int Point { get; set; }

  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }
}