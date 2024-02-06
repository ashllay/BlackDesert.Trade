using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.WorldEntities;

[Table("TblAdminCommandType", Schema = "PaOperationPrivate")]
public class TblAdminCommandType
{
  [Key]
  [Column("_commandTypeNo")]
  public int CommandTypeNo { get; set; }

  [Column("_command")]
  [StringLength(100)]
  public string? Command { get; set; }

  [Column("_paramCount")]
  public int ParamCount { get; set; }

  [Column("_commandDesc")]
  [StringLength(100)]
  public string? CommandDesc { get; set; }

  [Column("_paramDesc")]
  [StringLength(300)]
  public string? ParamDesc { get; set; }
}