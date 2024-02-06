using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "CharacterNo")]
[Table("TblCharacterSpecialInformation", Schema = "PaGamePrivate")]
public class TblCharacterSpecialInformation
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_characterNo")]
  public long CharacterNo { get; set; }

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