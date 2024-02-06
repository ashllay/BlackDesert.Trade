using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[PrimaryKey("ServerVersion", "ServerDataCrc")]
[Table("TblServerDataCRC", Schema = "PaGamePrivate")]
public class TblServerDataCrc
{
  [Column("_registDate", TypeName = "datetime")]
  public DateTime RegistDate { get; set; }

  [Key]
  [Column("_serverDataCRC")]
  public long ServerDataCrc { get; set; }

  [Key]
  [Column("_serverVersion")]
  public int ServerVersion { get; set; }
}