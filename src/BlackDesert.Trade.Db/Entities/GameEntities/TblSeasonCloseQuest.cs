using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseQuest", Schema = "PaGamePrivate")]
public class TblSeasonCloseQuest
{
  [Column("_type")]
  public byte Type { get; set; }

  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  [Column("_questNo")]
  public int QuestNo { get; set; }
}