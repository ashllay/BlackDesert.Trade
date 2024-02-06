using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblFamilySpecialInformation", Schema = "PaGamePrivate")]
public class TblFamilySpecialInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_statPoint")]
  public int StatPoint { get; set; }

  [Column("_param1")]
  public int Param1 { get; set; }

  [Column("_param1Point")]
  public int Param1Point { get; set; }

  [Column("_param2")]
  public int Param2 { get; set; }

  [Column("_param2Point")]
  public int Param2Point { get; set; }

  [Column("_param3")]
  public int Param3 { get; set; }

  [Column("_param3Point")]
  public int Param3Point { get; set; }

  [Column("_param4")]
  public int Param4 { get; set; }

  [Column("_param4Point")]
  public int Param4Point { get; set; }

  [Column("_param5")]
  public int Param5 { get; set; }

  [Column("_param5Point")]
  public int Param5Point { get; set; }

  [Column("_param6")]
  public int Param6 { get; set; }

  [Column("_param6Point")]
  public int Param6Point { get; set; }

  [Column("_param7")]
  public int Param7 { get; set; }

  [Column("_param7Point")]
  public int Param7Point { get; set; }

  [Column("_param8")]
  public int Param8 { get; set; }

  [Column("_param8Point")]
  public int Param8Point { get; set; }

  [Column("_param9")]
  public int Param9 { get; set; }

  [Column("_param9Point")]
  public int Param9Point { get; set; }

  [Column("_param10")]
  public int Param10 { get; set; }

  [Column("_param10Point")]
  public int Param10Point { get; set; }

  [Column("_param11")]
  public int Param11 { get; set; }

  [Column("_param11Point")]
  public int Param11Point { get; set; }

  [Column("_param12")]
  public int Param12 { get; set; }

  [Column("_param12Point")]
  public int Param12Point { get; set; }

  [Column("_param13")]
  public int Param13 { get; set; }

  [Column("_param13Point")]
  public int Param13Point { get; set; }

  [Column("_param14")]
  public int Param14 { get; set; }

  [Column("_param14Point")]
  public int Param14Point { get; set; }

  [Column("_param15")]
  public int Param15 { get; set; }

  [Column("_param15Point")]
  public int Param15Point { get; set; }

  [Column("_param16")]
  public int Param16 { get; set; }

  [Column("_param16Point")]
  public int Param16Point { get; set; }
}