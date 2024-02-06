using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Table("TblCrew", Schema = "PaGamePrivate")]
public class TblCrew
{
  [Column("_registerDate", TypeName = "datetime")]
  public DateTime RegisterDate { get; set; }

  [Key]
  [Column("_crewNo")]
  public long CrewNo { get; set; }

  [Column("_crewName")]
  [StringLength(30)]
  public string CrewName { get; set; } = null!;

  [Column("_masterUserNo")]
  public long MasterUserNo { get; set; }

  [Column("_masterUserNickname")]
  [StringLength(30)]
  public string MasterUserNickname { get; set; } = null!;

  [Column("_crewNotice")]
  [StringLength(300)]
  public string? CrewNotice { get; set; }

  [Column("_winCount")]
  public int WinCount { get; set; }

  [Column("_loseCount")]
  public int LoseCount { get; set; }
}