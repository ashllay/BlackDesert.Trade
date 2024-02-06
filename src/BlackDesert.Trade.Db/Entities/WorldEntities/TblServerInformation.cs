using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblServerInformation", Schema = "PaGamePrivate")]
public class TblServerInformation
{
  [Key]
  [Column("_serverNo")]
  public int ServerNo { get; set; }

  [Column("_serverName")]
  [StringLength(30)]
  public string ServerName { get; set; } = null!;
}