using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("UserNo", "QuestNo")]
[Table("TblBlackSpiritAdventureQuest", Schema = "PaWebGamePrivate")]
public class TblBlackSpiritAdventureQuest
{
  [Key]
  [Column("_userNo")]
  public long UserNo { get; set; }

  [Key]
  [Column("_questNo")]
  public int QuestNo { get; set; }

  [Column("_questGroupIndex")]
  public int QuestGroupIndex { get; set; }

  [Column("_questSequence")]
  public int QuestSequence { get; set; }

  [Column("_monsterKey")]
  public int MonsterKey { get; set; }

  [Column("_isBossQuest")]
  public bool IsBossQuest { get; set; }

  [Column("_isComplete")]
  public bool IsComplete { get; set; }

  [Column("_startDate", TypeName = "datetime")]
  public DateTime? StartDate { get; set; }

  [Column("_completeDate", TypeName = "datetime")]
  public DateTime? CompleteDate { get; set; }
}