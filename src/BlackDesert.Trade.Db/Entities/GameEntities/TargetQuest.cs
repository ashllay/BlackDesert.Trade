using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("QuestGroupNo", "QuestNo")]
[Table("TargetQuest", Schema = "PaOperationPrivate")]
public class TargetQuest
{
  [Key]
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  [Key]
  [Column("_questNo")]
  public int QuestNo { get; set; }
}