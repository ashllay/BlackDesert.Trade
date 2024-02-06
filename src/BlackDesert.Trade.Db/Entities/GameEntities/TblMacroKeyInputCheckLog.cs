using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblMacroKeyInputCheckLog", Schema = "PaGamePrivate")]
public class TblMacroKeyInputCheckLog
{
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_startDate", TypeName = "datetime")]
  public DateTime StartDate { get; set; }

  [Column("_inputCount")]
  public int InputCount { get; set; }

  [Column("_textParam1")]
  [StringLength(4000)]
  public string? TextParam1 { get; set; }

  [Column("_textParam2")]
  [StringLength(4000)]
  public string? TextParam2 { get; set; }

  [Column("_textParam3")]
  [StringLength(4000)]
  public string? TextParam3 { get; set; }

  [Column("_textParam4")]
  [StringLength(4000)]
  public string? TextParam4 { get; set; }
}