using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("IsUserBaseQuest", "QuestGroupNo", "QuestNo")]
[Table("TblBranchQuest", Schema = "PaGamePrivate")]
public class TblBranchQuest
{
  [Key]
  [Column("_isUserBaseQuest")]
  public bool IsUserBaseQuest { get; set; }

  [Key]
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  [Key]
  [Column("_questNo")]
  public int QuestNo { get; set; }
}