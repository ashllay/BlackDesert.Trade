using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "EmployeeNo")]
[Table("TblEmployeeRepository", Schema = "PaGamePrivate")]
public class TblEmployeeRepository
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_employeeNo")]
  public long EmployeeNo { get; set; }

  [Column("_variousNo")]
  public long VariousNo { get; set; }

  [Column("_employeeJob")]
  public byte EmployeeJob { get; set; }

  [Column("_employeeKey")]
  public int EmployeeKey { get; set; }

  [Column("_employeeNameKey")]
  public int EmployeeNameKey { get; set; }

  [Column("_loyalty")]
  public int Loyalty { get; set; }

  [Column("_exp")]
  public long Exp { get; set; }

  [Column("_isApply")]
  public bool IsApply { get; set; }

  [Column("_state")]
  public byte State { get; set; }

  [Column("_param0")]
  public int Param0 { get; set; }

  [Column("_param1")]
  public int Param1 { get; set; }

  [Column("_param2")]
  public int Param2 { get; set; }

  [Column("_param3")]
  public int Param3 { get; set; }

  [Column("_param4")]
  public int Param4 { get; set; }

  [Column("_param5")]
  public int Param5 { get; set; }

  [Column("_param6")]
  public int Param6 { get; set; }

  [Column("_param7")]
  public int Param7 { get; set; }

  [Column("_param8")]
  public int Param8 { get; set; }

  [Column("_param9")]
  public int Param9 { get; set; }

  [Column("_param10")]
  public int Param10 { get; set; }

  [Column("_param11")]
  public int Param11 { get; set; }

  [Column("_param12")]
  public int Param12 { get; set; }

  [Column("_param13")]
  public int Param13 { get; set; }

  [Column("_param14")]
  public int Param14 { get; set; }

  [Column("_param15")]
  public int Param15 { get; set; }

  [Column("_param16")]
  public int Param16 { get; set; }
}