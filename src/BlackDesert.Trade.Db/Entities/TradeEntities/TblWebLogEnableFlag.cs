using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.TradeEntities;

[Keyless]
[Table("TblWebLogEnableFlag", Schema = "PaGamePrivate")]
public class TblWebLogEnableFlag
{
  [Column("_writeDebugLog")]
  public bool WriteDebugLog { get; set; }

  [Column("_writeInfoLog")]
  public bool WriteInfoLog { get; set; }

  [Required]
  [Column("_writeWarringLog")]
  public bool? WriteWarringLog { get; set; }

  [Required]
  [Column("_writeErrorLog")]
  public bool? WriteErrorLog { get; set; }

  [Required]
  [Column("_writeFatalLog")]
  public bool? WriteFatalLog { get; set; }
}