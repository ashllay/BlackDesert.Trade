using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblUserPlayTimeLog", Schema = "PaGamePrivate")]
public class TblUserPlayTimeLog
{
  [Column("_mDate")]
  public int? MDate { get; set; }

  [Column("_userNo")]
  public long? UserNo { get; set; }

  [Column("_pcRoomPlayTimePerDay")]
  public int? PcRoomPlayTimePerDay { get; set; }

  [Column("_playTimePerDay")]
  public int? PlayTimePerDay { get; set; }
}