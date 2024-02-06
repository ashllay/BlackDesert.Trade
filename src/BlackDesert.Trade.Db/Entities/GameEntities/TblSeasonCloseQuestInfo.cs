using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[PrimaryKey("QuestGroupNo", "QuestNo", "CloseType")]
[Table("TblSeasonCloseQuestInfo", Schema = "PaGamePrivate")]
public class TblSeasonCloseQuestInfo
{
  [Key]
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  [Key]
  [Column("_questNo")]
  public int QuestNo { get; set; }

  [Key]
  [Column("_closeType")]
  public int CloseType { get; set; }
}