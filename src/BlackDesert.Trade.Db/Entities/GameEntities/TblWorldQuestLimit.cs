using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("QuestGroupNo", "QuestNo")]
[Table("TblWorldQuestLimit", Schema = "PaGamePrivate")]
public class TblWorldQuestLimit
{
  [Key]
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  [Key]
  [Column("_questNo")]
  public int QuestNo { get; set; }

  [Column("_clearedCount")]
  public int ClearedCount { get; set; }
}