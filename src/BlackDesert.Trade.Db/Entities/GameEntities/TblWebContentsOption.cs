using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblWebContentsOption", Schema = "PaWebGamePrivate")]
public class TblWebContentsOption
{
  [Key]
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_startDate", TypeName = "datetime")]
  public DateTime StartDate { get; set; }

  [Column("_endDate", TypeName = "datetime")]
  public DateTime EndDate { get; set; }
}