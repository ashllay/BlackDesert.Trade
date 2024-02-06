using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblPearlUsedLastMonthAmount", Schema = "PaGamePrivate")]
public class TblPearlUsedLastMonthAmount
{
  [Column("_lastRegisterDate", TypeName = "datetime")]
  public DateTime LastRegisterDate { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_pearlObtainedMonthly")]
  public long PearlObtainedMonthly { get; set; }

  [Column("_pearlUsedMonthly")]
  public long PearlUsedMonthly { get; set; }
}