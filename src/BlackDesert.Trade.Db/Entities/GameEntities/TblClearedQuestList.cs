using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblClearedQuestList", Schema = "PaOperationPrivate")]
public class TblClearedQuestList
{
  [Column("_classType")]
  public int? ClassType { get; set; }

  [Column("_className")]
  [StringLength(30)]
  public string? ClassName { get; set; }

  [Column("_questGroupNo")]
  public int? QuestGroupNo { get; set; }

  [Column("_questNo")]
  public int? QuestNo { get; set; }
}