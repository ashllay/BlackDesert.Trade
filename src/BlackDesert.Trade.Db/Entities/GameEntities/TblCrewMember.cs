using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCrewMember", Schema = "PaGamePrivate")]
public class TblCrewMember
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Column("_crewNo")]
  public long CrewNo { get; set; }

  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Column("_grade")]
  public byte Grade { get; set; }

  [Column("_winCount")]
  public int WinCount { get; set; }

  [Column("_loseCount")]
  public int LoseCount { get; set; }
}