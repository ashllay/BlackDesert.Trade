using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackDesert.Trade.Db.Entities.GameEntities;

[Keyless]
[Table("TblSeasonCloseQuestWithReward", Schema = "PaGamePrivate")]
public class TblSeasonCloseQuestWithReward
{
  [Column("_questGroupNo")]
  public int QuestGroupNo { get; set; }

  [Column("_questNo")]
  public int QuestNo { get; set; }

  [Column("_senderName")]
  [StringLength(30)]
  public string? SenderName { get; set; }

  [Column("_title")]
  [StringLength(100)]
  public string? Title { get; set; }

  [Column("_contents")]
  [StringLength(300)]
  public string? Contents { get; set; }

  [Column("_itemKey")]
  public int? ItemKey { get; set; }

  [Column("_itemCount")]
  public int? ItemCount { get; set; }
}